using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.ItemNav
{
    public partial class frm_ReportDeatails : Form
    {
        DBConnect db;
        SqlDataAdapter da_revenueDetails;
        DataTable revenue;
        List<string> columnNames = new List<string>
                        {
                            "OrderDate",
                            "EmployeeName",
                            "CustomerName",
                            "ProductName",
                            "Quantity",
                            "Price",
                            "CustomerRank"
                        };


        public frm_ReportDeatails(string month, string year)
        {
            InitializeComponent();
            db = new DBConnect("miniMKT");
            lbMonthYear.Text = month + "/" + year;
            lbTotalQuantity.Text = db.getInt("SELECT SUM(OD.Quantity) AS TotalQuantity" +
                " FROM Orders O" +
                " JOIN Employees E ON O.EmployeeID = E.EmployeeID" +
                " JOIN Customers C ON O.CustomerID = C.CustomerID" +
                " JOIN OrderDetails OD ON O.OrderID = OD.OrderID" +
                " JOIN Products P ON OD.ProductID = P.ProductID" +
                " WHERE YEAR(O.OrderDate) = " + year + " AND MONTH(O.OrderDate) = " + month).ToString() + " sản phẩm đã bán";

            lbTotalRevenue.Text = db.getInt("SELECT SUM(OD.Price * OD.Quantity) AS TotalPrice" +
                " FROM Orders O" +
                " JOIN Employees E ON O.EmployeeID = E.EmployeeID" +
                " JOIN Customers C ON O.CustomerID = C.CustomerID" +
                " JOIN OrderDetails OD ON O.OrderID = OD.OrderID" +
                " JOIN Products P ON OD.ProductID = P.ProductID" +
                " WHERE YEAR(O.OrderDate) = " + year + " AND MONTH(O.OrderDate) = " + month).ToString() + "đ";

        }
        void datagrid_Load()
        {
            string[] monthYear = lbMonthYear.Text.Split('/');
            string sql = "SELECT CONVERT(VARCHAR(10), O.OrderDate, 103) AS OrderDate,E.EmployeeName AS EmployeeName,C.CustomerName AS CustomerName,P.ProductName AS ProductName,OD.Quantity AS Quantity,OD.Price AS Price,C.CustomerRank AS CustomerRank" +
                " FROM Orders O" +
                " JOIN Employees E ON O.EmployeeID = E.EmployeeID " +
                "JOIN Customers C ON O.CustomerID = C.CustomerID " +
                "JOIN OrderDetails OD ON O.OrderID = OD.OrderID" +
                " JOIN Products P ON OD.ProductID = P.ProductID" +
                " WHERE MONTH(O.OrderDate) = " + monthYear[0] + " AND YEAR(O.OrderDate) = " + monthYear[1] +
                " ORDER BY O.OrderDate;";
            da_revenueDetails = db.getDataAdapter(sql, "Orders");
            revenue = db.Dset.Tables["Orders"];
            dataGridView.DataSource = revenue;
        }
        private void frm_Report_Load(object sender, EventArgs e)
        {
            datagrid_Load();
            dataGridView.Columns["OrderDate"].HeaderText = "Ngày/tháng/năm";
            dataGridView.Columns["EmployeeName"].HeaderText = "Tên nhân viên";
            dataGridView.Columns["CustomerName"].HeaderText = "Tên khách hàng";
            dataGridView.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            dataGridView.Columns["Quantity"].HeaderText = "Số lượng";
            dataGridView.Columns["Price"].HeaderText = "Đơn giá";
            dataGridView.Columns["CustomerRank"].HeaderText = "Hạng";

            foreach (string item in columnNames)
            {
                dataGridView.Columns[item].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[item].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[item].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[item].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
