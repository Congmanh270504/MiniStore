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
    public partial class UC_CityCategory : UserControl
    {
        private int check = 0;
        private int tinhThanhID = 0;
        public UC_CityCategory()
        {
            InitializeComponent();
        }
        private void _sttButton(bool add, bool edit, bool delete, bool update, bool cancel, bool grptt)
        {
            btnThem.Enabled = add;
            btnSua.Enabled = edit;
            btnXoa.Enabled = delete;
            btnCapNhat.Enabled = update;
            btnHuyBo.Enabled = cancel;
            grpTinhThanh.Enabled = grptt;
        }
        private void UC_CityCategory_Load(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            dtList.DataSource = lib.cls_Category._get("TinhThanhID", "TenTinhThanh", "tbl_TinhThanh");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_Category"].BringToFront();
            txtTinhThanh.Text = "";
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtTinhThanh.Text = "";
            _sttButton(true, false, true, false, false, false);
            check = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            _sttButton(false, false, false, true, true, true);
            txtTinhThanh.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            _sttButton(false, false, false, true, true, true);
        }

        private void dtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lib.cls_Category._get("TinhThanhID", "TenTinhThanh", "tbl_TinhThanh").Rows.Count > 0)
            {
                int index = dtList.CurrentCell.RowIndex;
                tinhThanhID = Convert.ToInt32(dtList.Rows[index].Cells["TinhThanhID"].Value);
                txtTinhThanh.Text = dtList.Rows[index].Cells["TenTinhThanh"].Value.ToString();
                btnSua.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTinhThanh.Text == "")
            {
                MessageBox.Show("Tên tỉnh thành không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (check == 1)
            {
                bool insertTinhThanh = lib.cls_Category._insert("tbl_TinhThanh", "TenTinhThanh", txtTinhThanh.Text);
                if (insertTinhThanh)
                {
                    MessageBox.Show("Thêm tỉnh thành thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = lib.cls_Category._get("TinhThanhID", "TenTinhThanh", "tbl_TinhThanh");
                    txtTinhThanh.Text = "";
                    check = 0;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm tỉnh thành. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool updateTinhThanh = lib.cls_Category._update("tbl_TinhThanh", "TenTinhThanh", "TinhThanhID", txtTinhThanh.Text, tinhThanhID);
                if (updateTinhThanh)
                {
                    MessageBox.Show("Cập nhật tên tỉnh thành thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = lib.cls_Category._get("TinhThanhID", "TenTinhThanh", "tbl_TinhThanh");
                    txtTinhThanh.Text = "";
                    tinhThanhID = 0;
                    check = 0;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi thêm tỉnh thành. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tinhThanhID == 0)
            {
                MessageBox.Show("Vui lòng chọn tỉnh thành cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int delTinhThanh = lib.cls_Category._del("TinhThanhID", "tbl_TinhThanh", "tbl_HoSoNhanVien",tinhThanhID);
            if (delTinhThanh == 1)
            {
                MessageBox.Show("Đã xóa thành công tỉnh thành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtList.DataSource = lib.cls_Category._get("TinhThanhID", "TenTinhThanh", "tbl_TinhThanh");
                _sttButton(true, false, true, false, false, false);
                txtTinhThanh.Text = "";
                tinhThanhID = 0;
            }
            else if (delTinhThanh == 0)
            {
                MessageBox.Show("Vui lòng xóa hồ sơ nhân viên có tỉnh thành này trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi thêm tỉnh thành. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
