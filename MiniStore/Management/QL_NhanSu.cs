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

namespace MiniStore.Management
{
    public partial class QL_NhanSu : Form
    {
        DBConnect db;
        SqlDataAdapter da_employees;
        DataTable employees;
        public QL_NhanSu()
        {
            InitializeComponent();
            db = new DBConnect("miniMKT");
        }

        private void QL_NhanSu_Load(object sender, EventArgs e)
        {
            load_NV();
            load_Position();
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
        }
        void datagrid_Load()
        {
            string sql = "select EmployeeID,EmployeeName,Position,Phone,Email from Employees";
            da_employees = db.getDataAdapter(sql, "Employees");
            employees = db.Dset.Tables["Employees"];
            dataGridView_DSNhanVien.DataSource = employees;
        }
        void load_NV()
        {
            datagrid_Load();
            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = employees.Columns["EmployeeID"];
            employees.PrimaryKey = primaryKey;
            dataGridView_DSNhanVien.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
            dataGridView_DSNhanVien.Columns["EmployeeName"].HeaderText = "Tên nhân viên";
            dataGridView_DSNhanVien.Columns["Position"].HeaderText = "Vị trí";
            dataGridView_DSNhanVien.Columns["Phone"].HeaderText = "SĐT";
            dataGridView_DSNhanVien.Columns["Email"].HeaderText = "Email";

            txtTenNV.DataBindings.Add(new Binding("Text", employees, "EmployeeName", true, DataSourceUpdateMode.Never));

            txtSDT.DataBindings.Add(new Binding("Text", employees, "Phone", true, DataSourceUpdateMode.Never));

            cb_Position.DataBindings.Add(new Binding("SelectedValue", employees, "Position", true, DataSourceUpdateMode.Never));

            txtEmail.DataBindings.Add(new Binding("Text", employees, "Email", true, DataSourceUpdateMode.Never));

            // Center the header text
            dataGridView_DSNhanVien.Columns["EmployeeID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSNhanVien.Columns["EmployeeName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSNhanVien.Columns["Position"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSNhanVien.Columns["Phone"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSNhanVien.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView_DSNhanVien.Columns["EmployeeID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_DSNhanVien.Columns["EmployeeName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_DSNhanVien.Columns["Position"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_DSNhanVien.Columns["Phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_DSNhanVien.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView_DSNhanVien.Columns["EmployeeID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_DSNhanVien.Columns["EmployeeID"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dataGridView_DSNhanVien.Columns["EmployeeName"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
        
        }
        void load_Position()
        {
            string sql = "select Position from Employees group by Position";
            cb_Position.DataSource = db.getDataTable(sql, "Position");

            cb_Position.DisplayMember = "Position";

            cb_Position.ValueMember = "Position";
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression for Vietnamese phone numbers
            string pattern = @"^(03|05|07|08|09)\d{8,9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private bool IsValidGmail(string email)
        {
            // Regular expression for Gmail addresses
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.checkExist(string.Format("select count(*) from Employees where Phone = N'{0}'", txtSDT.Text)))
            {
                MessageBox.Show("SĐT đã có nhân viên sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.checkExist(string.Format("select count(*) from Employees where Email = N'{0}'", txtEmail.Text)))
            {
                MessageBox.Show("Email đã có nhân viên sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidPhoneNumber(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ (cần đầu số 03|05|07|08|09 và cần đủ 11 hoặc 12 số)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidGmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = string.Format("INSERT INTO Employees(EmployeeName,Position,Phone,Email,EmployPassword) VALUES(N'{0}', N'{1}', '{2}','{3}','1')",
                txtTenNV.Text, cb_Position.Text, txtSDT.Text, txtEmail.Text);
            db.updateToDataBase(sql);
            datagrid_Load();
            MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTenNV.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            cb_Position.SelectedIndex = -1;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_DSNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int empId = (int)dataGridView_DSNhanVien.CurrentRow.Cells["EmployeeID"].Value;

            string text = string.Format("Bạn có muốn xóa nhân viên {0} không", dataGridView_DSNhanVien.CurrentRow.Cells["EmployeeName"].Value);
            if (MessageBox.Show(text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // Find the DataRow to delete
                DataRow rowToDelete = employees.Rows.Find(empId);
                if (rowToDelete != null)
                {
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = @EmployeeID", da_employees.SelectCommand.Connection);
                    deleteCommand.Parameters.Add("@EmployeeID", SqlDbType.Int, 4, "EmployeeID");
                    da_employees.DeleteCommand = deleteCommand;

                    rowToDelete.Delete();
                    da_employees.Update(employees);
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
            string positionInDB = db.getString(string.Format("select Position from Employees where EmployeeID = {0}", dataGridView_DSNhanVien.CurrentRow.Cells["EmployeeID"].Value.ToString()));
            string currentPos = cb_Position.Text;
            if (!positionInDB.Equals(currentPos))
            {
                MessageBox.Show("Bạn không thể thay đổi chức vụ của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.checkExist(string.Format("select count(*) from Employees where Phone = N'{0}' AND EmployeeID != {1}", txtSDT.Text, (int)dataGridView_DSNhanVien.CurrentRow.Cells["EmployeeID"].Value)))
            {
                MessageBox.Show("SĐT đã có nhân viên sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.checkExist(string.Format("select count(*) from Employees where Email = N'{0}' AND EmployeeID != {1}", txtEmail.Text, (int)dataGridView_DSNhanVien.CurrentRow.Cells["EmployeeID"].Value)))
            {
                MessageBox.Show("Email đã có nhân viên sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidPhoneNumber(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ (cần đầu số 03|05|07|08|09 và cần đủ 11 hoặc 12 số)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidGmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = string.Format("UPDATE Employees SET EmployeeName = N'{0}', Position = N'{1}', Phone = '{2}', Email = '{3}' WHERE EmployeeID = {4}",
                               txtTenNV.Text, cb_Position.Text, txtSDT.Text, txtEmail.Text, dataGridView_DSNhanVien.CurrentRow.Cells["EmployeeID"].Value);
            db.updateToDataBase(sql);
            datagrid_Load();
            MessageBox.Show("Sửa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtTimKiem.Text;
            string sql = "SELECT EmployeeID,EmployeeName,Position,Phone,Email FROM Employees WHERE EmployeeName LIKE @searchString";

            using (SqlConnection connection = new SqlConnection(db.strConnect))
            {
                SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);
                da_products.SelectCommand.Parameters.AddWithValue("@searchString", "%" + searchString + "%");

                DataTable products = new DataTable();
                da_products.Fill(products);
                dataGridView_DSNhanVien.DataSource = products;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtTenNV.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            cb_Position.SelectedIndex = -1;
        }

        private void dataGridView_DSNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_DSNhanVien.CurrentRow != null)
            {
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
            }
        }
    }
}
