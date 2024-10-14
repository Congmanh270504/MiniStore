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
    public partial class UC_RpNumberOfEmployess : UserControl
    {
        public UC_RpNumberOfEmployess()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.frm_Main.Instance.pnlContainer.Controls["UC_Report"].BringToFront();
        }

        private void UC_RpNumberOfEmployess_Load(object sender, EventArgs e)
        {
            cmbTinhTrang.DisplayMember = "Text";
            cmbTinhTrang.ValueMember = "Value";

            var items = new[] {
                    new { Text = "Nghỉ việc", Value = "0" },
                    new { Text = "Đang làm việc", Value = "1" }
            };

            cmbTinhTrang.DataSource = items;
        }

        private void cmbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Report.rp_NumberOfEmployess r = new Report.rp_NumberOfEmployess();
            r.SetParameterValue("trangThai", cmbTinhTrang.Text);
            r.SetParameterValue("trangThaiID", cmbTinhTrang.SelectedValue.ToString());
            rpProfile.ReportSource = r;
        }
    }
}
