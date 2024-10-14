using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace KFC_FASTFOOD.UCFunction
{
    public partial class UC_RpLabourContract : UserControl
    {
        public UC_RpLabourContract()
        {
            InitializeComponent();
        }

        private void UC_RpLabourContract_Load(object sender, EventArgs e)
        {
            DataTable dt = lib.cls_Report._getNhanVien();

            cmbNhanVien.ValueMember = "NhanVienID";
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.DataSource = dt;
        }

        private void btnXemHopDong_Click(object sender, EventArgs e)
        {
            DataTable dt = lib.cls_Report._getProfileEmployess(Convert.ToInt32(cmbNhanVien.SelectedValue));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Nhân viên này chưa có thông tin vui lòng thêm thông tin vào hồ sơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow row = dt.Rows[0];
            Report.rp_LabourContract r = new Report.rp_LabourContract();
            r.SetParameterValue("TenNV", row["TenNV"].ToString());
            r.SetParameterValue("NgaySinh", Convert.ToDateTime(row["NgaySinh"].ToString()).ToString("dd/MM/yyyy"));
            r.SetParameterValue("BangCap", row["TenBangCap"].ToString());
            r.SetParameterValue("DiaChi", row["DiaChi"].ToString());
            r.SetParameterValue("CMND", row["CMND"].ToString());
            r.SetParameterValue("ChucVu", row["TenChucDanh"].ToString());
            r.SetParameterValue("LuongCung", string.Format(new CultureInfo("vi-VN"), "{0:#,##}", row["TienLuong"]));
            r.SetParameterValue("NgayVaoLam", Convert.ToDateTime(row["NgayVaoLam"].ToString()).ToString("dd/MM/yyyy"));
            rpProfile.ReportSource = r;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.frm_Main.Instance.pnlContainer.Controls["UC_Report"].BringToFront();
        }
    }
}
