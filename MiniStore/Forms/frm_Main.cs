using MiniStore.ItemNav;
using MiniStore.Management;
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

namespace MiniStore.Forms
{
    public partial class frm_Main : Form
    {
        DBConnect db;
        User user;
        string position;
        public frm_Main()
        {
            InitializeComponent();
            db = new DBConnect("CongManhPC\\MSSQLSERVER01", "miniMKT");
            user = frm_Login.LoggedInUser;
            string query = string.Format("SELECT Position FROM Employees WHERE EmployeeID = {0} ", user.Id);
            position = db.getString(query);
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            QL_Products ql_Food = new QL_Products();
            ql_Food.Show();
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            QL_NhanSu ql_NhanSu = new QL_NhanSu();
            ql_NhanSu.Show();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            switch (position)
            {
                case "Nhân viên kho":
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Nhân viên bán hàng":
                    btnPersonnel.Visible = false;
                    btnReport.Visible = false;
                    btnCategory.Visible = false;
                    btnProduct.Visible = false;
                    break;
                case "Quản lý":
                    break;
                default:
                    break;
            }
        }
    }
}
