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
    public partial class editInfor : Form
    {
        DBConnect dB;
        User user;
        public editInfor()
        {
            InitializeComponent();
            dB = new DBConnect("CongManhPC\\MSSQLSERVER01", "miniMKT");
            user = frm_Login.LoggedInUser;
        }

        private void editInfor_Load(object sender, EventArgs e)
        {
            lbName.Text = user.Name;
            lbPhone.Text = user.Phone;
            lbEmail.Text = user.Email;
            lbPosition.Text = user.Position;

            tbName.Text = user.Name;
            tbPhone.Text = user.Phone;
            tbEmail.Text = user.Email;
        }
      
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbName.Equals(lbName) && tbPhone.Equals(lbPhone) && tbEmail.Equals(lbEmail))
            {
                MessageBox.Show("Không có gì thay đổi để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Chưa điền tên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                string query = string.Format("UPDATE Employees SET EmployeeName = N'{0}' WHERE EmployeeID = {1}", tbName.Text, user.Id);
                dB.updateToDataBase(query);
                user.Name = tbName.Text;
                lbName.Text = tbName.Text;
            }

            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                MessageBox.Show("Chưa điền số điện thoại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                string query = string.Format("UPDATE Employees SET Phone = '{0}' WHERE EmployeeID = {1}", tbPhone.Text, user.Id);
                dB.updateToDataBase(query);
                user.Phone = tbPhone.Text;
                lbPhone.Text = tbPhone.Text;
            }

            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Chưa điền email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                string query = string.Format("UPDATE Employees SET Email = '{0}' WHERE EmployeeID = {1}", tbEmail.Text, user.Id);
                dB.updateToDataBase(query);
                user.Email = tbEmail.Text;
                lbEmail.Text = tbEmail.Text;
            }
            MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
