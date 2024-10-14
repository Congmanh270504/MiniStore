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
    public partial class frm_InvoiceDetails : Form
    {
        public frm_InvoiceDetails()
        {
            InitializeComponent();
        }
        private string message;
        public string numReceipt
        {
            get { return message; }
            set { message = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_InvoiceDetails_Load(object sender, EventArgs e)
        {
            Report.rp_InvoiceDetails invoiceDetails = new Report.rp_InvoiceDetails();
            invoiceDetails.SetParameterValue("mahd", message);
            rpInvoice.ReportSource = invoiceDetails;
        }
    }
}
