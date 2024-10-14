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
    public partial class UC_DegreeManager : UserControl
    {
        public UC_DegreeManager()
        {
            InitializeComponent();
        }
        private int check = 0;
        private int bangCapID = 0;
        private void _sttButton(bool add, bool edit, bool delete, bool update, bool cancel, bool grpbc)
        {
            btnThem.Enabled = add;
            btnSua.Enabled = edit;
            btnXoa.Enabled = delete;
            btnCapNhat.Enabled = update;
            btnHuyBo.Enabled = cancel;
            grpBangCap.Enabled = grpbc;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_Category"].BringToFront();
            txtBangCap.Text = "";
        }

        private void UC_DegreeManager_Load(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            dtList.DataSource = lib.cls_Category._get("BangCapID", "TenBangCap", "tbl_BangCap");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            txtBangCap.Text = "";
            _sttButton(false, false, false, true, true, true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            _sttButton(false, false, false, true, true, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bangCapID == 0)
            {
                MessageBox.Show("Vui lòng chọn bằng cấp cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int delBangCap = lib.cls_Category._del("BangCapID", "tbl_BangCap", "tbl_HoSoNhanVien", bangCapID);
            if (delBangCap == 1)
            {
                MessageBox.Show("Đã xóa thành công bằng cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtList.DataSource = lib.cls_Category._get("BangCapID", "TenBangCap", "tbl_BangCap");
                _sttButton(true, false, true, false, false, false);
                txtBangCap.Text = "";
                bangCapID = 0;
            }
            else if (delBangCap == 0)
            {
                MessageBox.Show("Vui lòng xóa hồ sơ nhân viên có bằng cấp này trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi thêm bằng cấp. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtBangCap.Text == "")
            {
                MessageBox.Show("Tên bằng cấp không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (check == 1)
            {
                bool insertBangCap = lib.cls_Category._insert("tbl_BangCap", "TenbangCap", txtBangCap.Text);
                if (insertBangCap)
                {
                    MessageBox.Show("Thêm bằng cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = lib.cls_Category._get("BangCapID", "TenBangCap", "tbl_BangCap");
                    txtBangCap.Text = "";
                    check = 0;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm bằng cấp. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool updateBangCap = lib.cls_Category._update("tbl_BangCap", "TenBangCap", "BangCapID", txtBangCap.Text, bangCapID);
                if (updateBangCap)
                {
                    MessageBox.Show("Cập nhật bằng cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = lib.cls_Category._get("BangCapID", "TenBangCap", "tbl_BangCap");
                    txtBangCap.Text = "";
                    bangCapID = 0;
                    check = 0;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm bằng cấp. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lib.cls_Category._get("BangCapID", "TenBangCap", "tbl_BangCap").Rows.Count > 0)
            {
                int index = dtList.CurrentCell.RowIndex;
                bangCapID = Convert.ToInt32(dtList.Rows[index].Cells["BangCapID"].Value);
                txtBangCap.Text = dtList.Rows[index].Cells["TenBangCap"].Value.ToString();
                btnSua.Enabled = true;
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            txtBangCap.Text = "";
            check = 0;
        }
    }
}
