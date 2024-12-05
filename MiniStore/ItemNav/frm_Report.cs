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
        SqlDataAdapter da_employees;
        DataTable employees;
        List<string> columnNames = new List<string>
                        {
                            "OrderID",
                            "CustomerName",
                            "EmployeeName",
                            "OrderDate",
                            "TotalAmount",
                            "PaymentMethod"
                        };
        public frm_Report()
        {
            InitializeComponent();
        }

        private void frm_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
