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
    public partial class UC_RpProfileAllEmployess : UserControl
    {
        public UC_RpProfileAllEmployess()
        {
            InitializeComponent();
        }

        private void UC_RpProfileAllEmployess_Load(object sender, EventArgs e)
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

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Report.rp_ProfileAllEmployess r = new Report.rp_ProfileAllEmployess();
            r.SetParameterValue("BoPhanID", cmbBoPhan.SelectedValue.ToString());
            r.SetParameterValue("TenBoPhan", cmbBoPhan.Text);
            rpProfile.ReportSource = r;
            rpProfile.Zoom(75);  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.frm_Main.Instance.pnlContainer.Controls["UC_Report"].BringToFront();
        }
    }
}
