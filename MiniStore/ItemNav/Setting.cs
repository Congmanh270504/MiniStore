using MiniStore.Forms;
using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.ItemNav
{
    public partial class Setting : Form
    {
        DBConnect db;
        User user;
        public Setting()
        {
            InitializeComponent();
            db = new DBConnect( "miniMKT");
            user = frm_Login.LoggedInUser;
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Setting_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(string.Format("SELECT EmployeeName FROM Employees WHERE EmployeeID = {0} ", user.Id));
            list.Add(string.Format("SELECT Position FROM Employees WHERE EmployeeID = {0} ", user.Id));
            list.Add(string.Format("SELECT Phone FROM Employees WHERE EmployeeID = {0} ", user.Id));
            list.Add(string.Format("SELECT Email FROM Employees WHERE EmployeeID = {0} ", user.Id));

            List<string> employess = new List<string>();
            foreach (string query in list)
            {
                employess.Add(db.getString(query));
            }
            lbName.Text = employess[0];
            lbPosition.Text = employess[1];
            lbPhone.Text = employess[2];
            lbEmail.Text = employess[3];
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            editInfor editInfor = new editInfor();
            editInfor.FormClosed += EditInfor_FormClosed; // Subscribe to FormClosed event
            editInfor.Show();
        }

        private void EditInfor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Show the Setting form again when editInfor is closed
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lbName.Text = user.Name;
            lbPhone.Text = user.Phone;
            lbEmail.Text = user.Email;
            lbPosition.Text = user.Position;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();

            frm_changepassword frm_Changepassword = new frm_changepassword();
            frm_Changepassword.FormClosed += Frm_Changepassword_FormClosed;
            frm_Changepassword.Show();
        }
        private void Frm_Changepassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form.Name != "frm_Login")
                {
                    form.Close();
                }
            }

            // Show the login form
            frm_Login loginForm = frm_Login.GetInstance();
            loginForm.ResetFields();
            loginForm.Show();

        }

    }
}
