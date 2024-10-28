namespace MiniStore.Management
{
    partial class QL_BangLuong
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
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.lbl_Thang = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTietBanKeLuongID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCongChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTinhLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThucLinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_DSLuong = new System.Windows.Forms.DataGridView();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_TinhLuong = new System.Windows.Forms.Button();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpThang
            // 
            this.dtpThang.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(68, 22);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(165, 27);
            this.dtpThang.TabIndex = 5;
            // 
            // lbl_Thang
            // 
            this.lbl_Thang.AutoSize = true;
            this.lbl_Thang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thang.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_Thang.Location = new System.Drawing.Point(12, 25);
            this.lbl_Thang.Name = "lbl_Thang";
            this.lbl_Thang.Size = new System.Drawing.Size(53, 20);
            this.lbl_Thang.TabIndex = 4;
            this.lbl_Thang.Text = "Tháng";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dataGridView_DSLuong);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpDanhSach.Location = new System.Drawing.Point(16, 72);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(850, 404);
            this.grpDanhSach.TabIndex = 86;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách lương";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 58;
            // 
            // ChiTietBanKeLuongID
            // 
            this.ChiTietBanKeLuongID.DataPropertyName = "ChiTietBanKeLuongID";
            this.ChiTietBanKeLuongID.HeaderText = "ChiTietBanKeLuongID";
            this.ChiTietBanKeLuongID.Name = "ChiTietBanKeLuongID";
            this.ChiTietBanKeLuongID.Visible = false;
            this.ChiTietBanKeLuongID.Width = 194;
            // 
            // NhanVienID
            // 
            this.NhanVienID.DataPropertyName = "NhanVienID";
            this.NhanVienID.HeaderText = "NhanVienID";
            this.NhanVienID.Name = "NhanVienID";
            this.NhanVienID.Visible = false;
            this.NhanVienID.Width = 121;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 60;
            // 
            // NgayCongChuan
            // 
            this.NgayCongChuan.DataPropertyName = "NgayCongChuan";
            this.NgayCongChuan.HeaderText = "Ngày công chuẩn";
            this.NgayCongChuan.Name = "NgayCongChuan";
            this.NgayCongChuan.ReadOnly = true;
            this.NgayCongChuan.Width = 147;
            // 
            // NgayTinhLuong
            // 
            this.NgayTinhLuong.DataPropertyName = "NgayTinhLuong";
            this.NgayTinhLuong.HeaderText = "Ngày tính lương";
            this.NgayTinhLuong.Name = "NgayTinhLuong";
            this.NgayTinhLuong.ReadOnly = true;
            this.NgayTinhLuong.Width = 139;
            // 
            // TienLuong
            // 
            this.TienLuong.DataPropertyName = "TienLuong";
            this.TienLuong.HeaderText = "Tiền lương cứng";
            this.TienLuong.Name = "TienLuong";
            this.TienLuong.ReadOnly = true;
            this.TienLuong.Width = 141;
            // 
            // PhuCap
            // 
            this.PhuCap.DataPropertyName = "PhuCap";
            this.PhuCap.HeaderText = "Phụ cấp";
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.ReadOnly = true;
            this.PhuCap.Width = 85;
            // 
            // TongLuong
            // 
            this.TongLuong.DataPropertyName = "TongLuong";
            this.TongLuong.HeaderText = "Tổng lương";
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.ReadOnly = true;
            this.TongLuong.Width = 110;
            // 
            // ThucLinh
            // 
            this.ThucLinh.DataPropertyName = "ThucLinh";
            this.ThucLinh.HeaderText = "Thực lĩnh";
            this.ThucLinh.Name = "ThucLinh";
            this.ThucLinh.ReadOnly = true;
            this.ThucLinh.Width = 93;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.Width = 98;
            // 
            // dataGridView_DSLuong
            // 
            this.dataGridView_DSLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSLuong.Location = new System.Drawing.Point(7, 29);
            this.dataGridView_DSLuong.Name = "dataGridView_DSLuong";
            this.dataGridView_DSLuong.Size = new System.Drawing.Size(837, 369);
            this.dataGridView_DSLuong.TabIndex = 0;
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_HienThi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThi.ForeColor = System.Drawing.Color.White;
            this.btn_HienThi.Location = new System.Drawing.Point(517, 15);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(126, 45);
            this.btn_HienThi.TabIndex = 89;
            this.btn_HienThi.Text = "HIỂN THỊ";
            this.btn_HienThi.UseVisualStyleBackColor = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(385, 15);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(126, 45);
            this.btn_Luu.TabIndex = 88;
            this.btn_Luu.Text = "LƯU";
            this.btn_Luu.UseVisualStyleBackColor = false;
            // 
            // btn_TinhLuong
            // 
            this.btn_TinhLuong.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_TinhLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TinhLuong.ForeColor = System.Drawing.Color.White;
            this.btn_TinhLuong.Location = new System.Drawing.Point(249, 15);
            this.btn_TinhLuong.Name = "btn_TinhLuong";
            this.btn_TinhLuong.Size = new System.Drawing.Size(126, 45);
            this.btn_TinhLuong.TabIndex = 87;
            this.btn_TinhLuong.Text = "TÍNH LƯƠNG";
            this.btn_TinhLuong.UseVisualStyleBackColor = false;
            // 
            // QL_BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 486);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_TinhLuong);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.dtpThang);
            this.Controls.Add(this.lbl_Thang);
            this.Name = "QL_BangLuong";
            this.Text = "BẢNG LƯƠNG NHÂN VIÊN";
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Label lbl_Thang;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTietBanKeLuongID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCongChuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTinhLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThucLinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridView dataGridView_DSLuong;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_TinhLuong;
    }
}