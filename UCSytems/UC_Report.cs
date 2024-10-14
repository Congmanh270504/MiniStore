using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KFC_FASTFOOD.Forms;
using KFC_FASTFOOD.UCFunction;

namespace KFC_FASTFOOD.UCSytems
{
    public partial class UC_Report : UserControl
    {
        public UC_Report()
        {
            InitializeComponent();
        }

        private void btnRpHoSoNV_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_RpProfileAllEmployess"))
            {
                UC_RpProfileAllEmployess profileAllEmployess = new UC_RpProfileAllEmployess();
                profileAllEmployess.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(profileAllEmployess);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_RpProfileAllEmployess"].BringToFront();
        }

        private void btnRp1NV_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_RpProfileEmployess"))
            {
                UC_RpProfileEmployess profileEmployess = new UC_RpProfileEmployess();
                profileEmployess.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(profileEmployess);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_RpProfileEmployess"].BringToFront();
        }

        private void btnRpMauHopDong_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_RpLabourContract"))
            {
                UC_RpLabourContract rpLabourContract = new UC_RpLabourContract();
                rpLabourContract.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(rpLabourContract);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_RpLabourContract"].BringToFront();
        }

        private void btnRpSalary_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_RpSalary"))
            {
                UC_RpSalary rpSalary = new UC_RpSalary();
                rpSalary.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(rpSalary);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_RpSalary"].BringToFront();
        }

        private void btnRpSoLuongLD_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_RpNumberOfEmployess"))
            {
                UC_RpNumberOfEmployess rpNumberOfEmployess = new UC_RpNumberOfEmployess();
                rpNumberOfEmployess.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(rpNumberOfEmployess);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_RpNumberOfEmployess"].BringToFront();
        }

        private void btnRpSanPham_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_RpProduct"))
            {
                UC_RpProduct rpProduct = new UC_RpProduct();
                rpProduct.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(rpProduct);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_RpProduct"].BringToFront();
        }

        private void btnRpSPDaBan_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_RpProductSold"))
            {
                UC_RpProductSold rpProductSold = new UC_RpProductSold();
                rpProductSold.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(rpProductSold);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_RpProductSold"].BringToFront();
        }

        private void btnRpDoanhThu_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_RpRevenue"))
            {
                UC_RpRevenue rpRevenue = new UC_RpRevenue();
                rpRevenue.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(rpRevenue);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_RpRevenue"].BringToFront();
        }

        private void btnRpHoaDon_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_InvoiceDetails"))
            {
                UC_InvoiceDetails invoiceDetails = new UC_InvoiceDetails();
                invoiceDetails.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(invoiceDetails);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_InvoiceDetails"].BringToFront();
        }

        private void btnRpSPTonKho_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_RpProductInventory"))
            {
                UC_RpProductInventory productInventory = new UC_RpProductInventory();
                productInventory.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(productInventory);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_RpProductInventory"].BringToFront();
        }
    }
}
