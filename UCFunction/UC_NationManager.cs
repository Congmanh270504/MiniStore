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
    public partial class UC_NationManager : UserControl
    {
        private int check = 0;
        private int danTocID = 0;
        public UC_NationManager()
        {
            InitializeComponent();
        }
        private void _sttButton(bool add, bool edit, bool delete, bool update, bool cancel, bool grpdt)
        {
            btnThem.Enabled = add;
            btnSua.Enabled = edit;
            btnXoa.Enabled = delete;
            btnCapNhat.Enabled = update;
            btnHuyBo.Enabled = cancel;
            grpDanToc.Enabled = grpdt;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_Category"].BringToFront();
            txtDanToc.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            txtDanToc.Text = "";
            _sttButton(false, false, false, true, true, true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            _sttButton(false, false, false, true, true, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (danTocID == 0)
            {
                MessageBox.Show("Vui lòng chọn dân tộc cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int delDanToc = lib.cls_Category._del("DanTocID", "tbl_DanToc", "tbl_HoSoNhanVien", danTocID);
            if (delDanToc == 1)
            {
                MessageBox.Show("Đã xóa thành công dân tộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtList.DataSource = lib.cls_Category._get("DanTocID", "TenDanToc", "tbl_DanToc");
                _sttButton(true, false, true, false, false, false);
                txtDanToc.Text = "";
                danTocID = 0;
            }
            else if (delDanToc == 0)
            {
                MessageBox.Show("Vui lòng xóa hồ sơ nhân viên có dân tộc này trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi xóa dân tộc. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lib.cls_Category._get("DanTocID", "TenDanToc", "tbl_DanToc").Rows.Count > 0)
            {
                int index = dtList.CurrentCell.RowIndex;
                danTocID = Convert.ToInt32(dtList.Rows[index].Cells["DanTocID"].Value);
                txtDanToc.Text = dtList.Rows[index].Cells["TenDanToc"].Value.ToString();
                btnSua.Enabled = true;
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            txtDanToc.Text = "";
            check = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtDanToc.Text == "")
            {
                MessageBox.Show("Tên dân tộc không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (check == 1)
            {
                bool insertDanToc = lib.cls_Category._insert("tbl_DanToc", "TenDanToc", txtDanToc.Text);
                if (insertDanToc)
                {
                    MessageBox.Show("Thêm dân tộc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = lib.cls_Category._get("DanTocID", "TenDanToc", "tbl_DanToc");
                    txtDanToc.Text = "";
                    check = 0;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm dân tộc. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool updateDanToc = lib.cls_Category._update("tbl_DanToc", "TenDanToc", "DanTocID", txtDanToc.Text, danTocID);
                if (updateDanToc)
                {
                    MessageBox.Show("Cập nhật dân tộc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = lib.cls_Category._get("DanTocID", "TenDanToc", "tbl_DanToc");
                    txtDanToc.Text = "";
                    danTocID = 0;
                    check = 0;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm dân tộc. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_NationManager_Load(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            dtList.DataSource = lib.cls_Category._get("DanTocID", "TenDanToc", "tbl_DanToc");
        }
    }
}
