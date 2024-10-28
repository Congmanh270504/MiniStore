namespace MiniStore.Management
{
    partial class QL_Products
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.NCCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.cb_DVT = new System.Windows.Forms.ComboBox();
            this.cb_LoaiHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.lblTenMonAn = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.lblMaMonAn = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dataGridView_DSMonAn = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTimKiem.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitle.Location = new System.Drawing.Point(217, -32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 21);
            this.lblTitle.TabIndex = 73;
            this.lblTitle.Text = "QUẢN LÝ MÓN ĂN";
            // 
            // NCCID
            // 
            this.NCCID.DataPropertyName = "NCCID";
            this.NCCID.HeaderText = "NCCID";
            this.NCCID.Name = "NCCID";
            this.NCCID.ReadOnly = true;
            this.NCCID.Visible = false;
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
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            this.TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            this.TenNhaCungCap.HeaderText = "Nhà cung cấp";
            this.TenNhaCungCap.Name = "TenNhaCungCap";
            this.TenNhaCungCap.ReadOnly = true;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Giá tiền";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            this.GiamGia.HeaderText = "Giảm giá (%)";
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.btnSearch);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimKiem.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpTimKiem.Location = new System.Drawing.Point(19, 12);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(390, 82);
            this.grpTimKiem.TabIndex = 71;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(274, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(39, 37);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(212, 27);
            this.txtTimKiem.TabIndex = 11;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.cb_DVT);
            this.grpThongTin.Controls.Add(this.cb_LoaiHang);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Controls.Add(this.cmbNhaCungCap);
            this.grpThongTin.Controls.Add(this.label6);
            this.grpThongTin.Controls.Add(this.txtSoLuong);
            this.grpThongTin.Controls.Add(this.lblGiamGia);
            this.grpThongTin.Controls.Add(this.txtGiaTien);
            this.grpThongTin.Controls.Add(this.lblGiaTien);
            this.grpThongTin.Controls.Add(this.lblNhaCungCap);
            this.grpThongTin.Controls.Add(this.txtTenMonAn);
            this.grpThongTin.Controls.Add(this.lblTenMonAn);
            this.grpThongTin.Controls.Add(this.lblSoLuong);
            this.grpThongTin.Controls.Add(this.txtMaMonAn);
            this.grpThongTin.Controls.Add(this.lblMaMonAn);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpThongTin.Location = new System.Drawing.Point(428, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(494, 186);
            this.grpThongTin.TabIndex = 70;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin";
            // 
            // cb_DVT
            // 
            this.cb_DVT.FormattingEnabled = true;
            this.cb_DVT.Location = new System.Drawing.Point(367, 141);
            this.cb_DVT.Name = "cb_DVT";
            this.cb_DVT.Size = new System.Drawing.Size(121, 29);
            this.cb_DVT.TabIndex = 32;
            // 
            // cb_LoaiHang
            // 
            this.cb_LoaiHang.FormattingEnabled = true;
            this.cb_LoaiHang.Location = new System.Drawing.Point(348, 71);
            this.cb_LoaiHang.Name = "cb_LoaiHang";
            this.cb_LoaiHang.Size = new System.Drawing.Size(140, 29);
            this.cb_LoaiHang.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên loại";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(121, 106);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(327, 28);
            this.cmbNhaCungCap.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "VND";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(348, 33);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(140, 27);
            this.txtSoLuong.TabIndex = 26;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiamGia.Location = new System.Drawing.Point(280, 146);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(81, 20);
            this.lblGiamGia.TabIndex = 23;
            this.lblGiamGia.Text = "Đơn vị tính";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(121, 143);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(110, 27);
            this.txtGiaTien.TabIndex = 22;
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(15, 146);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(60, 20);
            this.lblGiaTien.TabIndex = 21;
            this.lblGiaTien.Text = "Giá tiền";
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCungCap.Location = new System.Drawing.Point(15, 109);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(100, 20);
            this.lblNhaCungCap.TabIndex = 19;
            this.lblNhaCungCap.Text = "Nhà cung cấp";
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonAn.Location = new System.Drawing.Point(121, 71);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(146, 27);
            this.txtTenMonAn.TabIndex = 10;
            // 
            // lblTenMonAn
            // 
            this.lblTenMonAn.AutoSize = true;
            this.lblTenMonAn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMonAn.Location = new System.Drawing.Point(15, 73);
            this.lblTenMonAn.Name = "lblTenMonAn";
            this.lblTenMonAn.Size = new System.Drawing.Size(86, 20);
            this.lblTenMonAn.TabIndex = 9;
            this.lblTenMonAn.Text = "Tên món ăn";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(273, 36);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(69, 20);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonAn.Location = new System.Drawing.Point(121, 33);
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.Size = new System.Drawing.Size(146, 27);
            this.txtMaMonAn.TabIndex = 3;
            // 
            // lblMaMonAn
            // 
            this.lblMaMonAn.AutoSize = true;
            this.lblMaMonAn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMonAn.Location = new System.Drawing.Point(15, 36);
            this.lblMaMonAn.Name = "lblMaMonAn";
            this.lblMaMonAn.Size = new System.Drawing.Size(84, 20);
            this.lblMaMonAn.TabIndex = 2;
            this.lblMaMonAn.Text = "Mã món ăn";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(19, 100);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(126, 45);
            this.btn_Them.TabIndex = 74;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(151, 100);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 45);
            this.btn_Xoa.TabIndex = 75;
            this.btn_Xoa.Text = "XÓA";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(283, 100);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(126, 45);
            this.btn_Sua.TabIndex = 76;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(89, 152);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(121, 46);
            this.btn_Luu.TabIndex = 77;
            this.btn_Luu.Text = "LƯU";
            this.btn_Luu.UseVisualStyleBackColor = false;
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Dong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(226, 152);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(121, 46);
            this.btn_Dong.TabIndex = 78;
            this.btn_Dong.Text = "ĐÓNG";
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dataGridView_DSMonAn);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpDanhSach.Location = new System.Drawing.Point(19, 204);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(921, 346);
            this.grpDanhSach.TabIndex = 79;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách món ăn";
            // 
            // dataGridView_DSMonAn
            // 
            this.dataGridView_DSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSMonAn.Location = new System.Drawing.Point(6, 28);
            this.dataGridView_DSMonAn.Name = "dataGridView_DSMonAn";
            this.dataGridView_DSMonAn.Size = new System.Drawing.Size(897, 307);
            this.dataGridView_DSMonAn.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NCCID";
            this.dataGridViewTextBoxColumn1.HeaderText = "NCCID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaSP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã SP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenSP";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên sản phẩm";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenNhaCungCap";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nhà cung cấp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GiaTien";
            this.dataGridViewTextBoxColumn5.HeaderText = "Giá tiền";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GiamGia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Giảm giá (%)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn7.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // QL_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 551);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpThongTin);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "QL_Products";
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.Load += new System.EventHandler(this.QL_Food_Load);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.Label lblTenMonAn;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.Label lblMaMonAn;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dataGridView_DSMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cb_DVT;
        private System.Windows.Forms.ComboBox cb_LoaiHang;
        private System.Windows.Forms.Label label1;
    }
}