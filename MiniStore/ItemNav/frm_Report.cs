using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.ItemNav
{
    public partial class frm_Report : Form
    {
        DBConnect db;
        SqlDataAdapter da_report;
        DataTable report;
        List<string> columnNames = new List<string>
{
"OrderYear",
"OrderMonth",
"TotalQuantity",
"TotalRevenue"
};
        public frm_Report()
        {
            InitializeComponent();
            db = new DBConnect("miniMKT");
        }
        private void loadReport()
        {
            string sql = "SELECT" +
            " MONTH(o.OrderDate) AS OrderMonth," +
            " YEAR(o.OrderDate) AS OrderYear," +
            " SUM(o.TotalAmount) AS TotalRevenue," +
            " SUM(od.Quantity) AS TotalQuantity" + " FROM  Orders o" +
            " JOIN OrderDetails od ON o.OrderID = od.OrderID" +
            " GROUP BY YEAR(o.OrderDate), MONTH(o.OrderDate)" +
            " ORDER BY OrderYear, OrderMonth;";

            da_report = db.getDataAdapter(sql, "Orders");

            if (report != null)
            {
                report.Clear();
            }
            else
            {
                report = new DataTable();
            }

            da_report.Fill(report);
            dataGridView.DataSource = report;
        }


        private int getTotalQuanity(string subQuery)
        {
            string sql = "SELECT SUM(TotalQuantity) AS GrandTotalQuantity FROM" +
                " ( SELECT MONTH(o.OrderDate) AS OrderMonth, YEAR(o.OrderDate) AS OrderYear," +
                " SUM(o.TotalAmount) AS TotalRevenue," +
                " SUM(od.Quantity) AS TotalQuantity" +
                " FROM  Orders o JOIN  OrderDetails od ON o.OrderID = od.OrderID" + subQuery +
                " GROUP BY  YEAR(o.OrderDate), MONTH(o.OrderDate)  ) AS MonthlyTotals; " ;
            return db.getCount(sql);
        }
        private int getTotalRevenue(string subQuery)
        {
            string sql = "SELECT SUM(TotalRevenue) AS GrandTotalRevenue FROM" +
           " ( SELECT MONTH(o.OrderDate) AS OrderMonth, YEAR(o.OrderDate) AS OrderYear," +
           " SUM(o.TotalAmount) AS TotalRevenue," +
           " SUM(od.Quantity) AS TotalQuantity" +
           " FROM  Orders o JOIN  OrderDetails od ON o.OrderID = od.OrderID" + subQuery +
           " GROUP BY  YEAR(o.OrderDate), MONTH(o.OrderDate)  ) AS MonthlyTotals; " ;
            return db.getCount(sql);
        }
        private void frm_Report2_Load(object sender, EventArgs e)
        {
            loadReport();
            dataGridView.Columns["OrderMonth"].HeaderText = "Tháng";
            dataGridView.Columns["OrderYear"].HeaderText = "Năm";
            dataGridView.Columns["TotalQuantity"].HeaderText = "Số lượng mặt hàng bán ra";
            dataGridView.Columns["TotalRevenue"].HeaderText = "Doanh thu";

            foreach (string item in columnNames)
            {
                dataGridView.Columns[item].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[item].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[item].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[item].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            }
            lbTotalQuantity.Text = getTotalQuanity("").ToString() + " sản phẩm đã bán";
            lbTotalRevenue.Text = getTotalRevenue("").ToString() + "đ";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadReport();
            tbTime.Clear();
            lbTotalQuantity.Text = getTotalQuanity("").ToString() + " sản phẩm đã bán";
            lbTotalRevenue.Text = getTotalRevenue("").ToString() + "đ";
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTime.Text))
            {
                MessageBox.Show("Bạn chưa nhập năm tìm kiếm.", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                tbTime.Focus();
                return;
            }
            string sql = "SELECT" +
            " MONTH(o.OrderDate) AS OrderMonth," +
            " YEAR(o.OrderDate) AS OrderYear," +
            " SUM(o.TotalAmount) AS TotalRevenue," +
            " SUM(od.Quantity) AS TotalQuantity" + " FROM Orders o" +
            " JOIN OrderDetails od ON o.OrderID = od.OrderID" +
            " WHERE YEAR(o.OrderDate) = " + tbTime.Text + " " +
            " GROUP BY YEAR(o.OrderDate), MONTH(o.OrderDate)" +
            " ORDER BY OrderYear, OrderMonth;";



            da_report = db.getDataAdapter(sql, "Orders");
            da_report.SelectCommand.Parameters.AddWithValue("@year", tbTime.Text);
            DataTable searchResults = new DataTable();
            da_report.Fill(searchResults);

            if (searchResults.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu cho năm đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbTotalQuantity.Text = getTotalQuanity(" WHERE YEAR(o.OrderDate) = " + tbTime.Text).ToString() + " sản phẩm đã bán";
                lbTotalRevenue.Text = getTotalRevenue(" WHERE YEAR(o.OrderDate) = " + tbTime.Text).ToString() + "đ";
                dataGridView.DataSource = searchResults;
            }
        }

        private void tbTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Tim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Tim_Click(sender, e);
            }
        }

        private void RevueneDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                // Lấy thông tin từ dòng được chọn
                string orderMonth = dataGridView.CurrentRow.Cells["OrderMonth"].Value.ToString();
                string orderYear = dataGridView.CurrentRow.Cells["OrderYear"].Value.ToString();
                // Tạo và hiển thị form OrderDetails
                var revenueDetailsForm = new frm_ReportDeatails(orderMonth, orderYear);
                Hide();
                revenueDetailsForm.FormClosed += frm_ReportDeatailsForm_FormClosed;
                revenueDetailsForm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frm_ReportDeatailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
