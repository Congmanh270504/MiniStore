using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.Report
{
    public partial class frm_DSHD : Form
    {
        public frm_DSHD()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DSHoaDon rpt = new DSHoaDon();
            rpt.SetDatabaseLogon("sa", "12345");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

    }
}
