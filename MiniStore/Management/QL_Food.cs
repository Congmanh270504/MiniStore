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
    public partial class QL_Food : Form
    {
        DBConnect db;
        SqlDataAdapter da_products;
        DataTable products;
        public QL_Food()
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
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
