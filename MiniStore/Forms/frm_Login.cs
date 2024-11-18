using SQL;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace MiniStore.Forms
{
    public partial class frm_Login : Form
    {
        private static frm_Login instance;
        private DBConnect db;
        public static User LoggedInUser { get; private set; }

        private frm_Login()
        {
            InitializeComponent();
            db = new DBConnect("CongManhPC\\MSSQLSERVER01", "miniMKT");
        }

        public static frm_Login GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frm_Login();
            }
            return instance;
        }
        public void ResetFields()
        {
            txtb_username.Text = LoggedInUser.Email;
            txtb_password.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtb_username.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản !!", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            if (string.IsNullOrEmpty(txtb_password.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !!", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            string query = "SELECT COUNT(*) FROM Employees WHERE Email = @Email AND EmployPassword = @Password";
            using (SqlConnection connection = new SqlConnection(db.strConnect))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", txtb_username.Text);
                    command.Parameters.AddWithValue("@Password", txtb_password.Text);

                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Login successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Save the logged-in user information
                        string userIdQuery = "SELECT EmployeeID FROM Employees WHERE Email = @Email AND EmployPassword = @Password";
                        command.CommandText = userIdQuery;
                        int userId = (int)command.ExecuteScalar();

                        List<string> list = new List<string>();
                        list.Add(string.Format("SELECT EmployeeName FROM Employees WHERE EmployeeID = {0} ", userId));
                        list.Add(string.Format("SELECT Position FROM Employees WHERE EmployeeID = {0} ", userId));
                        list.Add(string.Format("SELECT Phone FROM Employees WHERE EmployeeID = {0} ", userId));
                        list.Add(string.Format("SELECT Email FROM Employees WHERE EmployeeID = {0} ", userId));

                        LoggedInUser = new User
                        {
                            Name = db.getString(list[0]),
                            Password = txtb_password.Text,
                            Id = userId,
                            Position = db.getString(list[1]),
                            Phone = db.getString(list[2]),
                            Email = db.getString(list[3])
                        };

                        // Close the login form
                        Hide();

                        // Create an instance of the main form
                        frm_Main mainForm = new frm_Main();
                        mainForm.FormClosed += frm_Main_FormClosed; // Subscribe to FormClosed event

                        //// Show the main form
                        if (LoggedInUser.Position.Equals("Nhân viên kho"))
                        {
                            MessageBox.Show("Bạn không có quyền truy cập vào các chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            mainForm.Close();
                            Show();
                        }
                        else
                        {
                            mainForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu đăng nhập!!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
            }
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }

    public class User
    {
        string name, password, position, phone, email;
        int id;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
        public string Position { get => position; set => position = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        public User()
        {
            name = "Trần Công Mạnh";
            password = "123456";
            position = "Chủ cửa hàng";
            phone = "0901234567";
            email = "congmanh@gmail.com";
            id = 1;
        }
        public User(string name, string password, int id, string position, string phone, string email)
        {
            this.name = name;
            this.password = password;
            this.id = id;
            this.position = position;
            this.phone = phone;
            this.email = email;
        }
    }
}
