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

namespace KFC_FASTFOOD.UCFunction
{
    public partial class UC_OfficesManager : UserControl
    {
        public UC_OfficesManager()
        {
            InitializeComponent();
        }
        private int check = 0;
        private int boPhanID = 0;
        private void _sttButton(bool add, bool edit, bool delete, bool update, bool cancel, bool grpbp)
        {
            btnThem.Enabled = add;
            btnSua.Enabled = edit;
            btnXoa.Enabled = delete;
            btnCapNhat.Enabled = update;
            btnHuyBo.Enabled = cancel;
            grpBoPhan.Enabled = grpbp;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_Category"].BringToFront();
            txtBoPhan.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            txtBoPhan.Text = "";
            _sttButton(false, false, false, true, true, true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            _sttButton(false, false, false, true, true, true);
        }

        private void UC_OfficesManager_Load(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            dtList.DataSource = lib.cls_Category._get("BoPhanID", "TenBoPhan", "tbl_BoPhan");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (boPhanID == 0)
            {
                MessageBox.Show("Vui lòng chọn bộ phận cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int delBoPhan = lib.cls_Category._del("BoPhanID", "tbl_BoPhan", "tbl_NhanVienBoPhan", boPhanID);
            if (delBoPhan == 1)
            {
                MessageBox.Show("Đã xóa thành công bộ phận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtList.DataSource = lib.cls_Category._get("BoPhanID", "TenBoPhan", "tbl_BoPhan");
                _sttButton(true, false, true, false, false, false);
                txtBoPhan.Text = "";
                boPhanID = 0;
            }
            else if (delBoPhan == 0)
            {
                MessageBox.Show("Vui lòng xóa hồ sơ nhân viên có bộ phận này trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi xóa bộ phận. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lib.cls_Category._get("BoPhanID", "TenBoPhan", "tbl_BoPhan").Rows.Count > 0)
            {
                int index = dtList.CurrentCell.RowIndex;
                boPhanID = Convert.ToInt32(dtList.Rows[index].Cells["BoPhanID"].Value);
                txtBoPhan.Text = dtList.Rows[index].Cells["TenBoPhan"].Value.ToString();
                btnSua.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtBoPhan.Text == "")
            {
                MessageBox.Show("Tên bộ phận không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (check == 1)
            {
                bool insertBoPhan = lib.cls_Category._insert("tbl_BoPhan", "TenBoPhan", txtBoPhan.Text);
                if (insertBoPhan)
                {
                    MessageBox.Show("Thêm bộ phận thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = lib.cls_Category._get("BoPhanID", "TenBoPhan", "tbl_BoPhan");
                    txtBoPhan.Text = "";
                    check = 0;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm bộ phận. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool updateBoPhan = lib.cls_Category._update("tbl_BoPhan", "TenBoPhan", "BoPhanID", txtBoPhan.Text, boPhanID);
                if (updateBoPhan)
                {
                    MessageBox.Show("Cập nhật bộ phận thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = lib.cls_Category._get("BoPhanID", "TenBoPhan", "tbl_BoPhan");
                    txtBoPhan.Text = "";
                    boPhanID = 0;
                    check = 0;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm bộ phận. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            txtBoPhan.Text = "";
            check = 0;
        }
    }
}
