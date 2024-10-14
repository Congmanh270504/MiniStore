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
    public partial class UC_RpProductSold : UserControl
    {
        public UC_RpProductSold()
        {
            InitializeComponent();
        }

        private void UC_RpProductSold_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Report.rp_ProductSold r = new Report.rp_ProductSold();
            r.SetParameterValue("month", dtpThang.Value.Month.ToString());
            r.SetParameterValue("year", dtpThang.Value.Year.ToString());
            r.SetParameterValue("ThangThongKe", dtpThang.Value.ToString("MM/yyyy"));
            rpProfile.ReportSource = r;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.frm_Main.Instance.pnlContainer.Controls["UC_Report"].BringToFront();
        }
    }
}
