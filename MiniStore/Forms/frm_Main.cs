using MiniStore.ItemNav;
using MiniStore.Management;
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
        public frm_Main()
        {
            InitializeComponent();
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

    }
}
