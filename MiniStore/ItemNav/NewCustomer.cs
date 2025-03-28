﻿using SQL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.ItemNav
{
    public partial class NewCustomer : Form
    {
        DBConnect db;
        public NewCustomer()
        {
            InitializeComponent();
            db = new DBConnect( "miniMKT");
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Chưa nhập tên khách hàng !!", "Chưa nhập tên", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if (string.IsNullOrEmpty(tbNumberPhone.Text))
            {
                MessageBox.Show("Chưa nhập sđt khách hàng !!", "Chưa nhập sđt", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                MessageBox.Show("Chưa nhập địa chỉ khách hàng !!", "Chưa nhập địa chỉ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if (string.IsNullOrEmpty(tb_Email.Text))
            {
                MessageBox.Show("Bạn chưa nhập email khách hàng !!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                tb_Email.Focus();
                return;
            }
            if (!tb_Email.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Email không hợp lệ !!", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            if (db.checkExist(string.Format("select count(*) from Customers where CustomerName = N'{0}'", tbName.Text)))
            {
                MessageBox.Show("Đã tồn tại tên khách hàng !!", "Đã tồn tại khách hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if (!IsValidPhoneNumber(tbNumberPhone.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ !!", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            if (db.checkExist(string.Format("select count(*) from Customers where Phone = '{0}'", tbNumberPhone.Text)))
            {
                if (MessageBox.Show("Số điện thoại khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                {
                    tbNumberPhone.Focus();
                }
                return;
            }
            if (db.checkExist(string.Format("select count(*) from Customers where Email = N'{0}'", tb_Email.Text)))
            {
                if (MessageBox.Show("Email khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) != DialogResult.Cancel)
                {
                    tb_Email.Focus();
                }
                return;
            }

           string query = string.Format("INSERT Customers ( CustomerName, Phone, Email , CustomerRank, CustomerSuppAddress)" +
                                 " VALUES (N'{0}', '{1}', '{2}' , null, N'{3}')", tbName.Text, tbNumberPhone.Text, tb_Email.Text, tbAddress.Text);
            db.updateToDataBase(query);

            MessageBox.Show("Thêm khách hàng thành công !!", "Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            Close();
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression for Vietnamese phone numbers
            string pattern = @"^(03|05|07|08|09)\d{8,9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
