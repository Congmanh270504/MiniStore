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
                            "CustomerID",
                            "EmployeeID",
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
            string sql = "select * from Orders";
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
            dataGridView.Columns["CustomerID"].HeaderText = "Mã khách hàng";
            dataGridView.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
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
            if (cbCell.Text.Equals("Mã hóa đơn") || cbCell.Text.Equals("Mã khách hàng") || cbCell.Text.Equals("Mã nhân viên"))
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
                        string sql = "SELECT * FROM Orders where OrderID = " + txtSearch.Text;

                        using (SqlConnection connection = new SqlConnection(db.strConnect))
                        {
                            SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);

                            DataTable products = new DataTable();
                            da_products.Fill(products);
                            dataGridView.DataSource = products;
                        }
                        break;
                    }
                case "Mã khách hàng":
                    {
                        string sql = "select * from Orders where CustomerID = " + txtSearch.Text;
                        using (SqlConnection connection = new SqlConnection(db.strConnect))
                        {
                            SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);

                            DataTable products = new DataTable();
                            da_products.Fill(products);
                            dataGridView.DataSource = products;
                        }
                        break;
                    }
                case "Mã nhân viên":
                    {
                        string sql = "select * from Orders where EmployeeID = " + txtSearch.Text;
                        using (SqlConnection connection = new SqlConnection(db.strConnect))
                        {
                            SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);

                            DataTable products = new DataTable();
                            da_products.Fill(products);
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
                                    string query = "select * from Orders where DAY(OrderDate) = '" + tbDate.Text + "'";
                                    using (SqlConnection connection = new SqlConnection(db.strConnect))
                                    {
                                        SqlDataAdapter da_products = new SqlDataAdapter(query, connection);

                                        DataTable products = new DataTable();
                                        da_products.Fill(products);
                                        dataGridView.DataSource = products;
                                    }

                                    break;
                                }
                            case "Tháng":
                                {
                                    string query = "select * from Orders where MONTH(OrderDate) = '" + tbDate.Text + "'";
                                    using (SqlConnection connection = new SqlConnection(db.strConnect))
                                    {
                                        SqlDataAdapter da_products = new SqlDataAdapter(query, connection);

                                        DataTable products = new DataTable();
                                        da_products.Fill(products);
                                        dataGridView.DataSource = products;
                                    }
                                    break;
                                }
                            case "Năm":
                                {
                                    string query = "select * from Orders where YEAR(OrderDate) = '" + tbDate.Text + "'";
                                    using (SqlConnection connection = new SqlConnection(db.strConnect))
                                    {
                                        SqlDataAdapter da_products = new SqlDataAdapter(query, connection);

                                        DataTable products = new DataTable();
                                        da_products.Fill(products);
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
                                    defaultSQL = "select * from Orders where CONVERT(date, OrderDate) = @OrderDate";
                                    using (SqlConnection conn = new SqlConnection(db.strConnect))
                                    {
                                        using (SqlCommand cmd = new SqlCommand(defaultSQL, conn))
                                        {
                                            cmd.Parameters.AddWithValue("@OrderDate", formattedDate);
                                            da_employees = new SqlDataAdapter(cmd);
                                            employees = new DataTable();
                                            da_employees.Fill(employees);
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
                        string sql = "select * from Orders where TotalAmount = " + txtSearch.Text;
                        using (SqlConnection connection = new SqlConnection(db.strConnect))
                        {
                            SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);

                            DataTable products = new DataTable();
                            da_products.Fill(products);
                            dataGridView.DataSource = products;
                        }
                        break;
                    }
                case "Phương thức tính":
                    {
                        switch (cbPayment.Text)
                        {
                            case "Tiền mặt":
                                {
                                    string sql = "select * from Orders where PaymentMethod = N'Tiền mặt'";
                                    using (SqlConnection connection = new SqlConnection(db.strConnect))
                                    {
                                        SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);

                                        DataTable products = new DataTable();
                                        da_products.Fill(products);
                                        dataGridView.DataSource = products;
                                    }
                                    break;
                                }
                            case "Chuyển khoản":
                                {
                                    string sql = "select * from Orders where PaymentMethod = N'Chuyển khoản'";
                                    using (SqlConnection connection = new SqlConnection(db.strConnect))
                                    {
                                        SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);

                                        DataTable products = new DataTable();
                                        da_products.Fill(products);
                                        dataGridView.DataSource = products;
                                    }
                                    break;
                                }
                            case "Thẻ":
                                {
                                    string sql = "select * from Orders where PaymentMethod = N'Thẻ'";
                                    using (SqlConnection connection = new SqlConnection(db.strConnect))
                                    {
                                        SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);

                                        DataTable products = new DataTable();
                                        da_products.Fill(products);
                                        dataGridView.DataSource = products;
                                    }
                                    break;
                                }
                            default:
                                break;
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
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Chỉ nhập số"))
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                txtSearch.Text = "Chỉ nhập số";
                txtSearch.ForeColor = Color.Gray;
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
    }
}
