using SQL;
using System;
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
        public QL_Products()
        {
            InitializeComponent();
            db = new DBConnect("miniMKT");
        }
        void LoadData()
        {
            string sql = "select * from Products";
            da_products = db.getDataAdapter(sql, "Products");
            products = db.Dset.Tables["Products"];
            dataGridView_DSMonAn.DataSource = products;

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = products.Columns["ProductID"];
            products.PrimaryKey = primaryKey;
            dataGridView_DSMonAn.Columns["ProductID"].HeaderText = "Số thứ tự";
            dataGridView_DSMonAn.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            dataGridView_DSMonAn.Columns["CategoryID"].HeaderText = "Mã loại hàng";
            dataGridView_DSMonAn.Columns["SupplierID"].HeaderText = "Mã NCC";
            dataGridView_DSMonAn.Columns["Price"].HeaderText = "Giá";
            dataGridView_DSMonAn.Columns["StockQuantity"].HeaderText = "Số lượng trong kho";
            dataGridView_DSMonAn.Columns["Unit"].HeaderText = "Đơn vị tính";

            // Center the header text
            dataGridView_DSMonAn.Columns["ProductID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSMonAn.Columns["ProductName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSMonAn.Columns["CategoryID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSMonAn.Columns["SupplierID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSMonAn.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSMonAn.Columns["StockQuantity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSMonAn.Columns["Unit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_DSMonAn.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_DSMonAn.Columns["CategoryID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_DSMonAn.Columns["SupplierID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_DSMonAn.Columns["StockQuantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView_DSMonAn.Columns["ProductID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSMonAn.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSMonAn.Columns["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSMonAn.Columns["CategoryID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSMonAn.Columns["SupplierID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSMonAn.Columns["StockQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_DSMonAn.Columns["ProductID"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dataGridView_DSMonAn.Columns["ProductName"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dataGridView_DSMonAn.Columns["Price"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dataGridView_DSMonAn.Columns["Unit"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;

        }

        private void QL_Food_Load(object sender, EventArgs e)
        {
            LoadData();
            loadNCC();
            load_LoaiHang();
            load_DVT();
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
            string sql = "select * from Products";
            da_products = db.getDataAdapter(sql, "Products");
            DataTable dt = db.Dset.Tables["Products"];
            cb_DVT.DataSource = dt;
            cb_DVT.DisplayMember = "Unit";
            cb_DVT.ValueMember = "ProductID";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtTimKiem.Text;
            string sql = "SELECT * FROM Products WHERE ProductName LIKE @searchString";

            using (SqlConnection connection = new SqlConnection(db.strConnect))
            {
                SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);
                da_products.SelectCommand.Parameters.AddWithValue("@searchString", "%" + searchString + "%");

                DataTable products = new DataTable();
                da_products.Fill(products);
                dataGridView_DSMonAn.DataSource = products;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMonAn.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã món ăn !!", "Chưa nhập mã món ăn", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtMaMonAn.Focus();
                return;
            }
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

            if (db.checkExist(string.Format("select count(*) from SupplierName where SupplierID = {0}", txtMaMonAn.Text)))
            {
                if (MessageBox.Show("Mã phiếu đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                {
                    txtMaMonAn.Focus();
                }
                return;
            }
            if (db.checkExist(string.Format("select count(*) from SupplierName where SupplierName = {0}", txtTenMonAn.Text)))
            {
                if (MessageBox.Show("Tên sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                {
                    txtMaMonAn.Focus();
                }
                return;
            }
            //           string sql = string.Format(
            //    "INSERT INTO Products(ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) " +
            //    "VALUES('{0}', N'{1}', '{2}', '{3}', {4}, {5}, '{6}')",
            //    txtMaMonAn.Text, txtTenMonAn.Text, categoryID, supplierID, price, stockQuantity, unit
            //);
            //db.updateToDataBase(sql);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
