using SQL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.Forms
{
    public partial class frm_UserPermission : Form
    {
        User user = new User();
        DBConnect db;
        public frm_UserPermission()
        {
            InitializeComponent();
            user = frm_Login.LoggedInUser;
            db = new DBConnect( "miniMKT");
            tbPosition.Enabled = false;
        }

        void load_Employee()
        {
            string query = "SELECT * FROM Employees";
            cmbNhanVien.DataSource = db.getDataTable(query, "Employees");
            cmbNhanVien.DisplayMember = "EmployeeName";
            cmbNhanVien.ValueMember = "EmployeeID";

        }
        private void frm_UserPermission_Load(object sender, EventArgs e)
        {
            load_Employee();
            tbPosition.Text = db.getString("SELECT Position FROM Employees WHERE EmployeeID = " +
                "(SELECT MIN(EmployeeID) FROM Employees)");
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (!db.checkExist(" select count(*) from Employees where Position= N'Chủ cửa hàng'"))
            {
                MessageBox.Show("Bạn cần phải chọn 1 người Chủ cửa hàng trước khi chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!db.checkExist(" select count(*) from Employees where Position= N'Quản lý cửa hàng'"))
            {
                MessageBox.Show("Bạn cần phải chọn 1 người Quản lý cửa hàng trước khi chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!db.checkExist(" select count(*) from Employees where Position= N'Nhân viên kho'"))
            {
                MessageBox.Show("Bạn cần phải chọn 1 người Nhân viên kho trước khi chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!db.checkExist(" select count(*) from Employees where Position= N'Nhân viên bán hàng'"))
            {
                MessageBox.Show("Bạn cần phải chọn 1 người Nhân viên bán hàng trước khi chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cấp quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            RadioButton rdo = new RadioButton();
            foreach (RadioButton item in grpb_phanquyen.Controls)
            {
                if (item.Checked == true)
                {
                    rdo = item;
                    break;
                }
            }

            if (tbPosition.Text.Equals(rdo.Text))
            {
                MessageBox.Show("Chức vụ đã được cấp quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string query = string.Format("update Employees set Position= N'{0}' where EmployeeID={1}", rdo.Text, cmbNhanVien.SelectedValue);
            db.updateToDataBase(query);
            //MessageBox.Show(query);
            MessageBox.Show("Cấp quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbPosition.Text = rdo.Text;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNhanVien.SelectedValue != null && cmbNhanVien.SelectedValue is int)
            {
                tbPosition.Text = db.getString(string.Format("SELECT Position FROM Employees WHERE EmployeeID = {0} ", cmbNhanVien.SelectedValue));
            }
        }
    }
}
