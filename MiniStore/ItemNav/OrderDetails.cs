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

namespace MiniStore.ItemNav
{
    public partial class OrderDetails : Form
    {
        DBConnect db;
        SqlDataAdapter da_orderDetails;
        DataTable orderDetails;
        string orderID;

        public string OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }


        public OrderDetails(string orderID)
        {
            InitializeComponent();
            db = new DBConnect("CongManhPC\\MSSQLSERVER01", "miniMKT");
            OrderID = orderID;
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            load_Data();
        }
        void load_Data()
        {
            string sql = string.Format("select ProductName,Quantity,OrderDetails.Price from OrderDetails,Products where OrderID = {0} and Products.ProductID=OrderDetails.ProductID", OrderID);
            da_orderDetails = db.getDataAdapter(sql, "OrderDetails");
            orderDetails = db.Dset.Tables["OrderDetails"];
            dataGridView.DataSource = orderDetails;

            dataGridView.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            dataGridView.Columns["Quantity"].HeaderText = "Số lượng";
            dataGridView.Columns["Price"].HeaderText = "Giá tiền";

            dataGridView.Columns["ProductName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Quantity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


        }
    }
}
