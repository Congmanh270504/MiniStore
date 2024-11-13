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
        private int currentImageIndex = 0;
        private string[] imagePaths = new string[]
        {
            @"E:\Trần Công Mạnh_BT\CongNghe_Net\Project\MiniStore\MINISTORE\img\discount_banner1.jpg",
            @"E:\Trần Công Mạnh_BT\CongNghe_Net\Project\MiniStore\MINISTORE\img\discount_banner2.jpg",
            @"E:\Trần Công Mạnh_BT\CongNghe_Net\Project\MiniStore\MINISTORE\img\discount_banner3.jpg",
            @"E:\Trần Công Mạnh_BT\CongNghe_Net\Project\MiniStore\MINISTORE\img\discount_banner5.jpg"
        };
        private Timer imageChangeTimer;

        public frm_Main()
        {
            InitializeComponent();
            db = new DBConnect("CongManhPC\\MSSQLSERVER01", "miniMKT");
            user = frm_Login.LoggedInUser;
            string query = string.Format("SELECT Position FROM Employees WHERE EmployeeID = {0} ", user.Id);
            position = db.getString(query);

            switch (position.Trim())
            {
                case "Nhân viên bán hàng":
                    btnPersonnel.Visible = false;
                    btnProduct.Visible = false;
                    btnReport.Visible = false;
                    btnAdmin.Visible = false;
                    break;
                case "Quản lý cửa hàng":
                    btnProduct.Visible = false;
                    btnAdmin.Visible = false;
                    break;
                default:
                    break;
            }

            imageChangeTimer = new Timer();
            imageChangeTimer.Interval = 4000;
            imageChangeTimer.Tick += new EventHandler(imageChangeTimer_Tick);
            imageChangeTimer.Start();
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
            Hide();
            Order order = new Order();
            order.FormClosed += Order_FormClosed; // Subscribe to FormClosed event
            order.Show();
        }
        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Hide();
            QL_Products ql_Food = new QL_Products();
            ql_Food.FormClosed += QL_Food_FormClosed; // Subscribe to FormClosed event
            ql_Food.Show();
        }
        private void QL_Food_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            Hide();
            QL_NhanSu ql_NhanSu = new QL_NhanSu();
            ql_NhanSu.FormClosed += QL_NhanSu_FormClosed; // Subscribe to FormClosed event
            ql_NhanSu.Show();
        }
        private void QL_NhanSu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            btnOrder.Visible = true;
            btnPersonnel.Visible = true;
            btnProduct.Visible = true;
            btnReport.Visible = true;
            btnSetting.Visible = true;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Hide();
            Setting setting = new Setting();
            setting.FormClosed += Setting_FormClosed; // Subscribe to FormClosed event
            setting.Show();
        }
        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.IsDisposed)
            {
                this.Show();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            Admin admin = new Admin();
            admin.FormClosed += Admin_FormClosed; // Subscribe to FormClosed event
            admin.Show();
        }
        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void imageChangeTimer_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            pictureBox3.Image = Image.FromFile(imagePaths[currentImageIndex]);
        }
    }
}
