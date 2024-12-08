namespace MiniStore.Management
{
    partial class QL_HoaDon
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
            this.lbl_hoadon = new System.Windows.Forms.Label();
            this.lbl_mahd = new System.Windows.Forms.Label();
            this.lbl_makh = new System.Windows.Forms.Label();
            this.lbl_phuongthuctt = new System.Windows.Forms.Label();
            this.cbb_phuongthuctt = new System.Windows.Forms.ComboBox();
            this.lbl_tongtien = new System.Windows.Forms.Label();
            this.lbl_ngaythanhtoan = new System.Windows.Forms.Label();
            this.lbl_nhanvientt = new System.Windows.Forms.Label();
            this.txtb_mahoadon = new System.Windows.Forms.TextBox();
            this.txtb_makh = new System.Windows.Forms.TextBox();
            this.txtb_nvthanhtoan = new System.Windows.Forms.TextBox();
            this.mtxtb_ngaythanhtoan = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtb_tongtien = new System.Windows.Forms.TextBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_hoadon
            // 
            this.lbl_hoadon.AutoSize = true;
            this.lbl_hoadon.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoadon.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_hoadon.Location = new System.Drawing.Point(280, 9);
            this.lbl_hoadon.Name = "lbl_hoadon";
            this.lbl_hoadon.Size = new System.Drawing.Size(175, 45);
            this.lbl_hoadon.TabIndex = 0;
            this.lbl_hoadon.Text = "HÓA ĐƠN";
            // 
            // lbl_mahd
            // 
            this.lbl_mahd.AutoSize = true;
            this.lbl_mahd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mahd.Location = new System.Drawing.Point(58, 72);
            this.lbl_mahd.Name = "lbl_mahd";
            this.lbl_mahd.Size = new System.Drawing.Size(86, 17);
            this.lbl_mahd.TabIndex = 1;
            this.lbl_mahd.Text = "Mã Hóa Đơn:";
            // 
            // lbl_makh
            // 
            this.lbl_makh.AutoSize = true;
            this.lbl_makh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_makh.Location = new System.Drawing.Point(40, 121);
            this.lbl_makh.Name = "lbl_makh";
            this.lbl_makh.Size = new System.Drawing.Size(104, 17);
            this.lbl_makh.TabIndex = 2;
            this.lbl_makh.Text = "Mã Khách Hàng:";
            // 
            // lbl_phuongthuctt
            // 
            this.lbl_phuongthuctt.AutoSize = true;
            this.lbl_phuongthuctt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phuongthuctt.Location = new System.Drawing.Point(344, 124);
            this.lbl_phuongthuctt.Name = "lbl_phuongthuctt";
            this.lbl_phuongthuctt.Size = new System.Drawing.Size(159, 17);
            this.lbl_phuongthuctt.TabIndex = 3;
            this.lbl_phuongthuctt.Text = "Phương Thức Thanh Toán:";
            // 
            // cbb_phuongthuctt
            // 
            this.cbb_phuongthuctt.FormattingEnabled = true;
            this.cbb_phuongthuctt.Location = new System.Drawing.Point(509, 121);
            this.cbb_phuongthuctt.Name = "cbb_phuongthuctt";
            this.cbb_phuongthuctt.Size = new System.Drawing.Size(198, 21);
            this.cbb_phuongthuctt.TabIndex = 12;
            // 
            // lbl_tongtien
            // 
            this.lbl_tongtien.AutoSize = true;
            this.lbl_tongtien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongtien.Location = new System.Drawing.Point(438, 610);
            this.lbl_tongtien.Name = "lbl_tongtien";
            this.lbl_tongtien.Size = new System.Drawing.Size(90, 21);
            this.lbl_tongtien.TabIndex = 5;
            this.lbl_tongtien.Text = "Tổng Tiền:";
            // 
            // lbl_ngaythanhtoan
            // 
            this.lbl_ngaythanhtoan.AutoSize = true;
            this.lbl_ngaythanhtoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaythanhtoan.Location = new System.Drawing.Point(27, 165);
            this.lbl_ngaythanhtoan.Name = "lbl_ngaythanhtoan";
            this.lbl_ngaythanhtoan.Size = new System.Drawing.Size(113, 17);
            this.lbl_ngaythanhtoan.TabIndex = 6;
            this.lbl_ngaythanhtoan.Text = "Ngày Thanh Toán:";
            // 
            // lbl_nhanvientt
            // 
            this.lbl_nhanvientt.AutoSize = true;
            this.lbl_nhanvientt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhanvientt.Location = new System.Drawing.Point(344, 72);
            this.lbl_nhanvientt.Name = "lbl_nhanvientt";
            this.lbl_nhanvientt.Size = new System.Drawing.Size(142, 17);
            this.lbl_nhanvientt.TabIndex = 7;
            this.lbl_nhanvientt.Text = "Nhân Viên Thanh Toán:";
            // 
            // txtb_mahoadon
            // 
            this.txtb_mahoadon.Location = new System.Drawing.Point(150, 72);
            this.txtb_mahoadon.Name = "txtb_mahoadon";
            this.txtb_mahoadon.Size = new System.Drawing.Size(163, 20);
            this.txtb_mahoadon.TabIndex = 8;
            // 
            // txtb_makh
            // 
            this.txtb_makh.Location = new System.Drawing.Point(150, 121);
            this.txtb_makh.Name = "txtb_makh";
            this.txtb_makh.Size = new System.Drawing.Size(163, 20);
            this.txtb_makh.TabIndex = 9;
            // 
            // txtb_nvthanhtoan
            // 
            this.txtb_nvthanhtoan.Location = new System.Drawing.Point(509, 72);
            this.txtb_nvthanhtoan.Name = "txtb_nvthanhtoan";
            this.txtb_nvthanhtoan.Size = new System.Drawing.Size(198, 20);
            this.txtb_nvthanhtoan.TabIndex = 11;
            // 
            // mtxtb_ngaythanhtoan
            // 
            this.mtxtb_ngaythanhtoan.Location = new System.Drawing.Point(150, 162);
            this.mtxtb_ngaythanhtoan.Mask = "00/00/0000";
            this.mtxtb_ngaythanhtoan.Name = "mtxtb_ngaythanhtoan";
            this.mtxtb_ngaythanhtoan.Size = new System.Drawing.Size(163, 20);
            this.mtxtb_ngaythanhtoan.TabIndex = 10;
            this.mtxtb_ngaythanhtoan.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(30, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 296);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn Chi Tiết";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtb_tongtien
            // 
            this.txtb_tongtien.Location = new System.Drawing.Point(534, 611);
            this.txtb_tongtien.Name = "txtb_tongtien";
            this.txtb_tongtien.Size = new System.Drawing.Size(173, 20);
            this.txtb_tongtien.TabIndex = 17;
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Dong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.ForeColor = System.Drawing.Color.White;
            this.btn_Dong.Image = global::MiniStore.Properties.Resources.cancel_32px7;
            this.btn_Dong.Location = new System.Drawing.Point(596, 213);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(111, 46);
            this.btn_Dong.TabIndex = 16;
            this.btn_Dong.Text = "ĐÓNG";
            this.btn_Dong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Dong.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = global::MiniStore.Properties.Resources.edit_file_20px3;
            this.btn_Sua.Location = new System.Drawing.Point(407, 213);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(111, 46);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = global::MiniStore.Properties.Resources.delete_20px3;
            this.btn_Xoa.Location = new System.Drawing.Point(224, 213);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(111, 45);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "XÓA";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = global::MiniStore.Properties.Resources.add_20px2;
            this.btn_Them.Location = new System.Drawing.Point(37, 213);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(113, 45);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // QL_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 643);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txtb_tongtien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtxtb_ngaythanhtoan);
            this.Controls.Add(this.txtb_nvthanhtoan);
            this.Controls.Add(this.txtb_makh);
            this.Controls.Add(this.txtb_mahoadon);
            this.Controls.Add(this.lbl_nhanvientt);
            this.Controls.Add(this.lbl_ngaythanhtoan);
            this.Controls.Add(this.lbl_tongtien);
            this.Controls.Add(this.cbb_phuongthuctt);
            this.Controls.Add(this.lbl_phuongthuctt);
            this.Controls.Add(this.lbl_makh);
            this.Controls.Add(this.lbl_mahd);
            this.Controls.Add(this.lbl_hoadon);
            this.Name = "QL_HoaDon";
            this.Text = "HÓA ĐƠN";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hoadon;
        private System.Windows.Forms.Label lbl_mahd;
        private System.Windows.Forms.Label lbl_makh;
        private System.Windows.Forms.Label lbl_phuongthuctt;
        private System.Windows.Forms.ComboBox cbb_phuongthuctt;
        private System.Windows.Forms.Label lbl_tongtien;
        private System.Windows.Forms.Label lbl_ngaythanhtoan;
        private System.Windows.Forms.Label lbl_nhanvientt;
        private System.Windows.Forms.TextBox txtb_mahoadon;
        private System.Windows.Forms.TextBox txtb_makh;
        private System.Windows.Forms.TextBox txtb_nvthanhtoan;
        private System.Windows.Forms.MaskedTextBox mtxtb_ngaythanhtoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtb_tongtien;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Dong;
    }
}