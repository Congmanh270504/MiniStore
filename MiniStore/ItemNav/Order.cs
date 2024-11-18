using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniStore.Forms;
using SQL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
namespace MiniStore.ItemNav
{
    public partial class Order : Form
    {
        DBConnect db;
        SqlDataAdapter da_products;
        DataTable products;
        User user;

        public Order()
        {
            InitializeComponent();
            db = new DBConnect("CongManhPC\\MSSQLSERVER01", "miniMKT");
            user = frm_Login.LoggedInUser;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOrder.SelectedItems.Count > 0)
            {
                btnDecrease.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnDecrease.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            LoadData();
            load_CbCustomer();
            if (listOrder.Items.Count == 0)
            {
                txtMoney.Text = "0";
                btnCancel.Enabled = false;
            }
            string rank = db.getString("SELECT CustomerRank \r\nFROM Customers \r\nWHERE CustomerID = (SELECT MIN(CustomerID) FROM Customers)");
            getDiscount(rank);
            txtEmployess.Text = user.Name;
        }
        void LoadData()
        {
            string sql = "select ProductID,ProductName,Price,Unit from Products where StockQuantity > 0";
            da_products = db.getDataAdapter(sql, "Products");
            products = db.Dset.Tables["Products"];
            dataGridView.DataSource = products;

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = products.Columns["ProductID"];
            products.PrimaryKey = primaryKey;
            dataGridView.Columns["ProductID"].HeaderText = "Mã sản phẩm";
            dataGridView.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            dataGridView.Columns["Price"].HeaderText = "Giá";
            dataGridView.Columns["Unit"].HeaderText = "Đơn vị tính";

            // Center the header text
            dataGridView.Columns["ProductID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["ProductName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Unit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView.Columns["ProductID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.Columns["ProductID"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dataGridView.Columns["ProductName"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dataGridView.Columns["Price"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dataGridView.Columns["Unit"].HeaderCell.Style.WrapMode = DataGridViewTriState.False;

            btnDecrease.Enabled = false;
            btnDelete.Enabled = false;

        }
        void load_CbCustomer()
        {
            string sql = "SELECT * FROM Customers";
            cbCustomer.DataSource = db.getDataTable(sql, "Customers");
            cbCustomer.DisplayMember = "CustomerName";
            cbCustomer.ValueMember = "CustomerID";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Extract data from the selected row
                string maSP = selectedRow.Cells["ProductID"].Value.ToString();
                string tenSP = selectedRow.Cells["ProductName"].Value.ToString();
                string giaTien = selectedRow.Cells["Price"].Value.ToString();
                string unit = selectedRow.Cells["Unit"].Value.ToString();
                string soLuong = "1"; // Default quantity is 1

                // Check if the product already exists in the listOrder
                bool productExists = false;
                for (int i = 0; i < listOrder.Items.Count; i++)
                {
                    string item = listOrder.Items[i].ToString();
                    if (item.Contains($"Mã SP: {maSP} -"))
                    {
                        // Extract the current quantity
                        string[] itemParts = item.Split('-');
                        string quantityPart = itemParts[itemParts.Length - 1].Split(' ')[1].Trim();
                        int currentQuantity = int.Parse(quantityPart);
                        currentQuantity += 1;


                        // Update the item with the new quantity
                        listOrder.Items[i] = $"Mã SP: {maSP} - Tên SP: {tenSP} - Giá: {giaTien}đ - {currentQuantity} {unit}";
                        productExists = true;
                        break;
                    }
                }

                if (!productExists)
                {
                    string itemText = $"Mã SP: {maSP} - Tên SP: {tenSP} - Giá: {giaTien}đ - {soLuong} {unit}";
                    listOrder.Items.Add(itemText);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to add.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (listOrder.Items.Count > 0)
            {
                btnDelete.Enabled = true;
                btnCancel.Enabled = true;
            }

            getTotal();
            txtMoney.Text = getTotal() + "đ";

        }
        string getTotal()
        {
            decimal total = 0;

            for (int i = 0; i < listOrder.Items.Count; i++)
            {
                string item = listOrder.Items[i].ToString();
                // Extract the price part
                string[] itemParts = item.Split('-');
                string pricePart = itemParts.FirstOrDefault(part => part.Trim().StartsWith("Giá:"));
                if (pricePart != null)
                {
                    // Extract the numeric value from the price part
                    string priceString = pricePart.Trim().Substring(5).Trim();
                    string numericValue = new string(priceString.TakeWhile(c => char.IsDigit(c) || c == '.').ToArray());

                    // Extract the quantity part
                    string quantityPart = itemParts[itemParts.Length - 1].Split(' ')[1].Trim();
                    int quantity = int.Parse(quantityPart);

                    // Calculate the total price for this item
                    decimal price = decimal.Parse(numericValue);
                    total += price * quantity;
                }
            }
            return total.ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn hủy sản phẩm không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (listOrder.SelectedItem != null)
                {
                    listOrder.Items.Remove(listOrder.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Cần chọn sản phẩm để gỡ.", "Chưa sản phẩm được chọn", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            if (listOrder.Items.Count == 0)
            {
                btnDelete.Enabled = false;
                txtDiscount.Text = "";
            }

            txtMoney.Text = getTotal() + "đ";

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa gọi món không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                listOrder.Items.Clear();
                txtMoney.Text = "0";
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(getTotal());
            decimal sell = 0;
            string rank = db.getString(string.Format("SELECT CustomerRank FROM Customers WHERE CustomerID = N'{0}' ", cbCustomer.SelectedValue));
            switch (rank)
            {
                case "Bạc":
                    sell = 5;
                    break;
                case "Vàng":
                    sell = 7;
                    break;
                case "Kim cương":
                    sell = 10;
                    break;
                default:
                    break;
            }
            if (!string.IsNullOrEmpty(txtDiscount.Text))
            {
                total *= ((100 - sell) / 100);

            }

            if (string.IsNullOrEmpty(txtReceive.Text))
            {
                MessageBox.Show("Nhân viên chưa nhập tiền khách đưa !!", "Chưa nhập tiền", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if (int.Parse(txtReceive.Text) < total)
            {
                MessageBox.Show("Tiền nhận không đủ !!", "Chưa đủ tiền", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            MessageBox.Show("Thanh toán thành công !!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            txtReturnPayment.Text = (int.Parse(txtReceive.Text) - Math.Round(total, MidpointRounding.AwayFromZero)).ToString() + "đ";
            lblTotalMoney.Text = Math.Round(total, MidpointRounding.AwayFromZero).ToString() + "đ";

            string query = string.Format(
                "INSERT INTO Orders (CustomerID,EmployeeID,OrderDate,TotalAmount,PaymentMethod)" +
                " VALUES ({0},{1},'{2}',{3},N'{4}')", cbCustomer.SelectedValue, user.Id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), total.ToString(), "Tiền mặt");
            db.updateToDataBase(query);
            int orderID = db.getInt("SELECT MAX(OrderID) FROM Orders");

            foreach (string item in listOrder.Items)
            {
                string[] itemParts = item.Split('-');
                string quantityPart = itemParts[itemParts.Length - 1].Split(' ')[1].Trim();
                int currentQuantity = int.Parse(quantityPart);
                string productID = itemParts[0].Split(':')[1].Trim();
                string quantity = itemParts[itemParts.Length - 1].Split(' ')[1].Trim();
                string price = itemParts[itemParts.Length - 2].Split(':')[1].Trim().Replace("đ", "").Trim();

                query = string.Format("UPDATE Products SET StockQuantity = StockQuantity - {0} WHERE ProductID = {1}", quantity, productID);
                db.updateToDataBase(query);

                query = string.Format(
                "INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Price)" +
                " VALUES ({0}, {1}, {2}, {3})", orderID, productID, quantity, price);
                db.updateToDataBase(query);
            }
            listOrder.Items.Clear();
            txtDiscount.Clear();
            txtReceive.Clear();
            txtMoney.Clear();
            txtReturnPayment.Clear();
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = txtSearch.Text;
            string sql = "SELECT ProductID,ProductName,Price,Unit FROM Products WHERE ProductName LIKE @searchString";

            using (SqlConnection connection = new SqlConnection(db.strConnect))
            {
                SqlDataAdapter da_products = new SqlDataAdapter(sql, connection);
                da_products.SelectCommand.Parameters.AddWithValue("@searchString", "%" + searchString + "%");

                DataTable products = new DataTable();
                da_products.Fill(products);
                dataGridView.DataSource = products;
            }
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtReceive_TextChanged(object sender, EventArgs e)
        {

            decimal total = decimal.Parse(getTotal());
            if (string.IsNullOrEmpty(txtReceive.Text))
            {
                txtReturnPayment.Text = "";
                lblTotalMoney.Text = "";
                return;
            }
            txtReturnPayment.Text = (int.Parse(txtReceive.Text) - Math.Round(total, MidpointRounding.AwayFromZero)).ToString() + "đ";
            lblTotalMoney.Text = Math.Round(total, MidpointRounding.AwayFromZero).ToString() + "đ";
        }

        private void txtReceive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtReturnPayment_TextChanged(object sender, EventArgs e)
        {

        }
        void getDiscount(string rank)
        {
            decimal sell = 0;
            switch (rank)
            {
                case "Bạc":
                    sell = 2;
                    break;
                case "Vàng":
                    sell = 5;
                    break;
                case "Kim cương":
                    sell = 7;
                    break;
                default:
                    sell = 0;
                    break;
            }
            txtDiscount.Text = sell.ToString() + "%";
        }
        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedValue != null && cbCustomer.SelectedValue is DataRowView == false)
            {
                string customerId = cbCustomer.SelectedValue.ToString();
                string rank = db.getString(string.Format("SELECT CustomerRank FROM Customers WHERE CustomerID = N'{0}' ", customerId));

                getDiscount(rank);
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.ShowDialog();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (listOrder.SelectedItem != null)
            {
                // Get the selected item
                string selectedItem = listOrder.SelectedItem.ToString();
                int index = listOrder.SelectedIndex;

                // Extract the current quantity
                string[] itemParts = selectedItem.Split('-');
                string quantityPart = itemParts[itemParts.Length - 1].Split(' ')[1].Trim();
                int currentQuantity = int.Parse(quantityPart);

                // Decrease the quantity by 1
                currentQuantity -= 1;

                if (currentQuantity > 0)
                {
                    // Update the item with the new quantity
                    itemParts[itemParts.Length - 1] = $" {currentQuantity} {itemParts[itemParts.Length - 1].Split(' ')[2].Trim()}";
                    listOrder.Items[index] = string.Join("-", itemParts);
                }
                else
                {
                    // Remove the item if the quantity is 0
                    listOrder.Items.RemoveAt(index);
                }

                // Update the total amount
                txtMoney.Text = getTotal() + "đ";
            }
            else if (listOrder.Items.Count == 0)
            {
                btnDecrease.Enabled = false;
            }
            else
            {
                MessageBox.Show("Cần chọn sản phẩm để giảm số lượng.", "Chưa sản phẩm được chọn", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}

