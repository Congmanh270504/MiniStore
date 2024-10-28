using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL;
namespace MiniStore.ItemNav
{
    public partial class Order : Form
    {
        DBConnect db;
        SqlDataAdapter da_products;
        DataTable products;
        public Order()
        {
            InitializeComponent();
            db = new DBConnect("miniMKT");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = listOrder.SelectedItems.Count > 0;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            LoadData();
            if (listOrder.Items.Count == 0)
            {
                txtMoney.Text = "0";
                btnCancel.Enabled = false;
            }
        }
        void LoadData()
        {
            string sql = "select ProductID,ProductName,Price,Unit from Products";
            da_products = db.getDataAdapter(sql, "Products");
            products = db.Dset.Tables["Products"];
            dataGridView.DataSource = products;

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = products.Columns["ProductID"];
            products.PrimaryKey = primaryKey;
            dataGridView.Columns["ProductID"].HeaderText = "Số thứ tự";
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

        }

        private void grpInfoInvoice_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmployess_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmployess_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

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
            if (!string.IsNullOrEmpty(txtDiscount.Text))
            {
                total *= ((100 - decimal.Parse(txtDiscount.Text)) / 100);
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
            txtReturnPayment.Text = (int.Parse(txtReceive.Text) - total).ToString() + "đ";
            lblTotalMoney.Text = total.ToString() + "đ";
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

