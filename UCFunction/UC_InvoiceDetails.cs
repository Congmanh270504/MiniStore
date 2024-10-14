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
    public partial class UC_InvoiceDetails : UserControl
    {
        public UC_InvoiceDetails()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.frm_Main.Instance.pnlContainer.Controls["UC_Report"].BringToFront();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtList.DataSource = lib.cls_Report._searchInvoice(txtTimKiem.Text);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dtList.DataSource = lib.cls_Report._searchInvoice(txtTimKiem.Text);
        }

        private void dtList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dtList.Columns["TongTien"].DefaultCellStyle.Format = "N0";
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            int index = dtList.CurrentCell.RowIndex;
            string numReceipt = dtList.Rows[index].Cells[0].Value.ToString();
            using (Forms.frm_InvoiceDetails invoiceDetails = new Forms.frm_InvoiceDetails())
            {
                invoiceDetails.numReceipt = numReceipt;
                invoiceDetails.ShowDialog();
            }
        }
    }
}
