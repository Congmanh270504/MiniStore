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
using SQL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using MiniStore.ItemNav;
namespace MiniStore.Management
{
    public partial class QL_DSHoaDon : Form
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
                            "Ngày",
                            "Tháng",
                            "Năm",
                            "Tất cả"
                        };
        public QL_DSHoaDon()
        {
            InitializeComponent();
            db = new DBConnect("miniMKT");
        }
        void datagrid_Load()
        {
            string sql = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from Orders,Customers,Employees where Orders.CustomerID=Customers.CustomerID and Employees.EmployeeID = Orders.EmployeeID";
            da_employees = db.getDataAdapter(sql, "Orders");
            employees = db.Dset.Tables["Orders"];
            dataGridView.DataSource = employees;
        }
        private void QL_DSHoaDon_Load(object sender, EventArgs e)
        {
            datagrid_Load();
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
            load_Type();
            load_DateType();
            load_cbPayment();
        }

        void load_Type()
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                cbCell.Items.Add(column.HeaderText);
            }
            if (cbCell.Items.Count > 0)
            {
                cbCell.SelectedIndex = 0;
            }
        }
        void load_DateType()
        {
            foreach (var item in dateType)
            {
                cbDate.Items.Add(item);
            }
            if (cbDate.Items.Count > 0)
            {
                cbDate.SelectedIndex = 0;
            }
        }
        void load_cbPayment()
        {
            string sql = "select PaymentMethod from Orders group by PaymentMethod";
            cbPayment.DataSource = db.getDataTable(sql, "PaymentMethod");

            cbPayment.DisplayMember = "PaymentMethod";

            cbPayment.ValueMember = "PaymentMethod";
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (cbCell.Text.Equals("Mã hóa đơn") || cbCell.Text.Equals("Tên khách hàng") || cbCell.Text.Equals("Tên nhân viên"))
            {
                if (string.IsNullOrEmpty(txtSearch.Text) || txtSearch.Text.Equals("Chỉ nhập số"))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            switch (cbCell.Text)
            {
                case "Mã hóa đơn":
                    {
                        string sql = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from " +
                                      "Orders, Customers, Employees where Orders.CustomerID = Customers.CustomerID " +
                                      "and Employees.EmployeeID = Orders.EmployeeID and OrderID = " + txtSearch.Text;

                        using (SqlConnection connection = new SqlConnection(db.strConnect))
                        {
                            SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);

                            DataTable products = new DataTable();
                            da_products.Fill(products);
                            if (products.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy hóa đơn nào có mã đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtSearch.Clear();
                                txtSearch.Focus();
                                datagrid_Load();
                                return;
                            }
                            dataGridView.DataSource = products;
                        }
                        break;
                    }
                case "Tên khách hàng":
                    {
                        string sql = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from " +
                                      "Orders, Customers, Employees where Orders.CustomerID = Customers.CustomerID " +
                                      "and Employees.EmployeeID = Orders.EmployeeID and CustomerName LIKE @CustomerName";

                        using (SqlConnection connection = new SqlConnection(db.strConnect))
                        {
                            SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);
                            da_products.SelectCommand.Parameters.AddWithValue("@CustomerName", "%" + txtSearch.Text + "%");
                            DataTable products = new DataTable();
                            da_products.Fill(products);
                            if (products.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy hóa đơn nào có tên khách hàng đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtSearch.Clear();
                                txtSearch.Focus();
                                datagrid_Load();
                                return;
                            }
                            dataGridView.DataSource = products;
                        }
                        break;
                    }
                case "Tên nhân viên":
                    {
                        string sql = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from " +
                                        "Orders, Customers, Employees where Orders.CustomerID = Customers.CustomerID " +
                                        "and Employees.EmployeeID = Orders.EmployeeID and EmployeeName LIKE @EmployeeName";

                        using (SqlConnection connection = new SqlConnection(db.strConnect))
                        {
                            SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);
                            da_products.SelectCommand.Parameters.AddWithValue("@EmployeeName", "%" + txtSearch.Text + "%");
                            DataTable products = new DataTable();
                            da_products.Fill(products);
                            if (products.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy hóa đơn nào có tên nhân viên đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtSearch.Clear();
                                txtSearch.Focus();
                                datagrid_Load();
                                return;
                            }
                            dataGridView.DataSource = products;
                        }
                        break;
                    }
                case "Ngày lập":
                    {
                        switch (cbDate.Text)
                        {
                            case "Ngày":
                                {
                                    string query = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from " +
                                        "Orders, Customers, Employees where Orders.CustomerID = Customers.CustomerID " +
                                        "and Employees.EmployeeID = Orders.EmployeeID and DAY(OrderDate) = '" + tbDate.Text + "'";
                                    using (SqlConnection connection = new SqlConnection(db.strConnect))
                                    {
                                        SqlDataAdapter da_products = new SqlDataAdapter(query, connection);

                                        DataTable products = new DataTable();
                                        da_products.Fill(products);
                                        if (products.Rows.Count == 0)
                                        {
                                            MessageBox.Show("Không tìm thấy hóa đơn nào có ngày đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            tbDate.Clear();
                                            tbDate.Focus();
                                            datagrid_Load();
                                            return;
                                        }
                                        dataGridView.DataSource = products;
                                    }
                                    break;
                                }
                            case "Tháng":
                                {
                                    string query = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from " +
                                        "Orders, Customers, Employees where Orders.CustomerID = Customers.CustomerID " +
                                        "and Employees.EmployeeID = Orders.EmployeeID and MONTH(OrderDate) = '" + tbDate.Text + "'";
                                    using (SqlConnection connection = new SqlConnection(db.strConnect))
                                    {
                                        SqlDataAdapter da_products = new SqlDataAdapter(query, connection);

                                        DataTable products = new DataTable();
                                        da_products.Fill(products);
                                        if (products.Rows.Count == 0)
                                        {
                                            MessageBox.Show("Không tìm thấy hóa đơn nào có tháng đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            tbDate.Clear();
                                            tbDate.Focus();
                                            datagrid_Load();
                                            return;
                                        }
                                        dataGridView.DataSource = products;
                                    }
                                    break;
                                }
                            case "Năm":
                                {
                                    string query = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from " +
                                        "Orders, Customers, Employees where Orders.CustomerID = Customers.CustomerID " +
                                        "and Employees.EmployeeID = Orders.EmployeeID and YEAR(OrderDate) = '" + tbDate.Text + "'";
                                    using (SqlConnection connection = new SqlConnection(db.strConnect))
                                    {
                                        SqlDataAdapter da_products = new SqlDataAdapter(query, connection);

                                        DataTable products = new DataTable();
                                        da_products.Fill(products);
                                        if (products.Rows.Count == 0)
                                        {
                                            MessageBox.Show("Không tìm thấy hóa đơn nào có năm đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            tbDate.Clear();
                                            tbDate.Focus();
                                            datagrid_Load();
                                            return;
                                        }
                                        dataGridView.DataSource = products;
                                    }
                                    break;
                                }
                            default:
                                string defaultSQL;
                                DateTime enteredDate;
                                if (DateTime.TryParseExact(maskDateTime.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out enteredDate))
                                {
                                    string formattedDate = enteredDate.ToString("yyyy-MM-dd");
                                    defaultSQL = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from " +
                                        "Orders, Customers, Employees where Orders.CustomerID = Customers.CustomerID " +
                                        "and Employees.EmployeeID = Orders.EmployeeID and CONVERT(date, OrderDate) = @OrderDate";
                                    using (SqlConnection conn = new SqlConnection(db.strConnect))
                                    {
                                        using (SqlCommand cmd = new SqlCommand(defaultSQL, conn))
                                        {
                                            cmd.Parameters.AddWithValue("@OrderDate", formattedDate);
                                            da_employees = new SqlDataAdapter(cmd);
                                            employees = new DataTable();
                                            da_employees.Fill(employees);
                                            if (employees.Rows.Count == 0)
                                            {
                                                MessageBox.Show("Không tìm thấy hóa đơn nào có ngày/tháng/năm đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                tbDate.Clear();
                                                tbDate.Focus();
                                                datagrid_Load();
                                                return;
                                            }
                                            dataGridView.DataSource = employees;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Không đúng chuẩn thời gian. Vui lòng nhập lại thời gian theo dạng dd/MM/yyyy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    maskDateTime.Focus();
                                }
                                break;
                        }
                        break;
                    }
                case "Tổng tiền":
                    {
                        string sql = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from " +
                                        "Orders, Customers, Employees where Orders.CustomerID = Customers.CustomerID " +
                                        "and Employees.EmployeeID = Orders.EmployeeID and TotalAmount = " + txtSearch.Text;
                        using (SqlConnection connection = new SqlConnection(db.strConnect))
                        {
                            SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);
                            DataTable products = new DataTable();
                            da_products.Fill(products);

                            if (products.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy hóa đơn nào có tổng tiền đã nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtSearch.Clear();
                                txtSearch.Focus();
                                datagrid_Load();
                                return;
                            }
                            dataGridView.DataSource = products;
                        }
                        break;
                    }
                case "Phương thức tính":
                    {
                        string sql = "select OrderID,CustomerName,EmployeeName,OrderDate,TotalAmount,PaymentMethod from " +
                            "Orders, Customers, Employees where Orders.CustomerID = Customers.CustomerID " +
                            "and Employees.EmployeeID = Orders.EmployeeID and PaymentMethod = N'" + cbPayment.Text + "'";
                        using (SqlConnection connection = new SqlConnection(db.strConnect))
                        {
                            SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);
                            DataTable products = new DataTable();
                            da_products.Fill(products);
                            if (products.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy hóa đơn nào có phương tính là " + cbPayment.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cbPayment.Focus();
                                datagrid_Load();
                                return;
                            }
                            dataGridView.DataSource = products;
                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Chọn cột cần tìm kiếm");
                        return;
                    }
            }
        }
        private void cbCell_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbCell.Text.Equals("Tên nhân viên") || cbCell.Text.Equals("Tên khách hàng"))
            {
                txtSearch.Text = "Chỉ nhập chữ";
                txtSearch.ForeColor = Color.Gray;
            }
            if (cbCell.Text.Equals("Mã hóa đơn") || cbCell.Text.Equals("Tổng tiền"))
            {
                txtSearch.Text = "Chỉ nhập số";
                txtSearch.ForeColor = Color.Gray;
            }

            switch (cbCell.Text)
            {
                case "Ngày lập":
                    {
                        if (cbDate.Text.Equals("Tất cả"))
                        {
                            maskDateTime.Visible = true;
                            tbDate.Visible = false;
                        }
                        else
                        {
                            maskDateTime.Visible = false;
                            tbDate.Visible = true;
                        }

                        lbDateTime.Visible = true;
                        cbDate.Visible = true;
                        lbTime.Visible = true;
                        cbPayment.Visible = false;
                        break;
                    }
                case "Phương thức tính":
                    {
                        lbPhuongThuctinh.Visible = true;
                        cbPayment.Visible = true;

                        tbDate.Visible = false;
                        maskDateTime.Visible = false;
                        lbTime.Visible = false;
                        lbDateTime.Visible = false;
                        cbDate.Visible = false;
                        maskDateTime.Visible = false;

                        lbNhap.Visible = false;
                        txtSearch.Visible = false;
                        break;
                    }
                default:
                    lbDateTime.Visible = false;
                    cbDate.Visible = false;
                    lbTime.Visible = false;
                    tbDate.Visible = false;

                    lbPhuongThuctinh.Visible = false;
                    cbPayment.Visible = false;

                    lbNhap.Visible = true;
                    txtSearch.Visible = true;
                    maskDateTime.Visible = false;
                    break;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbCell.Text.Equals("Tên nhân viên") || cbCell.Text.Equals("Tên khách hàng"))
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (cbCell.Text.Equals("Tổng tiền") || cbCell.Text.Equals("Mã hóa đơn"))
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (cbCell.Text.Equals("Tổng tiền") || cbCell.Text.Equals("Mã hóa đơn"))
            {
                if (txtSearch.Text.Equals("Chỉ nhập số"))
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            }
            if (cbCell.Text.Equals("Tên nhân viên") || cbCell.Text.Equals("Tên khách hàng"))
            {
                if (txtSearch.Text.Equals("Chỉ nhập chữ"))
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (cbCell.Text.Equals("Tổng tiền") || cbCell.Text.Equals("Mã hóa đơn"))
            {
                if (txtSearch.Text.Equals(""))
                {
                    txtSearch.Text = "Chỉ nhập số";
                    txtSearch.ForeColor = Color.Gray;
                }
            }

            if (cbCell.Text.Equals("Tên nhân viên") || cbCell.Text.Equals("Tên khách hàng"))
            {
                if (txtSearch.Text.Equals(""))
                {
                    txtSearch.Text = "Chỉ nhập chữ";
                    txtSearch.ForeColor = Color.Gray;
                }
            }
        }

        private void tbDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbDate.Visible == true)
            {
                if (cbDate.Text.Equals("Tất cả"))
                {
                    maskDateTime.Visible = true;
                    tbDate.Visible = false;
                }
                else
                {
                    maskDateTime.Visible = false;
                    tbDate.Visible = true;
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            datagrid_Load();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells["OrderId"].Value != null && !string.IsNullOrEmpty(dataGridView.CurrentRow.Cells["OrderId"].Value.ToString()))
            {
                // Lấy thông tin từ dòng được chọn
                string orderId = dataGridView.CurrentRow.Cells["OrderId"].Value.ToString();
                // Tạo và hiển thị form OrderDetails
                var orderDetailsForm = new OrderDetails(orderId);
                Hide();
                orderDetailsForm.Show();
                orderDetailsForm.FormClosed += OrderDetailsForm_FormClosed;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void OrderDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
