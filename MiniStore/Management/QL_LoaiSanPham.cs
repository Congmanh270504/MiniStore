using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.Management
{
    public partial class QL_LoaiSanPham : Form
    {
        DBConnect db;
        SqlDataAdapter da_categories;
        DataTable categories;
        public QL_LoaiSanPham()
        {
            InitializeComponent();
            db = new DBConnect("miniMKT");
        }

        private void QL_LoaiSanPham_Load(object sender, EventArgs e)
        {
            load_category();
        }

        void load_category()
        {
            string sql = "select * from Categories";
            da_categories = db.getDataAdapter(sql, "Categories");
            categories = db.Dset.Tables["Categories"];
            dataGridView.DataSource = categories;

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = categories.Columns["CategoryID"];
            categories.PrimaryKey = primaryKey;
            dataGridView.Columns["CategoryID"].HeaderText = "Mã loại sản phẩm";
            dataGridView.Columns["CategoryName"].HeaderText = "Tên loại sản phẩm";

            // Center the header text
            dataGridView.Columns["CategoryID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["CategoryName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.Columns["CategoryID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["CategoryName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView.Columns["CategoryID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.Columns["CategoryID"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dataGridView.Columns["CategoryName"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;

            txtLoaiSanPham.DataBindings.Add(new Binding("Text", categories, "CategoryName", true, DataSourceUpdateMode.Never));
        }

        private void QL_LoaiSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtLoaiSanPham.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên loại sản phẩm !!", "Chưa nhập tên món ăn", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtLoaiSanPham.Focus();
                return;
            }
            if (db.checkExist(string.Format("select count(*) from Suppliers where SupplierName = N'{0}'", txtLoaiSanPham.Text)))
            {
                if (MessageBox.Show("Tên sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                {
                    txtLoaiSanPham.Focus();
                }
                return;
            }
            string sql = string.Format(
            "INSERT INTO Categories(CategoryName) " + "VALUES( N'{0}')", txtLoaiSanPham.Text);
            db.updateToDataBase(sql);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            load_category();
            txtLoaiSanPham.Clear();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Dong.Enabled = true;

            txtLoaiSanPham.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txtLoaiSanPham.Text == string.Empty)
            {
                MessageBox.Show("Không Được Để Trống Tên Loại Sản Phẩm");
                txtLoaiSanPham.Focus();
                return;
            }

            string tensp = txtLoaiSanPham.Text;

            //if (txtb_Maloaisp.Enabled == true)
            //{
            //    DataRow insert = categories.NewRow();
            //    insert["CategoryName"] = txtLoaiSanPham.Text;
            //    categories.Rows.Add(insert);
            //}
            //else
            //{
            //    DataRow update = categories.Rows.Find(txtb_Maloaisp.Text);
            //    if (update != null)
            //    {
            //        update["CategoryName"] = tensp;
            //    }
            //}

            SqlCommandBuilder cb = new SqlCommandBuilder(da_categories);
            da_categories.Update(db.Dset, "Categories");
            MessageBox.Show("Thành Công !");

            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Dong.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int productId = (int)dataGridView.CurrentRow.Cells["CategoryID"].Value;

                // Find the DataRow to delete
                DataRow rowToDelete = categories.Rows.Find(productId);
                if (rowToDelete != null)
                {
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM Categories WHERE CategoryID = @CategoryID", da_categories.SelectCommand.Connection);
                    deleteCommand.Parameters.Add("@CategoryID", SqlDbType.Int, 4, "CategoryID");
                    da_categories.DeleteCommand = deleteCommand;

                    rowToDelete.Delete();
                    da_categories.Update(categories); 
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
