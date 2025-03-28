﻿namespace MiniStore.ItemNav
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtReturnPayment = new System.Windows.Forms.TextBox();
            this.lblReturnPayment = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.lblReceive = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblEmployess = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.grpSearchProduct = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmployess = new System.Windows.Forms.TextBox();
            this.grpListProduct = new System.Windows.Forms.GroupBox();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.grpInfoInvoice = new System.Windows.Forms.GroupBox();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cb_PrintBill = new System.Windows.Forms.CheckBox();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpPayment.SuspendLayout();
            this.grpSearchProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.grpListProduct.SuspendLayout();
            this.grpInfoInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.lblTotalMoney);
            this.grpPayment.Controls.Add(this.lblTotal);
            this.grpPayment.Controls.Add(this.txtReturnPayment);
            this.grpPayment.Controls.Add(this.lblReturnPayment);
            this.grpPayment.Controls.Add(this.txtReceive);
            this.grpPayment.Controls.Add(this.lblReceive);
            this.grpPayment.Controls.Add(this.txtDiscount);
            this.grpPayment.Controls.Add(this.lblDiscount);
            this.grpPayment.Controls.Add(this.txtMoney);
            this.grpPayment.Controls.Add(this.lblMoney);
            this.grpPayment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPayment.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpPayment.Location = new System.Drawing.Point(594, 426);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(505, 155);
            this.grpPayment.TabIndex = 25;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Thanh toán";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.lblTotalMoney.Location = new System.Drawing.Point(164, 125);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(38, 24);
            this.lblTotalMoney.TabIndex = 18;
            this.lblTotalMoney.Text = "0 đ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.lblTotal.Location = new System.Drawing.Point(25, 125);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(144, 24);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "TỔNG CỘNG:";
            // 
            // txtReturnPayment
            // 
            this.txtReturnPayment.Enabled = false;
            this.txtReturnPayment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnPayment.Location = new System.Drawing.Point(301, 82);
            this.txtReturnPayment.Name = "txtReturnPayment";
            this.txtReturnPayment.Size = new System.Drawing.Size(120, 25);
            this.txtReturnPayment.TabIndex = 16;
            this.txtReturnPayment.TextChanged += new System.EventHandler(this.txtReturnPayment_TextChanged);
            // 
            // lblReturnPayment
            // 
            this.lblReturnPayment.AutoSize = true;
            this.lblReturnPayment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnPayment.Location = new System.Drawing.Point(222, 85);
            this.lblReturnPayment.Name = "lblReturnPayment";
            this.lblReturnPayment.Size = new System.Drawing.Size(76, 17);
            this.lblReturnPayment.TabIndex = 15;
            this.lblReturnPayment.Text = "Tiền thừa:";
            // 
            // txtReceive
            // 
            this.txtReceive.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceive.Location = new System.Drawing.Point(98, 82);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(118, 25);
            this.txtReceive.TabIndex = 14;
            this.txtReceive.TextChanged += new System.EventHandler(this.txtReceive_TextChanged);
            this.txtReceive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceive_KeyPress);
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = true;
            this.lblReceive.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceive.Location = new System.Drawing.Point(7, 85);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(83, 17);
            this.lblReceive.TabIndex = 13;
            this.lblReceive.Text = "Khách đưa:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(301, 29);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(120, 25);
            this.txtDiscount.TabIndex = 12;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(222, 33);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(70, 17);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Giảm giá:";
            // 
            // txtMoney
            // 
            this.txtMoney.Enabled = false;
            this.txtMoney.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(98, 30);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(118, 25);
            this.txtMoney.TabIndex = 10;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMoney.Location = new System.Drawing.Point(6, 32);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(83, 17);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "Thành tiền:";
            // 
            // lblEmployess
            // 
            this.lblEmployess.AutoSize = true;
            this.lblEmployess.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployess.Location = new System.Drawing.Point(3, 82);
            this.lblEmployess.Name = "lblEmployess";
            this.lblEmployess.Size = new System.Drawing.Size(79, 17);
            this.lblEmployess.TabIndex = 8;
            this.lblEmployess.Text = "Nhân viên:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(2, 36);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(90, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Khách hàng:";
            // 
            // grpSearchProduct
            // 
            this.grpSearchProduct.Controls.Add(this.btnSearch);
            this.grpSearchProduct.Controls.Add(this.label1);
            this.grpSearchProduct.Controls.Add(this.dataGridView);
            this.grpSearchProduct.Controls.Add(this.txtSearch);
            this.grpSearchProduct.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchProduct.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpSearchProduct.Location = new System.Drawing.Point(5, 9);
            this.grpSearchProduct.Name = "grpSearchProduct";
            this.grpSearchProduct.Size = new System.Drawing.Size(572, 443);
            this.grpSearchProduct.TabIndex = 22;
            this.grpSearchProduct.TabStop = false;
            this.grpSearchProduct.Text = "Chọn món";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(435, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 32);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Tìm ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tìm kiếm";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(7, 61);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(555, 376);
            this.dataGridView.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(124, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(283, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Giá tiền";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            this.GiamGia.HeaderText = "Giảm giá (%)";
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.ReadOnly = true;
            // 
            // txtEmployess
            // 
            this.txtEmployess.Enabled = false;
            this.txtEmployess.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployess.Location = new System.Drawing.Point(102, 83);
            this.txtEmployess.Name = "txtEmployess";
            this.txtEmployess.Size = new System.Drawing.Size(239, 25);
            this.txtEmployess.TabIndex = 10;
            // 
            // grpListProduct
            // 
            this.grpListProduct.Controls.Add(this.listOrder);
            this.grpListProduct.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListProduct.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpListProduct.Location = new System.Drawing.Point(594, 12);
            this.grpListProduct.Name = "grpListProduct";
            this.grpListProduct.Size = new System.Drawing.Size(505, 408);
            this.grpListProduct.TabIndex = 23;
            this.grpListProduct.TabStop = false;
            this.grpListProduct.Text = "Danh sách gọi món";
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 17;
            this.listOrder.Location = new System.Drawing.Point(6, 26);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(493, 361);
            this.listOrder.TabIndex = 0;
            this.listOrder.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grpInfoInvoice
            // 
            this.grpInfoInvoice.Controls.Add(this.btnNewCustomer);
            this.grpInfoInvoice.Controls.Add(this.cbCustomer);
            this.grpInfoInvoice.Controls.Add(this.txtEmployess);
            this.grpInfoInvoice.Controls.Add(this.lblEmployess);
            this.grpInfoInvoice.Controls.Add(this.lblUser);
            this.grpInfoInvoice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoInvoice.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpInfoInvoice.Location = new System.Drawing.Point(5, 458);
            this.grpInfoInvoice.Name = "grpInfoInvoice";
            this.grpInfoInvoice.Size = new System.Drawing.Size(572, 123);
            this.grpInfoInvoice.TabIndex = 24;
            this.grpInfoInvoice.TabStop = false;
            this.grpInfoInvoice.Text = "Thông tin hóa đơn";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(386, 33);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(147, 30);
            this.btnNewCustomer.TabIndex = 12;
            this.btnNewCustomer.Text = "Khách hàng mới";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(102, 33);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(239, 25);
            this.cbCustomer.TabIndex = 11;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // cb_PrintBill
            // 
            this.cb_PrintBill.AutoSize = true;
            this.cb_PrintBill.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PrintBill.Location = new System.Drawing.Point(599, 610);
            this.cb_PrintBill.Name = "cb_PrintBill";
            this.cb_PrintBill.Size = new System.Drawing.Size(84, 19);
            this.cb_PrintBill.TabIndex = 31;
            this.cb_PrintBill.Text = "In hóa đơn";
            this.cb_PrintBill.UseVisualStyleBackColor = true;
            // 
            // btnDecrease
            // 
            this.btnDecrease.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDecrease.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrease.ForeColor = System.Drawing.Color.White;
            this.btnDecrease.Image = global::MiniStore.Properties.Resources.subtract_24px;
            this.btnDecrease.Location = new System.Drawing.Point(188, 588);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(173, 41);
            this.btnDecrease.TabIndex = 36;
            this.btnDecrease.Text = "GIẢM SỐ LƯỢNG";
            this.btnDecrease.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDecrease.UseVisualStyleBackColor = false;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.Red;
            this.btnPay.Image = global::MiniStore.Properties.Resources.money_32px1;
            this.btnPay.Location = new System.Drawing.Point(895, 588);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(132, 41);
            this.btnPay.TabIndex = 35;
            this.btnPay.Text = "TÍNH TIỀN";
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::MiniStore.Properties.Resources.cancel_32px3;
            this.btnCancel.Location = new System.Drawing.Point(735, 588);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 41);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::MiniStore.Properties.Resources.delete_20px2;
            this.btnDelete.Location = new System.Drawing.Point(409, 588);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 41);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "BỎ MÓN";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::MiniStore.Properties.Resources.add_20px;
            this.btnAdd.Location = new System.Drawing.Point(12, 588);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 41);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "THÊM MÓN";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 657);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cb_PrintBill);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpSearchProduct);
            this.Controls.Add(this.grpListProduct);
            this.Controls.Add(this.grpInfoInvoice);
            this.Name = "Order";
            this.Text = "Gọi món";
            this.Load += new System.EventHandler(this.Order_Load);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpSearchProduct.ResumeLayout(false);
            this.grpSearchProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.grpListProduct.ResumeLayout(false);
            this.grpInfoInvoice.ResumeLayout(false);
            this.grpInfoInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtReturnPayment;
        private System.Windows.Forms.Label lblReturnPayment;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.GroupBox grpSearchProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpListProduct;
        private System.Windows.Forms.GroupBox grpInfoInvoice;
        private System.Windows.Forms.TextBox txtEmployess;
        private System.Windows.Forms.Label lblEmployess;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.CheckBox cb_PrintBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnDecrease;
    }
}