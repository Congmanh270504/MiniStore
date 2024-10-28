namespace MiniStore.Forms
{
    partial class frm_UserPermission
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
            this.grpb_thongtin = new System.Windows.Forms.GroupBox();
            this.cmbNguoiDung = new System.Windows.Forms.ComboBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.lbl_tendangnhap = new System.Windows.Forms.Label();
            this.lbl_nhanvien = new System.Windows.Forms.Label();
            this.lbl_bophan = new System.Windows.Forms.Label();
            this.grpb_phanquyen = new System.Windows.Forms.GroupBox();
            this.cbGoiMon = new System.Windows.Forms.CheckBox();
            this.cbTienLuong = new System.Windows.Forms.CheckBox();
            this.cbSanPham = new System.Windows.Forms.CheckBox();
            this.cbThongKe = new System.Windows.Forms.CheckBox();
            this.cbNhanSu = new System.Windows.Forms.CheckBox();
            this.cbDanhMuc = new System.Windows.Forms.CheckBox();
            this.cbHeThong = new System.Windows.Forms.CheckBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.grpb_thongtin.SuspendLayout();
            this.grpb_phanquyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpb_thongtin
            // 
            this.grpb_thongtin.Controls.Add(this.cmbNguoiDung);
            this.grpb_thongtin.Controls.Add(this.cmbNhanVien);
            this.grpb_thongtin.Controls.Add(this.cmbBoPhan);
            this.grpb_thongtin.Controls.Add(this.lbl_tendangnhap);
            this.grpb_thongtin.Controls.Add(this.lbl_nhanvien);
            this.grpb_thongtin.Controls.Add(this.lbl_bophan);
            this.grpb_thongtin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_thongtin.ForeColor = System.Drawing.Color.SlateGray;
            this.grpb_thongtin.Location = new System.Drawing.Point(22, 12);
            this.grpb_thongtin.Name = "grpb_thongtin";
            this.grpb_thongtin.Size = new System.Drawing.Size(355, 146);
            this.grpb_thongtin.TabIndex = 1;
            this.grpb_thongtin.TabStop = false;
            this.grpb_thongtin.Text = "Thông tin";
            // 
            // cmbNguoiDung
            // 
            this.cmbNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNguoiDung.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNguoiDung.FormattingEnabled = true;
            this.cmbNguoiDung.Location = new System.Drawing.Point(122, 100);
            this.cmbNguoiDung.Name = "cmbNguoiDung";
            this.cmbNguoiDung.Size = new System.Drawing.Size(216, 28);
            this.cmbNguoiDung.TabIndex = 75;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(122, 66);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(216, 28);
            this.cmbNhanVien.TabIndex = 75;
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoPhan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(122, 32);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(216, 28);
            this.cmbBoPhan.TabIndex = 76;
            // 
            // lbl_tendangnhap
            // 
            this.lbl_tendangnhap.AutoSize = true;
            this.lbl_tendangnhap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tendangnhap.Location = new System.Drawing.Point(9, 103);
            this.lbl_tendangnhap.Name = "lbl_tendangnhap";
            this.lbl_tendangnhap.Size = new System.Drawing.Size(107, 20);
            this.lbl_tendangnhap.TabIndex = 73;
            this.lbl_tendangnhap.Text = "Tên đăng nhập";
            // 
            // lbl_nhanvien
            // 
            this.lbl_nhanvien.AutoSize = true;
            this.lbl_nhanvien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhanvien.Location = new System.Drawing.Point(9, 69);
            this.lbl_nhanvien.Name = "lbl_nhanvien";
            this.lbl_nhanvien.Size = new System.Drawing.Size(75, 20);
            this.lbl_nhanvien.TabIndex = 73;
            this.lbl_nhanvien.Text = "Nhân viên";
            // 
            // lbl_bophan
            // 
            this.lbl_bophan.AutoSize = true;
            this.lbl_bophan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bophan.Location = new System.Drawing.Point(9, 35);
            this.lbl_bophan.Name = "lbl_bophan";
            this.lbl_bophan.Size = new System.Drawing.Size(64, 20);
            this.lbl_bophan.TabIndex = 74;
            this.lbl_bophan.Text = "Bộ phận";
            // 
            // grpb_phanquyen
            // 
            this.grpb_phanquyen.Controls.Add(this.cbGoiMon);
            this.grpb_phanquyen.Controls.Add(this.cbTienLuong);
            this.grpb_phanquyen.Controls.Add(this.cbSanPham);
            this.grpb_phanquyen.Controls.Add(this.cbThongKe);
            this.grpb_phanquyen.Controls.Add(this.cbNhanSu);
            this.grpb_phanquyen.Controls.Add(this.cbDanhMuc);
            this.grpb_phanquyen.Controls.Add(this.cbHeThong);
            this.grpb_phanquyen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_phanquyen.ForeColor = System.Drawing.Color.SlateGray;
            this.grpb_phanquyen.Location = new System.Drawing.Point(22, 164);
            this.grpb_phanquyen.Name = "grpb_phanquyen";
            this.grpb_phanquyen.Size = new System.Drawing.Size(355, 170);
            this.grpb_phanquyen.TabIndex = 2;
            this.grpb_phanquyen.TabStop = false;
            this.grpb_phanquyen.Text = "Phân Quyền";
            // 
            // cbGoiMon
            // 
            this.cbGoiMon.AccessibleDescription = "6";
            this.cbGoiMon.AutoSize = true;
            this.cbGoiMon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGoiMon.Location = new System.Drawing.Point(171, 98);
            this.cbGoiMon.Name = "cbGoiMon";
            this.cbGoiMon.Size = new System.Drawing.Size(85, 24);
            this.cbGoiMon.TabIndex = 0;
            this.cbGoiMon.Text = "Gọi món";
            this.cbGoiMon.UseVisualStyleBackColor = true;
            // 
            // cbTienLuong
            // 
            this.cbTienLuong.AccessibleDescription = "3";
            this.cbTienLuong.AutoSize = true;
            this.cbTienLuong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTienLuong.Location = new System.Drawing.Point(24, 128);
            this.cbTienLuong.Name = "cbTienLuong";
            this.cbTienLuong.Size = new System.Drawing.Size(150, 24);
            this.cbTienLuong.TabIndex = 0;
            this.cbTienLuong.Text = "Quản lý tiền lương";
            this.cbTienLuong.UseVisualStyleBackColor = true;
            // 
            // cbSanPham
            // 
            this.cbSanPham.AccessibleDescription = "5";
            this.cbSanPham.AutoSize = true;
            this.cbSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSanPham.Location = new System.Drawing.Point(24, 98);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(146, 24);
            this.cbSanPham.TabIndex = 0;
            this.cbSanPham.Text = "Quản lý sản phẩm";
            this.cbSanPham.UseVisualStyleBackColor = true;
            // 
            // cbThongKe
            // 
            this.cbThongKe.AccessibleDescription = "4";
            this.cbThongKe.AutoSize = true;
            this.cbThongKe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThongKe.Location = new System.Drawing.Point(171, 68);
            this.cbThongKe.Name = "cbThongKe";
            this.cbThongKe.Size = new System.Drawing.Size(153, 24);
            this.cbThongKe.TabIndex = 0;
            this.cbThongKe.Text = "Thống kê -báo cáo";
            this.cbThongKe.UseVisualStyleBackColor = true;
            // 
            // cbNhanSu
            // 
            this.cbNhanSu.AccessibleDescription = "2";
            this.cbNhanSu.AutoSize = true;
            this.cbNhanSu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanSu.ForeColor = System.Drawing.Color.SlateGray;
            this.cbNhanSu.Location = new System.Drawing.Point(24, 68);
            this.cbNhanSu.Name = "cbNhanSu";
            this.cbNhanSu.Size = new System.Drawing.Size(133, 24);
            this.cbNhanSu.TabIndex = 0;
            this.cbNhanSu.Text = "Quản lý nhân sự";
            this.cbNhanSu.UseVisualStyleBackColor = true;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.AccessibleDescription = "7";
            this.cbDanhMuc.AutoSize = true;
            this.cbDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.Location = new System.Drawing.Point(171, 38);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(147, 24);
            this.cbDanhMuc.TabIndex = 0;
            this.cbDanhMuc.Text = "Quản lý danh mục";
            this.cbDanhMuc.UseVisualStyleBackColor = true;
            // 
            // cbHeThong
            // 
            this.cbHeThong.AccessibleDescription = "1";
            this.cbHeThong.AutoSize = true;
            this.cbHeThong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHeThong.Location = new System.Drawing.Point(24, 38);
            this.cbHeThong.Name = "cbHeThong";
            this.cbHeThong.Size = new System.Drawing.Size(141, 24);
            this.cbHeThong.TabIndex = 0;
            this.cbHeThong.Text = "Quản lý hệ thống";
            this.cbHeThong.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_luu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_luu.Location = new System.Drawing.Point(280, 340);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(97, 40);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "LƯU";
            this.btn_luu.UseVisualStyleBackColor = false;
            // 
            // frm_UserPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 391);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.grpb_phanquyen);
            this.Controls.Add(this.grpb_thongtin);
            this.Name = "frm_UserPermission";
            this.Text = "PHÂN QUYỀN NGƯỜI DÙNG";
            this.grpb_thongtin.ResumeLayout(false);
            this.grpb_thongtin.PerformLayout();
            this.grpb_phanquyen.ResumeLayout(false);
            this.grpb_phanquyen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpb_thongtin;
        private System.Windows.Forms.ComboBox cmbNguoiDung;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.ComboBox cmbBoPhan;
        private System.Windows.Forms.Label lbl_tendangnhap;
        private System.Windows.Forms.Label lbl_nhanvien;
        private System.Windows.Forms.Label lbl_bophan;
        private System.Windows.Forms.GroupBox grpb_phanquyen;
        private System.Windows.Forms.CheckBox cbGoiMon;
        private System.Windows.Forms.CheckBox cbTienLuong;
        private System.Windows.Forms.CheckBox cbSanPham;
        private System.Windows.Forms.CheckBox cbThongKe;
        private System.Windows.Forms.CheckBox cbNhanSu;
        private System.Windows.Forms.CheckBox cbDanhMuc;
        private System.Windows.Forms.CheckBox cbHeThong;
        private System.Windows.Forms.Button btn_luu;
    }
}