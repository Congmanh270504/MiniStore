using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC_FASTFOOD.UCFunction
{
    public partial class UC_RpProfileEmployess : UserControl
    {
        public UC_RpProfileEmployess()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.frm_Main.Instance.pnlContainer.Controls["UC_Report"].BringToFront();
        }

        private void UC_RpProfileEmployess_Load(object sender, EventArgs e)
        {
            DataTable dt = lib.cls_Employess._getDeparment();

            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
            cmbBoPhan.DataSource = dt;
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = lib.cls_Employess._getNhanVienBoPhanID(Convert.ToInt32(cmbBoPhan.SelectedValue));
            cmbNhanVien.ValueMember = "NhanVienID";
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.DataSource = dt;
        }

        private void btnXemHoSo_Click(object sender, EventArgs e)
        {
            DataTable dt = lib.cls_Employess._getProfileEmployess(Convert.ToInt32(cmbNhanVien.SelectedValue));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Nhân viên này chưa có thông tin vui lòng thêm thông tin vào hồ sơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow row = dt.Rows[0];
            Report.rp_ProfileEmployess r = new Report.rp_ProfileEmployess();
            r.SetParameterValue("MaNV", row["MaNV"].ToString());
            r.SetParameterValue("TenNV", row["TenNV"].ToString());
            r.SetParameterValue("NgaySinh", Convert.ToDateTime(row["NgaySinh"].ToString()).ToString("dd/MM/yyyy"));
            r.SetParameterValue("SoCMND", row["CMND"].ToString());
            r.SetParameterValue("DiaChi", row["DiaChi"].ToString());
            r.SetParameterValue("DienThoai", row["SDT"].ToString());
            r.SetParameterValue("Email", row["Email"].ToString());
            r.SetParameterValue("BangCap", row["TenBangCap"].ToString());
            r.SetParameterValue("DanToc", row["TenDanToc"].ToString());
            r.SetParameterValue("NgayVaoLam", Convert.ToDateTime(row["NgayVaoLam"].ToString()).ToString("dd/MM/yyyy"));
            r.SetParameterValue("TinhThanh", row["TenTinhThanh"].ToString());
            r.SetParameterValue("TonGiao", row["TenTonGiao"].ToString());
            string imagePath = Application.StartupPath + row["ImagePath"].ToString();
            r.SetParameterValue("ImagePath", imagePath);
            rpProfile.ReportSource = r;
        }
    }
}
