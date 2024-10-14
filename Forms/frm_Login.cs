using System;
using System.Windows.Forms;

namespace KFC_FASTFOOD.Forms
{
	public partial class frm_Login : Form
	{
		public frm_Login()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// pass 123456a@
			string password = lib.cls_EnCrypt.EncryptMD5(txtPassword.Text);
			string NguoiDungID = lib.cls_Employess._checkLogin(txtTenDangNhap.Text, password);

			if (NguoiDungID != "ERROR")
			{
				using (frm_Main fm = new frm_Main(NguoiDungID))
				{
					this.Hide();
					fm.ShowDialog();
					this.Show();
				}
			}
			else
			{
				MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtTenDangNhap.Focus();
			}
		}

		private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin_Click(sender, e);
			}
		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin_Click(sender, e);
			}
		}
	}
}
