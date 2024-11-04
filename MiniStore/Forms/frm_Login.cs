using SQL;
using System.Windows.Forms;
using System;

namespace MiniStore.Forms
{
    public partial class frm_Login : Form
    {
        DBConnect db;
        public static User LoggedInUser { get; private set; } // Biến tĩnh để lưu đối tượng User

        public frm_Login()
        {
            InitializeComponent();
            db = new DBConnect("CongManhPC\\MSSQLSERVER01", "miniMKT");
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
                MessageBox.Show("Vui lòng nhập mậu khẩu !!", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            string tmp = string.Format("Select count(*) from Employees where Email = '{0}' and EmployPassword = '{1}'", txtb_username.Text, txtb_password.Text);
            if (db.checkExist(tmp))
            {
                MessageBox.Show("Login successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Lưu thông tin người dùng đăng nhập
                LoggedInUser = new User
                {
                    Name = txtb_username.Text,
                    Password = txtb_password.Text
                };

                // Create an instance of the main form
                frm_Main mainForm = new frm_Main();

                // Show the main form
                mainForm.Show();

                // Hide the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu đăng nhập!!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
        }
    }

    public class User
    {
        string name, password;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public User()
        {
            name = "Trần Công Mạnh";
            password = "123456";
        }
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
