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
    public partial class UC_RpProductInventory : UserControl
    {
        public UC_RpProductInventory()
        {
            InitializeComponent();
        }

        private void UC_RpProductInventory_Load(object sender, EventArgs e)
        {
            DataTable dt = lib.cls_Report._getLoaiSP();
            DataRow dr = dt.NewRow();
            dr["LoaiSPID"] = "-1";
            dr["TenLoaiSP"] = "Tất cả";
            dt.Rows.InsertAt(dr, 0);
            cmbLoaiSP.ValueMember = "LoaiSPID";
            cmbLoaiSP.DisplayMember = "TenLoaiSP";
            cmbLoaiSP.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.frm_Main.Instance.pnlContainer.Controls["UC_Report"].BringToFront();
        }

        private void cmbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            Report.rp_ProductInventory r = new Report.rp_ProductInventory();
            r.SetParameterValue("LoaiSPID", cmbLoaiSP.SelectedValue.ToString());
            r.SetParameterValue("TenSP", cmbLoaiSP.Text);
            rpProfile.ReportSource = r;
        }
    }
}
