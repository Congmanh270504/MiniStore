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
    public partial class UC_ReligionManager : UserControl
    {
        public UC_ReligionManager()
        {
            InitializeComponent();
        }
        private int check = 0;
        private int tonGiaoID = 0;
        private void _sttButton(bool add, bool edit, bool delete, bool update, bool cancel, bool grptg)
        {
            btnThem.Enabled = add;
            btnSua.Enabled = edit;
            btnXoa.Enabled = delete;
            btnCapNhat.Enabled = update;
            btnHuyBo.Enabled = cancel;
            grpTonGiao.Enabled = grptg;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_Category"].BringToFront();
            txtTonGiao.Text = "";
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            txtTonGiao.Text = "";
            check = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTonGiao.Text == "")
            {
                MessageBox.Show("Tên tôn giáo không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (check == 1)
            {
                bool insertTonGiao = lib.cls_Category._insert("tbl_TonGiao", "TenTonGiao", txtTonGiao.Text);
                if (insertTonGiao)
                {
                    MessageBox.Show("Thêm tôn giáo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = lib.cls_Category._get("TonGiaoID", "TenTonGiao", "tbl_TonGiao");
                    txtTonGiao.Text = "";
                    check = 0;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm tôn giáo. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool updateTonGiao = lib.cls_Category._update("tbl_TonGiao", "TenTonGiao", "TonGiaoID", txtTonGiao.Text, tonGiaoID);
                if (updateTonGiao)
                {
                    MessageBox.Show("Cập nhật tôn giáo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = lib.cls_Category._get("TonGiaoID", "TenTonGiao", "tbl_TonGiao");
                    txtTonGiao.Text = "";
                    tonGiaoID = 0;
                    check = 0;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm tôn giáo. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tonGiaoID == 0)
            {
                MessageBox.Show("Vui lòng chọn tôn giáo cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int delTonGiao = lib.cls_Category._del("TonGiaoID", "tbl_TonGiao", "tbl_HoSoNhanVien", tonGiaoID);
            if (delTonGiao == 1)
            {
                MessageBox.Show("Đã xóa thành công tôn giáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtList.DataSource = lib.cls_Category._get("TonGiaoID", "TenTonGiao", "tbl_TonGiao");
                _sttButton(true, false, true, false, false, false);
                txtTonGiao.Text = "";
                tonGiaoID = 0;
            }
            else if (delTonGiao == 0)
            {
                MessageBox.Show("Vui lòng xóa hồ sơ nhân viên có tôn giáo này trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi thêm tôn giáo. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            _sttButton(false, false, false, true, true, true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            txtTonGiao.Text = "";
            _sttButton(false, false, false, true, true, true);
        }

        private void UC_ReligionManager_Load(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            dtList.DataSource = lib.cls_Category._get("TonGiaoID", "TenTonGiao", "tbl_TonGiao");
        }

        private void dtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lib.cls_Category._get("TonGiaoID", "TenTonGiao", "tbl_TonGiao").Rows.Count > 0)
            {
                int index = dtList.CurrentCell.RowIndex;
                tonGiaoID = Convert.ToInt32(dtList.Rows[index].Cells["TonGiaoID"].Value);
                txtTonGiao.Text = dtList.Rows[index].Cells["TenTonGiao"].Value.ToString();
                btnSua.Enabled = true;
            }
        }
    }
}
