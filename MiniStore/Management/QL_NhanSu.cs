using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.Management
{
    public partial class QL_NhanSu : Form
    {
        DBConnect db;
        SqlDataAdapter da_employees;
        DataTable employees;
        public QL_NhanSu()
        {
            InitializeComponent();
            db = new DBConnect("miniMKT");
        }

        private void QL_NhanSu_Load(object sender, EventArgs e)
        {
            load_NV();
        }
        void load_NV()
        {
            string sql = "select EmployeeID,EmployeeName,Position,Phone,Email from Employees";
            da_employees = db.getDataAdapter(sql, "Employees");
            employees = db.Dset.Tables["Employees"];
            dataGridView_DSNhanVien.DataSource = employees;

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = employees.Columns["EmployeeID"];
            employees.PrimaryKey = primaryKey;
            dataGridView_DSNhanVien.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
            dataGridView_DSNhanVien.Columns["EmployeeName"].HeaderText = "Tên nhân viên";
            dataGridView_DSNhanVien.Columns["Position"].HeaderText = "Vị trí";
            dataGridView_DSNhanVien.Columns["Phone"].HeaderText = "SĐT";
            dataGridView_DSNhanVien.Columns["Email"].HeaderText = "Email";

            // Center the header text
            dataGridView_DSNhanVien.Columns["EmployeeID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSNhanVien.Columns["EmployeeName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSNhanVien.Columns["Position"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSNhanVien.Columns["Phone"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_DSNhanVien.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView_DSNhanVien.Columns["EmployeeID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_DSNhanVien.Columns["EmployeeName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_DSNhanVien.Columns["Position"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_DSNhanVien.Columns["Phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_DSNhanVien.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView_DSNhanVien.Columns["EmployeeID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_DSNhanVien.Columns["EmployeeID"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dataGridView_DSNhanVien.Columns["EmployeeName"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression for Vietnamese phone numbers
            string pattern = @"^(03|05|07|08|09)\d{8,9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private bool IsValidGmail(string email)
        {
            // Regular expression for Gmail addresses
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
