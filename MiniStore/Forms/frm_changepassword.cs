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

namespace MiniStore.Forms
{
    public partial class frm_changepassword : Form
    {
        DBConnect db;
        SqlDataAdapter da_user;

        public frm_changepassword()
        {
            InitializeComponent();
            db = new DBConnect( "miniMKT");
        }

        private void btn_Xacnhan_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Employees WHERE EmployPassword = @OldPassword";
            using (SqlCommand cmd = new SqlCommand(query, db.conn))
            {
                cmd.Parameters.AddWithValue("@OldPassword", txtMatKhauCu.Text);
                db.conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();

                    // Update the password with the new password
                    string updateQuery = "UPDATE Employees SET EmployPassword = @NewPassword WHERE EmployPassword = @OldPassword";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, db.conn))
                    {
                        updateCmd.Parameters.AddWithValue("@NewPassword", txtMatKhauMoi.Text);
                        updateCmd.Parameters.AddWithValue("@OldPassword", txtMatKhauCu.Text);
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mật khẩu đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật mật khẩu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.conn.Close();
                Close();
            }
        }

        private void frm_changepassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
