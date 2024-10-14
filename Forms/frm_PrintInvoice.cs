using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC_FASTFOOD.Forms
{
    public partial class frm_PrintInvoice : Form
    {
        string refund;
        string receive;
        string discount;
        string total;
        string money;
        string numInvoice;

        public frm_PrintInvoice()
        {
            InitializeComponent();
        }

        public string _numInvoice
        {
            get { return numInvoice; }
            set { numInvoice = value; }
        }

        public string _refund
        {
            get { return refund; }
            set { refund = value; }
        }

        public string _receive
        {
            get { return receive; }
            set { receive = value; }
        }

        public string _discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public string _total
        {
            get { return total; }
            set { total = value; }
        }

        public string _money
        {
            get { return money; }
            set { money = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_PrintInvoice_Load(object sender, EventArgs e)
        {
            Report.rp_PrintInvoice r = new Report.rp_PrintInvoice();
            r.SetParameterValue("mahd", numInvoice);
            r.SetParameterValue("money", money);
            r.SetParameterValue("discount", discount);
            r.SetParameterValue("receive", receive);
            r.SetParameterValue("refund", refund);
            r.SetParameterValue("total", total);
            rpInvoice.ReportSource = r;
        }
    }
}
