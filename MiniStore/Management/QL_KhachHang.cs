using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace MiniStore.Management
{
    public partial class QL_KhachHang : Form
    {
        DBConnect db;
        SqlDataAdapter da_Customers;
        DataTable Customers;
        List<string> columnNames = new List<string>
                        {
                            "CustomerID",
                            "CustomerName",
                            "Phone",
                            "Email",
                            "CustomerRank",
                            "CustomerSuppAddress"
                        };
        public QL_KhachHang()
        {
            InitializeComponent();
            db = new DBConnect("CongManhPC\\MSSQLSERVER01", "miniMKT");
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


            txtb_tenkh.DataBindings.Add(new Binding("Text", Customers, "CustomerName", true, DataSourceUpdateMode.Never));

            txtb_sdt.DataBindings.Add(new Binding("Text", Customers, "Phone", true, DataSourceUpdateMode.Never));

            txtb_Email.DataBindings.Add(new Binding("Text", Customers, "Email", true, DataSourceUpdateMode.Never));

            cbb_hangkh.DataBindings.Add(new Binding("SelectedValue", Customers, "CustomerRank", true, DataSourceUpdateMode.Never));

            txtb_DiaChi.DataBindings.Add(new Binding("Text", Customers, "CustomerSuppAddress", true, DataSourceUpdateMode.Never));

            foreach (string item in columnNames)
            {
                dataGridView.Columns[item].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[item].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[item].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[item].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            }
        }
        void load_Grid()
        {
            string str = "SELECT * FROM Customers";

            dataGridView.DataSource = db.getDataTable(str, "Customers");
        }

        private void QL_KhachHang_Load(object sender, EventArgs e)
        {
            loadcomboboxhang();
            loadData();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtb_tenkh.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_tenkh.Focus();
                return;

            }
            if (string.IsNullOrEmpty(txtb_DiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_tenkh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtb_Email.Text))
            {
                MessageBox.Show("Bạn chưa nhập email khách hàng !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_Email.Focus();
                return;
            }
            if (!txtb_Email.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Email không hợp lệ !!", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            if (!IsValidPhoneNumber(txtb_sdt.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không hợp lệ !!", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            if (string.IsNullOrEmpty(txtb_sdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập sđt khách hàng !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_sdt.Focus();
                return;
            }

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
            if (db.checkExist(string.Format("select count(*) from Customers where Email = N'{0}'", txtb_Email.Text)))
            {
                if (MessageBox.Show("Email khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                {
                    txtb_Email.Focus();
                }
                return;
            }

            string query;
            if (string.IsNullOrEmpty(cbb_hangkh.Text))
            {
                query = string.Format("INSERT Customers ( CustomerName, Phone, Email , CustomerRank, CustomerSuppAddress)" +
                                " VALUES (N'{0}', '{1}', '{2}' , null, N'{3}')", txtb_tenkh.Text, txtb_sdt.Text, txtb_Email.Text, txtb_DiaChi.Text);
            }
            else
            {
                query = string.Format("INSERT Customers ( CustomerName, Phone, Email , CustomerRank, CustomerSuppAddress)" +
                               " VALUES (N'{0}', '{1}', '{2}','{3}', N'{4}')", txtb_tenkh.Text, txtb_sdt.Text,txtb_Email.Text ,cbb_hangkh.Text, txtb_DiaChi.Text);
            }
            db.updateToDataBase(query);
            txtb_DiaChi.Clear();
            txtb_tenkh.Clear();
            txtb_sdt.Clear();
            txtb_tenkh.Focus();
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            load_Grid();
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txtb_DiaChi.Clear();
            txtb_tenkh.Clear();
            txtb_sdt.Clear();
            cbb_hangkh.Text = "";
            txtb_tenkh.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int cusId = (int)dataGridView.CurrentRow.Cells["CustomerID"].Value;

            string checkSQL = "SELECT count(*) FROM Orders WHERE CustomerID = '" + cusId + "'";

            if (db.checkExist(checkSQL))
            {
                MessageBox.Show("Không Thể Xóa Khách Hàng Này !");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {


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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtb_tenkh.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_tenkh.Focus();
                return;

            }
            if (string.IsNullOrEmpty(txtb_DiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_tenkh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtb_Email.Text))
            {
                MessageBox.Show("Bạn chưa nhập email khách hàng !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_Email.Focus();
                return;
            }
            if (!IsValidPhoneNumber(txtb_sdt.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ !!", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            if (string.IsNullOrEmpty(txtb_sdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập sđt khách hàng !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtb_sdt.Focus();
                return;
            }
            string name = dataGridView.CurrentRow.Cells["CustomerName"].Value.ToString();
            if (!name.Equals(txtb_tenkh.Text))
            {
                if (db.checkExist(string.Format("select count(*) from Customers where CustomerName = N'{0}'", txtb_tenkh.Text)))
                {
                    if (MessageBox.Show("Tên khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                    {
                        txtb_tenkh.Focus();
                    }
                    return;
                }
            }
            string number = dataGridView.CurrentRow.Cells["Phone"].Value.ToString();
            if (!number.Equals(txtb_sdt.Text))
            {
                if (db.checkExist(string.Format("select count(*) from Customers where Phone = N'{0}'", txtb_sdt.Text)))
                {
                    if (MessageBox.Show("SĐT khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                    {
                        txtb_sdt.Focus();
                    }
                    return;
                }
            }
            string email = dataGridView.CurrentRow.Cells["Email"].Value.ToString();
            if (!email.Equals(txtb_Email.Text))
            {
                if (db.checkExist(string.Format("select count(*) from Customers where Email = N'{0}'", txtb_Email.Text)))
                {
                    if (MessageBox.Show("Email khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                    {
                        txtb_Email.Focus();
                    }
                    return;
                }
            }
            string update = "UPDATE Customers SET CustomerName = N'" + txtb_tenkh.Text + "'," +
                " Phone = '" + txtb_sdt.Text + "', CustomerRank = N'" + cbb_hangkh.Text + "'," +
                " CustomerSuppAddress = N'" + txtb_DiaChi.Text + "', Email = '" + txtb_Email.Text +
                "' WHERE CustomerID = " + dataGridView.CurrentRow.Cells["CustomerID"].Value;
            db.updateToDataBase(update);
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            load_Grid();
        }

        private void txtb_tenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtb_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^(03|05|07|08|09)\d{8,9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}
