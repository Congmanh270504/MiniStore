using MiniStore.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.Management
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            QL_LoaiSanPham ql_LoaiSanPham = new QL_LoaiSanPham();
            ql_LoaiSanPham.FormClosed += QL_LoaiSanPham_FormClosed;
            ql_LoaiSanPham.Show();
        }

        private void QL_LoaiSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hide();
            frm_UserPermission frm_UserPermission = new frm_UserPermission();
            frm_UserPermission.FormClosed += Frm_UserPermission_FormClosed;
            frm_UserPermission.Show();
        }
        private void Frm_UserPermission_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hide();
            QL_KhachHang ql_KhachHang = new QL_KhachHang();
            ql_KhachHang.FormClosed += QL_KhachHang_FormClosed;
            ql_KhachHang.Show();
        }
        private void QL_KhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            QL_DSHoaDon ql_DSHoaDon = new QL_DSHoaDon();
            ql_DSHoaDon.FormClosed += QL_DSHoaDon_FormClosed;
            ql_DSHoaDon.Show();
        }
        private void QL_DSHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
