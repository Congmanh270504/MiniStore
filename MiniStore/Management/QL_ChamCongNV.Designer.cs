namespace MiniStore.Management
{
    partial class QL_ChamCongNV
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblBoPhan = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCongChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTinhLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoPhanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChamCongID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_DSChamCong = new System.Windows.Forms.DataGridView();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btn_HienThi);
            this.grpThongTin.Controls.Add(this.dtpThang);
            this.grpThongTin.Controls.Add(this.cmbBoPhan);
            this.grpThongTin.Controls.Add(this.lblThang);
            this.grpThongTin.Controls.Add(this.lblBoPhan);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(850, 100);
            this.grpThongTin.TabIndex = 71;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chấm công";
            // 
            // dtpThang
            // 
            this.dtpThang.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(434, 42);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(165, 27);
            this.dtpThang.TabIndex = 3;
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoPhan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(186, 41);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(186, 28);
            this.cmbBoPhan.TabIndex = 2;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(378, 45);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(50, 20);
            this.lblThang.TabIndex = 1;
            this.lblThang.Text = "Tháng";
            // 
            // lblBoPhan
            // 
            this.lblBoPhan.AutoSize = true;
            this.lblBoPhan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoPhan.Location = new System.Drawing.Point(116, 45);
            this.lblBoPhan.Name = "lblBoPhan";
            this.lblBoPhan.Size = new System.Drawing.Size(64, 20);
            this.lblBoPhan.TabIndex = 0;
            this.lblBoPhan.Text = "Bộ phận";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dataGridView_DSChamCong);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpDanhSach.Location = new System.Drawing.Point(12, 125);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(850, 387);
            this.grpDanhSach.TabIndex = 80;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách chấm công";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // NgayCongChuan
            // 
            this.NgayCongChuan.DataPropertyName = "NgayCongChuan";
            this.NgayCongChuan.HeaderText = "Ngày công chuẩn";
            this.NgayCongChuan.Name = "NgayCongChuan";
            // 
            // NgayDiLam
            // 
            this.NgayDiLam.DataPropertyName = "NgayDiLam";
            this.NgayDiLam.HeaderText = "Ngày đi làm";
            this.NgayDiLam.Name = "NgayDiLam";
            // 
            // NgayNghi
            // 
            this.NgayNghi.DataPropertyName = "NgayNghi";
            this.NgayNghi.HeaderText = "Ngày nghỉ";
            this.NgayNghi.Name = "NgayNghi";
            // 
            // NgayTinhLuong
            // 
            this.NgayTinhLuong.DataPropertyName = "NgayTinhLuong";
            this.NgayTinhLuong.HeaderText = "Ngày tính lương";
            this.NgayTinhLuong.Name = "NgayTinhLuong";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BoPhanID
            // 
            this.BoPhanID.DataPropertyName = "BoPhanID";
            this.BoPhanID.HeaderText = "BoPhanID";
            this.BoPhanID.Name = "BoPhanID";
            this.BoPhanID.Visible = false;
            // 
            // NhanVienID
            // 
            this.NhanVienID.DataPropertyName = "NhanVienID";
            this.NhanVienID.HeaderText = "NhanVienID";
            this.NhanVienID.Name = "NhanVienID";
            this.NhanVienID.Visible = false;
            // 
            // ChamCongID
            // 
            this.ChamCongID.DataPropertyName = "ChamCongID";
            this.ChamCongID.HeaderText = "ChamCongID";
            this.ChamCongID.Name = "ChamCongID";
            this.ChamCongID.Visible = false;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Thang";
            this.Thang.Name = "Thang";
            this.Thang.Visible = false;
            // 
            // dataGridView_DSChamCong
            // 
            this.dataGridView_DSChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DSChamCong.Location = new System.Drawing.Point(7, 29);
            this.dataGridView_DSChamCong.Name = "dataGridView_DSChamCong";
            this.dataGridView_DSChamCong.Size = new System.Drawing.Size(837, 352);
            this.dataGridView_DSChamCong.TabIndex = 0;
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_HienThi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HienThi.ForeColor = System.Drawing.Color.White;
            this.btn_HienThi.Location = new System.Drawing.Point(628, 35);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(126, 45);
            this.btn_HienThi.TabIndex = 80;
            this.btn_HienThi.Text = "HIỂN THỊ";
            this.btn_HienThi.UseVisualStyleBackColor = false;
            // 
            // QL_ChamCongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 524);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpThongTin);
            this.Name = "QL_ChamCongNV";
            this.Text = "CHẨM CÔNG NHÂN VIÊN";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DSChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.ComboBox cmbBoPhan;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblBoPhan;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCongChuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTinhLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoPhanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChamCongID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridView dataGridView_DSChamCong;
        private System.Windows.Forms.Button btn_HienThi;
    }
}