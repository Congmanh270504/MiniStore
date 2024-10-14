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
    public partial class frm_Setting : Form
    {
        public frm_Setting()
        {
            InitializeComponent();
        }
        private int select = -1;
        private int storeID_old = -1;
        private void frm_Setting_Load(object sender, EventArgs e)
        {
            txtStoreID.Text = lib.cls_BackupRestore._getInfoStore()[0];
            storeID_old = Convert.ToInt32(txtStoreID.Text);
            txtCuaHang.Text = lib.cls_BackupRestore._getInfoStore()[1];
            txtDiaChi.Text = lib.cls_BackupRestore._getInfoStore()[2];
            cmbFilter.ValueMember = "Value";
            cmbFilter.DisplayMember = "Text";
            var items = new[] {
                new { Text = "Cập nhật", Value = "1" },
                new { Text = "Thêm mới", Value = "0" },
            };
            cmbFilter.DataSource = items;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtDiaChi.Enabled = true;
            txtCuaHang.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtStoreID.Text == "" || txtCuaHang.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int myInt;
            bool checkStoreID = int.TryParse(txtStoreID.Text, out myInt);
            if (!checkStoreID)
            {
                MessageBox.Show("Store ID phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (select == 0)
            {
                bool insert = lib.cls_BackupRestore._insertInfoStore(txtCuaHang.Text, txtDiaChi.Text, Convert.ToInt32(txtStoreID.Text), storeID_old);
                if (insert)
                {
                    MessageBox.Show("Thêm mới thành công thông tin cửa hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiaChi.Enabled = false;
                    txtCuaHang.Enabled = false;
                    txtStoreID.Enabled = false;
                    select = -1;
                    frm_Setting_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (lib.cls_BackupRestore._updateInfoStore(txtCuaHang.Text, txtDiaChi.Text, Convert.ToInt32(txtStoreID.Text)))
                {
                    MessageBox.Show("Cập nhật thành công thông tin cửa hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiaChi.Enabled = false;
                    txtCuaHang.Enabled = false;
                    frm_Setting_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedValue.ToString() == "0")
            {
                DialogResult result = MessageBox.Show("Bạn muốn cập nhật cửa hàng mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    select = 0;
                    txtDiaChi.Enabled = true;
                    txtCuaHang.Enabled = true;
                    txtStoreID.Enabled = true;
                    txtCuaHang.Text = "";
                    txtDiaChi.Text = "";
                    txtStoreID.Text = "";
                    btnSua.Enabled = false;
                }
                else
                {
                    btnSua.Enabled = true;
                }
            }
            else
            {
                btnSua.Enabled = true;
                txtDiaChi.Enabled = false;
                txtCuaHang.Enabled = false;
                txtStoreID.Enabled = false;
                frm_Setting_Load(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
