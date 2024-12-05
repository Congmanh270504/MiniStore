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
    public partial class frm_Report : Form
    {
        DBConnect db;
        SqlDataAdapter da_employees;
        DataTable employees;
        List<string> columnNames = new List<string>
                        {
                            "OrderID",
                            "CustomerName",
                            "EmployeeName",
                            "OrderDate",
                            "TotalAmount",
                            "PaymentMethod"
                        };
        List<string> dateType = new List<string>
                        {
                            "Tháng",
                            "Năm"
                        };
        public frm_Report()
        {
            InitializeComponent();
            db = new DBConnect("A210PC08", "miniMKT");
        }
        void datagrid_Load()
        {
            string sql = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from Orders,Customers,Employees where Orders.CustomerID=Customers.CustomerID and Employees.EmployeeID = Orders.EmployeeID";
            da_employees = db.getDataAdapter(sql, "Orders");
            employees = db.Dset.Tables["Orders"];
            dataGridView.DataSource = employees;
        }
        void load_DateType()
        {
            foreach (var item in dateType)
            {
                cb_TimeType.Items.Add(item);
            }
            if (cb_TimeType.Items.Count > 0)
            {
                cb_TimeType.SelectedIndex = 0;
            }
        }
        private void frm_Report_Load(object sender, EventArgs e)
        {
            //lbTimeType.Text = "Ngày";
            string query = "SELECT SUM(TotalAmount) FROM Orders";
            lbTotal.Text = db.getDecimal(query).ToString() + "đ";
            datagrid_Load();
            load_DateType();
            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = employees.Columns["OrderID"];
            employees.PrimaryKey = primaryKey;
            dataGridView.Columns["OrderID"].HeaderText = "Mã hóa đơn";
            dataGridView.Columns["EmployeeName"].HeaderText = "Tên nhân viên";
            dataGridView.Columns["CustomerName"].HeaderText = "Tên khách hàng";
            dataGridView.Columns["OrderDate"].HeaderText = "Ngày lập";
            dataGridView.Columns["TotalAmount"].HeaderText = "Tổng tiền";
            dataGridView.Columns["PaymentMethod"].HeaderText = "Phương thức tính";

            foreach (string item in columnNames)
            {
                dataGridView.Columns[item].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[item].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[item].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[item].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            }
        }

        private void tbTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (cb_TimeType.Text)
            {
                case "Tháng":
                    int time = int.Parse(tbTime.Text);
                    if (time > 12)
                    {
                        if (MessageBox.Show("Không tháng nhập vào lớn hơn 12.", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Retry)
                        {
                            tbTime.Clear();
                            tbTime.Focus();
                        }
                        return;
                    }
                  string sql = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from " +
                                       "Orders, Customers, Employees where Orders.CustomerID = Customers.CustomerID " +
                                       "and Employees.EmployeeID = Orders.EmployeeID and MONTH(OrderDate) = '" + tbTime.Text + "'";
                    using (SqlConnection connection = new SqlConnection(db.strConnect))
                    {
                        SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);

                        DataTable products = new DataTable();
                        da_products.Fill(products);
                        if (products.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn nào có ngày đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbTime.Clear();
                            tbTime.Focus();
                            datagrid_Load();
                            return;
                        }
                        sql = "SELECT SUM(TotalAmount) FROM Orders where month(OrderDate)='" + tbTime.Text + "'";
                        lbTotal.Text = db.getDecimal(sql).ToString() + "đ";
                        dataGridView.DataSource = products;
                    }
                    break;
                case "Năm":
                    //int time = int.Parse(tbTime.Text);
                    //if (true)
                    //{

                    //}
                    query = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from " +
                                      "Orders, Customers, Employees where Orders.CustomerID = Customers.CustomerID " +
                                      "and Employees.EmployeeID = Orders.EmployeeID and YEAR(OrderDate) = '" + tbTime.Text + "'";
                    using (SqlConnection connection = new SqlConnection(db.strConnect))
                    {
                        SqlDataAdapter da_products = new SqlDataAdapter(query, connection);

                        DataTable products = new DataTable();
                        da_products.Fill(products);
                        if (products.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn nào có năm đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbTime.Clear();
                            tbTime.Focus();
                            datagrid_Load();
                            return;
                        }
                        sql = "SELECT SUM(TotalAmount) FROM Orders where year(OrderDate)='" + tbTime.Text + "'";
                        lbTotal.Text = db.getDecimal(sql).ToString() + "đ";
                        dataGridView.DataSource = products;
        }
                    break;
                default:
                    break;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            datagrid_Load();
            string query = "SELECT SUM(TotalAmount) FROM Orders";
            lbTotal.Text = db.getDecimal(query).ToString() + "đ";
            tbTime.Clear();
            cb_TimeType.SelectedIndex = -1;
            cb_TimeType.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
