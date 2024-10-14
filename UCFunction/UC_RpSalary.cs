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
    public partial class UC_RpSalary : UserControl
    {
        public UC_RpSalary()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.frm_Main.Instance.pnlContainer.Controls["UC_Report"].BringToFront();
        }

        private void UC_RpSalary_Load(object sender, EventArgs e)
        {
            DataTable dt = lib.cls_Employess._getDeparment();
            DataRow dr = dt.NewRow();
            dr["BoPhanID"] = "-1";
            dr["TenBoPhan"] = "Tất cả";
            dt.Rows.InsertAt(dr, 0);
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
            cmbBoPhan.DataSource = dt;
        }

        private void btnXemHopDong_Click(object sender, EventArgs e)
        {
            Report.rp_Salary r = new Report.rp_Salary();
            r.SetParameterValue("BoPhanID", Convert.ToInt32(cmbBoPhan.SelectedValue));
            r.SetParameterValue("TenBoPhan", cmbBoPhan.Text);
            r.SetParameterValue("Thang", dtpThang.Value.ToString("yyyyMM"));
            r.SetParameterValue("ThangKe", dtpThang.Value.ToString("MM/yyyy"));
            rpProfile.ReportSource = r;
            rpProfile.Zoom(75);
        }
    }
}
