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

namespace MiniStore.Report
{
    public partial class frm_HoaDon : Form
    {
        DBConnect db;
        int orderId;
        public frm_HoaDon(int orderId)
        {
            db = new DBConnect("miniMKT");
            InitializeComponent();
            this.orderId = orderId;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            HoaDon rpt = new HoaDon();
            rpt.SetDatabaseLogon("sa", "12345");
            rpt.SetParameterValue("orderID", orderId);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
