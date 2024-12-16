using MiniStore.Forms;
using SQL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.Management
{
    public partial class QL_Products : Form
    {
        DBConnect db;
        SqlDataAdapter da_products;
        DataTable products;
        List<string> columnNames = new List<string>
                        {
                            "ProductID",
                            "ProductName",
                            "CategoryID",
                            "SupplierID",
                            "Price",
                            "StockQuantity",
                            "Unit",
                            "CategoryName",
                            "SupplierName"
                        };
        public QL_Products()
        {
            InitializeComponent();
            db = new DBConnect("miniMKT");
        }
        void LoadData()
        {
            string query = @"
        SELECT Products.*, 
               CategoryName, 
               SupplierName, 
               Products.CategoryID AS ProdCategoryID, 
               Products.SupplierID AS ProdSupplierID
        FROM Products
        JOIN Categories ON Products.CategoryID = Categories.CategoryID
        JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID";

            using (SqlConnection conn = new SqlConnection(db.strConnect))
            {
                da_products = new SqlDataAdapter(query, conn);
                products = new DataTable();
                da_products.Fill(products);
                dataGridView_DSMonAn.DataSource = products;
                DataColumn[] primaryKey = new DataColumn[1];
                primaryKey[0] = products.Columns["ProductID"];
                products.PrimaryKey = primaryKey;
                dataGridView_DSMonAn.Columns["ProductID"].HeaderText = "Mã sản phẩm";
                dataGridView_DSMonAn.Columns["ProductName"].HeaderText = "Tên sản phẩm";
                // Hide the aliased CategoryID and SupplierID columns
                dataGridView_DSMonAn.Columns["CategoryID"].Visible = false;
                dataGridView_DSMonAn.Columns["SupplierID"].Visible = false;
                dataGridView_DSMonAn.Columns["Price"].HeaderText = "Giá";
                dataGridView_DSMonAn.Columns["StockQuantity"].HeaderText = "Số lượng trong kho";
                dataGridView_DSMonAn.Columns["Unit"].HeaderText = "Đơn vị tính";
                dataGridView_DSMonAn.Columns["CategoryName"].HeaderText = "Tên loại hàng";
                dataGridView_DSMonAn.Columns["SupplierName"].HeaderText = "Tên NCC";

                // Hide the aliased CategoryID and SupplierID columns
                dataGridView_DSMonAn.Columns["CategoryID"].Visible = false;
                dataGridView_DSMonAn.Columns["SupplierID"].Visible = false;
                dataGridView_DSMonAn.Columns["ProdCategoryID"].Visible = false;
                dataGridView_DSMonAn.Columns["ProdSupplierID"].Visible = false;
            }

            foreach (var item in columnNames)
            {
                dataGridView_DSMonAn.Columns[item].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView_DSMonAn.Columns[item].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView_DSMonAn.Columns[item].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView_DSMonAn.Columns[item].HeaderCell.Style.WrapMode = DataGridViewTriState.False;

            }
            AddBindings();
        }
        private void AddBindings()
        {
            txtTenMonAn.DataBindings.Add(new Binding("Text", dataGridView_DSMonAn.DataSource, "ProductName", true, DataSourceUpdateMode.Never));
            cb_LoaiHang.DataBindings.Add(new Binding("SelectedValue", dataGridView_DSMonAn.DataSource, "ProdCategoryID", true, DataSourceUpdateMode.Never));
            cmbNhaCungCap.DataBindings.Add(new Binding("SelectedValue", dataGridView_DSMonAn.DataSource, "ProdSupplierID", true, DataSourceUpdateMode.Never));
            txtGiaTien.DataBindings.Add(new Binding("Text", dataGridView_DSMonAn.DataSource, "Price", true, DataSourceUpdateMode.Never));
            txtSoLuong.DataBindings.Add(new Binding("Text", dataGridView_DSMonAn.DataSource, "StockQuantity", true, DataSourceUpdateMode.Never));
            cb_DVT.DataBindings.Add(new Binding("SelectedValue", dataGridView_DSMonAn.DataSource, "Unit", true, DataSourceUpdateMode.Never));
        }

        private void QL_Food_Load(object sender, EventArgs e)
        {
            LoadData();
            loadNCC();
            load_LoaiHang();
            load_DVT();
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
            //addBinding();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Close();
        }
        void loadNCC()
        {
            string sql = "select * from Suppliers";
            da_products = db.getDataAdapter(sql, "Suppliers");
            DataTable dt = db.Dset.Tables["Suppliers"];
            cmbNhaCungCap.DataSource = dt;
            cmbNhaCungCap.DisplayMember = "SupplierName";
            cmbNhaCungCap.ValueMember = "SupplierID";
        }
        void load_LoaiHang()
        {
            string sql = "select * from Categories";
            da_products = db.getDataAdapter(sql, "Categories");
            DataTable dt = db.Dset.Tables["Categories"];
            cb_LoaiHang.DataSource = dt;
            cb_LoaiHang.DisplayMember = "CategoryName";
            cb_LoaiHang.ValueMember = "CategoryID";
        }
        void load_DVT()
        {
            string sql = "select Unit from Products group by Unit ";
            cb_DVT.DataSource = db.getDataTable(sql, "Unit");
            cb_DVT.DisplayMember = "Unit";
            cb_DVT.ValueMember = "Unit";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtTimKiem.Text;

            string sql = "SELECT ProductID, ProductName, Price, StockQuantity, Unit, CategoryName, SupplierName, Products.CategoryID AS ProdCategoryID, Products.SupplierID AS ProdSupplierID " +
                         "FROM Products " +
                         "JOIN Categories ON Products.CategoryID = Categories.CategoryID " +
                         "JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID " +
                         "WHERE ProductName LIKE @searchString";

            using (SqlConnection connection = new SqlConnection(db.strConnect))
            {
                SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);
                da_products.SelectCommand.Parameters.AddWithValue("@searchString", "%" + searchString + "%");

                DataTable searchResults = new DataTable();
                da_products.Fill(searchResults);
                dataGridView_DSMonAn.DataSource = searchResults;
            }

            ClearBindings();
            AddBindings();
        }
        private void ClearBindings()
        {
            txtTenMonAn.DataBindings.Clear();
            cb_LoaiHang.DataBindings.Clear();
            cmbNhaCungCap.DataBindings.Clear();
            txtGiaTien.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            cb_DVT.DataBindings.Clear();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTenMonAn.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn !!", "Chưa nhập tên món ăn", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtTenMonAn.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtGiaTien.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá món ăn !!", "Chưa nhập giá món ăn", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtGiaTien.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng món ăn !!", "Chưa nhập số lượng món ăn", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtSoLuong.Focus();
                return;
            }

            if (db.checkExist(string.Format("select count(*) from Products where ProductName = N'{0}'", txtTenMonAn.Text)))
            {
                if (MessageBox.Show("Tên sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                {
                    txtTenMonAn.Focus();
                }
                return;
            }
            string sql = string.Format(
            "INSERT INTO Products( ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) " +
            "VALUES( N'{0}', '{1}', '{2}', {3}, {4}, N'{5}')",
            txtTenMonAn.Text,
            cb_LoaiHang.SelectedValue,
            cmbNhaCungCap.SelectedValue,
            txtGiaTien.Text,
            txtSoLuong.Text,
            cb_DVT.SelectedValue);
            db.updateToDataBase(sql);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            ClearBindings();
            LoadData();
        }

        private void txtMaMonAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_DSMonAn.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int productId = (int)dataGridView_DSMonAn.CurrentRow.Cells["ProductID"].Value;

                string query = string.Format("DELETE FROM Products WHERE ProductID = {0}", productId);
                db.updateToDataBase(query);
                ClearBindings();
                LoadData();
                da_products.Update(products);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            txtTenMonAn.Clear();
            txtGiaTien.Clear();
            txtSoLuong.Clear();
            txtTimKiem.Clear();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dataGridView_DSMonAn.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<string> list = new List<string>();

            DataGridViewRow selectedRow = dataGridView_DSMonAn.CurrentRow;

            // Extract the values from the selected row
            string maSanPham = selectedRow.Cells["ProductID"].Value.ToString();
            list.Add(maSanPham);
            string tenSanPham = selectedRow.Cells["ProductName"].Value.ToString();
            list.Add(tenSanPham);
            string loaiSP = selectedRow.Cells["ProdCategoryID"].Value.ToString();
            list.Add(loaiSP);
            string nhaCungCap = selectedRow.Cells["ProdSupplierID"].Value.ToString();
            list.Add(nhaCungCap);
            string gia = selectedRow.Cells["Price"].Value.ToString();
            list.Add(gia);
            string soLuongTrongKho = selectedRow.Cells["StockQuantity"].Value.ToString();
            list.Add(soLuongTrongKho);
            string donViTinh = selectedRow.Cells["Unit"].Value.ToString();
            list.Add(donViTinh);

            List<string> input = new List<string>();
            input.Add(maSanPham);
            input.Add(txtTenMonAn.Text);
            input.Add(cb_LoaiHang.SelectedValue.ToString());
            input.Add(cmbNhaCungCap.SelectedValue.ToString());
            input.Add(txtGiaTien.Text);
            input.Add(txtSoLuong.Text);
            input.Add(cb_DVT.SelectedValue.ToString());
            if (list.SequenceEqual(input))
            {
                if (MessageBox.Show("Không có gì thay đổi !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) != DialogResult.OK)
                {
                    txtTenMonAn.Focus();
                }
                return;
            }

            if (!list[1].Equals(input[1]))
            {
                if (db.checkExist(string.Format("select count(*) from Products where ProductName= N'{0}'", txtTenMonAn.Text)))
                {
                    if (MessageBox.Show("Tên sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                    {
                        txtTenMonAn.Focus();
                    }
                    return;
                }
            }
            List<int> indexChange = new List<int>();
            for (int i = 1; i < list.Count; i++)
            {
                if (!list[i].Equals(input[i]))
                {
                    indexChange.Add(i);
                }
            }
            List<string> subQuery = new List<string>();
            for (int i = 0; i < indexChange.Count; i++)
            {
                subQuery.Add(string.Format("{0} = N'{1}'", columnNames[indexChange[i]], input[indexChange[i]]));
            }

            for (int i = 0; i < input.Count; i++)
            {
                if (!string.IsNullOrEmpty(input[i]))
                {
                    list[i] = input[i];
                }
            }

            string query = "UPDATE Products SET ";
            query += string.Join(", ", subQuery) + string.Format(" WHERE ProductID = {0}", maSanPham);
            db.updateToDataBase(query);
            ClearBindings();
            LoadData();
            da_products.Update(products);

            MessageBox.Show("Sửa  thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        private void dataGridView_DSMonAn_SelectionChanged(object sender, EventArgs e)
        {
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
        }
    }
}
