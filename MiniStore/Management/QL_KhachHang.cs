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
    public partial class QL_KhachHang : Form
    {
        DBConnect db;
        SqlDataAdapter da_Customers;
        DataTable Customers;
        public QL_KhachHang()
        {
            InitializeComponent();
            db = new DBConnect("DESKTOP-LI8OVCU\\SQLEXPRESS", "miniMKT");
        }

        private void QL_KhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        void loadcomboboxhang()
        {
            string str = "SELECT CustomerRank FROM Customers Group by CustomerRank";

            cbb_hangkh.DataSource = db.getDataTable(str, "CustomerRanks");

            cbb_hangkh.DisplayMember = "CustomerRank";

            cbb_hangkh.ValueMember = "CustomerRank";
        }

        void loadData()
        {
            string str = "SELECT * FROM Customers";

            da_Customers = db.getDataAdapter(str, "Customers");

            Customers = db.Dset.Tables["Customers"];

            DataColumn[] primaryKey = new DataColumn[1];

            primaryKey[0] = Customers.Columns["CustomerID"];

            Customers.PrimaryKey = primaryKey;

            dataGridView.DataSource = Customers;

            dataGridView.Columns["CustomerID"].HeaderText = "Mã KH";

            dataGridView.Columns["CustomerName"].HeaderText = "Họ Tên";

            dataGridView.Columns["Phone"].HeaderText = "Số Điện Thoại";

            dataGridView.Columns["Email"].HeaderText = "Email";

            dataGridView.Columns["CustomerRank"].HeaderText = "Hạng";

            dataGridView.Columns["CustomerSuppAddress"].HeaderText = "Địa Chỉ";

            txtb_makh.DataBindings.Add(new Binding("Text", Customers, "CustomerID", true, DataSourceUpdateMode.Never));

            txtb_tenkh.DataBindings.Add(new Binding("Text", Customers, "CustomerName", true, DataSourceUpdateMode.Never));

            txtb_sdt.DataBindings.Add(new Binding("Text", Customers, "Phone", true, DataSourceUpdateMode.Never));

            cbb_hangkh.DataBindings.Add(new Binding("SelectedValue", Customers, "CustomerRank", true, DataSourceUpdateMode.Never));
        }

        private void QL_KhachHang_Load(object sender, EventArgs e)
        {
            loadData();
            loadcomboboxhang();
            txtb_makh.Enabled = false;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txtb_makh.Clear();
            txtb_tenkh.Clear();
            txtb_sdt.Clear();
            txtb_tenkh.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txtb_tenkh.Clear();
            txtb_sdt.Clear();
            txtb_tenkh.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string checkSQL = "SELECT count(*) FROM Orders WHERE CustomerID = '" + txtb_makh.Text + "'";

            if (db.checkExist(checkSQL))
            {
                MessageBox.Show("Không Thể Xóa Khách Hàng Này !");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                int cusId = (int)dataGridView.CurrentRow.Cells["CustomerID"].Value;

                // Find the DataRow to delete
                DataRow rowToDelete = Customers.Rows.Find(cusId);
                if (rowToDelete != null)
                {
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM Customers WHERE CustomerID = @CustomerID", da_Customers.SelectCommand.Connection);
                    deleteCommand.Parameters.Add("@CustomerID", SqlDbType.Int, 4, "CustomerID");
                    da_Customers.DeleteCommand = deleteCommand;

                    rowToDelete.Delete();
                    da_Customers.Update(Customers);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtb_makh.Text))
            //{
            //    MessageBox.Show("Bạn chưa nhập mã khách hàng !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //    txtb_makh.Focus();
            //    return;

            //}

            if (string.IsNullOrEmpty(txtb_tenkh.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_tenkh.Focus();
                return;

            }

            if (string.IsNullOrEmpty(txtb_sdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập sđt khách hàng !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_sdt.Focus();
                return;

            }

            //if (db.checkExist(string.Format("select count(*) from Customers where CustomerID = N'{0}'", txtb_makh.Text)))
            //{
            //    if (MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
            //    {
            //        txtb_makh.Focus();
            //    }
            //    return;
            //}

            if (db.checkExist(string.Format("select count(*) from Customers where CustomerName = N'{0}'", txtb_tenkh.Text)))
            {
                if (MessageBox.Show("Tên khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                {
                    txtb_tenkh.Focus();
                }
                return;
            }

            if (db.checkExist(string.Format("select count(*) from Customers where Phone = N'{0}'", txtb_sdt.Text)))
            {
                if (MessageBox.Show("SĐT khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                {
                    txtb_sdt.Focus();
                }
                return;
            }

            string hoten = txtb_tenkh.Text;
            string sdt = txtb_sdt.Text;
            string hang = cbb_hangkh.SelectedValue.ToString();

            // THÊM.
            //if (string.IsNullOrWhiteSpace(txtb_makh.Text))
            //{
            //    DataRow insert = db.Dset.Tables["Customers"].NewRow();

            //    insert["CustomerName"] = hoten;

            //    insert["Phone"] = sdt;

            //    insert["CustomerRank"] = hang;

            //    db.Dset.Tables["Customers"].Rows.Add(insert);
            //}

            // SỬA.
            else
            {
                DataRow update = db.Dset.Tables["Customers"].Rows.Find(txtb_makh.Text);

                if (update == null)
                {
                    MessageBox.Show("Lưu không thành công", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                update["CustomerName"] = hoten;
                update["Phone"] = sdt;
                update["CustomerRank"] = hang;
            }

            // Update the database
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da_Customers);
            da_Customers.Update(db.Dset, "Customers");
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
