using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniStore.Forms;
using SQL;
namespace MiniStore.Forms
{
    public partial class frm_Login : Form
    {
        DBConnect db;
        public frm_Login()
        {
            InitializeComponent();
            db = new DBConnect("miniMKT");
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
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
            string tmp = string.Format("Select count(*) from Employees where Email = '{0}' and EployPassword = '{1}'", txtb_username.Text, txtb_password.Text);
            if (db.checkExist(tmp))
            {
                MessageBox.Show("Login successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private void InitializeMainForm()
        {
            // Clear existing controls
            this.Controls.Clear();

            // Set the form properties for the main form
            this.Text = "Main Form";
            this.Size = new System.Drawing.Size(800, 600); // Adjust size as needed

            // Add main form controls
            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Welcome to the Main Form!";
            welcomeLabel.Location = new System.Drawing.Point(10, 10);
            welcomeLabel.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(welcomeLabel);

            // Add more controls as needed
        }
    }
}
