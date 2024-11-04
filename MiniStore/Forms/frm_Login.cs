using SQL;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;

namespace MiniStore.Forms
{
    public partial class frm_Login : Form
    {
        DBConnect db;
        public static User LoggedInUser { get; private set; } // Static variable to store the logged-in user

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

                        LoggedInUser = new User
                        {
                            Name = txtb_username.Text,
                            Password = txtb_password.Text,
                            Id = userId
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
                    }
                }
            }
        }
    }

    public class User
    {
        string name, password;
        int id;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }

        public User()
        {
            name = "Trần Công Mạnh";
            password = "123456";
            id = 1;
        }
        public User(string name, string password, int id)
        {
            this.name = name;
            this.password = password;
            this.id = id;
        }
    }
}
