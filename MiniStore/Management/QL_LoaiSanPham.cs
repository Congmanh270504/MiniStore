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
            load_ategory();
        }
        void load_ategory()
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
        }
    }
}
