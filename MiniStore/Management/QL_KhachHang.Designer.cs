namespace MiniStore.Management
{
    partial class QL_KhachHang
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
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.grpb_ttkh = new System.Windows.Forms.GroupBox();
            this.cbb_hangkh = new System.Windows.Forms.ComboBox();
            this.txtb_sdt = new System.Windows.Forms.TextBox();
            this.txtb_tenkh = new System.Windows.Forms.TextBox();
            this.txtb_makh = new System.Windows.Forms.TextBox();
            this.lbl_sdtkh = new System.Windows.Forms.Label();
            this.lbl_hangkh = new System.Windows.Forms.Label();
            this.lbl_tenkh = new System.Windows.Forms.Label();
            this.lbl_makh = new System.Windows.Forms.Label();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.grpb_ttkh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dataGridView);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpDanhSach.Location = new System.Drawing.Point(12, 214);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(781, 312);
            this.grpDanhSach.TabIndex = 89;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách loại sản phẩm";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(769, 275);
            this.dataGridView.TabIndex = 0;
            // 
            // grpb_ttkh
            // 
            this.grpb_ttkh.Controls.Add(this.cbb_hangkh);
            this.grpb_ttkh.Controls.Add(this.txtb_sdt);
            this.grpb_ttkh.Controls.Add(this.txtb_tenkh);
            this.grpb_ttkh.Controls.Add(this.txtb_makh);
            this.grpb_ttkh.Controls.Add(this.lbl_sdtkh);
            this.grpb_ttkh.Controls.Add(this.lbl_hangkh);
            this.grpb_ttkh.Controls.Add(this.lbl_tenkh);
            this.grpb_ttkh.Controls.Add(this.lbl_makh);
            this.grpb_ttkh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_ttkh.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpb_ttkh.Location = new System.Drawing.Point(12, 12);
            this.grpb_ttkh.Name = "grpb_ttkh";
            this.grpb_ttkh.Size = new System.Drawing.Size(781, 144);
            this.grpb_ttkh.TabIndex = 98;
            this.grpb_ttkh.TabStop = false;
            this.grpb_ttkh.Text = "Thông Tin Khách Hàng";
            // 
            // cbb_hangkh
            // 
            this.cbb_hangkh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_hangkh.FormattingEnabled = true;
            this.cbb_hangkh.Location = new System.Drawing.Point(525, 81);
            this.cbb_hangkh.Name = "cbb_hangkh";
            this.cbb_hangkh.Size = new System.Drawing.Size(226, 25);
            this.cbb_hangkh.TabIndex = 113;
            // 
            // txtb_sdt
            // 
            this.txtb_sdt.Location = new System.Drawing.Point(525, 37);
            this.txtb_sdt.Multiline = true;
            this.txtb_sdt.Name = "txtb_sdt";
            this.txtb_sdt.Size = new System.Drawing.Size(226, 24);
            this.txtb_sdt.TabIndex = 112;
            // 
            // txtb_tenkh
            // 
            this.txtb_tenkh.Location = new System.Drawing.Point(145, 78);
            this.txtb_tenkh.Multiline = true;
            this.txtb_tenkh.Name = "txtb_tenkh";
            this.txtb_tenkh.Size = new System.Drawing.Size(226, 24);
            this.txtb_tenkh.TabIndex = 111;
            // 
            // txtb_makh
            // 
            this.txtb_makh.Location = new System.Drawing.Point(145, 33);
            this.txtb_makh.Multiline = true;
            this.txtb_makh.Name = "txtb_makh";
            this.txtb_makh.Size = new System.Drawing.Size(226, 24);
            this.txtb_makh.TabIndex = 110;
            // 
            // lbl_sdtkh
            // 
            this.lbl_sdtkh.AutoSize = true;
            this.lbl_sdtkh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sdtkh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_sdtkh.Location = new System.Drawing.Point(402, 40);
            this.lbl_sdtkh.Name = "lbl_sdtkh";
            this.lbl_sdtkh.Size = new System.Drawing.Size(92, 17);
            this.lbl_sdtkh.TabIndex = 109;
            this.lbl_sdtkh.Text = "Số Điện Thoại:";
            // 
            // lbl_hangkh
            // 
            this.lbl_hangkh.AutoSize = true;
            this.lbl_hangkh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hangkh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_hangkh.Location = new System.Drawing.Point(402, 86);
            this.lbl_hangkh.Name = "lbl_hangkh";
            this.lbl_hangkh.Size = new System.Drawing.Size(116, 17);
            this.lbl_hangkh.TabIndex = 108;
            this.lbl_hangkh.Text = "Hạng Khách Hàng:";
            // 
            // lbl_tenkh
            // 
            this.lbl_tenkh.AutoSize = true;
            this.lbl_tenkh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenkh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tenkh.Location = new System.Drawing.Point(29, 86);
            this.lbl_tenkh.Name = "lbl_tenkh";
            this.lbl_tenkh.Size = new System.Drawing.Size(105, 17);
            this.lbl_tenkh.TabIndex = 107;
            this.lbl_tenkh.Text = "Tên Khách Hàng:";
            // 
            // lbl_makh
            // 
            this.lbl_makh.AutoSize = true;
            this.lbl_makh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_makh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_makh.Location = new System.Drawing.Point(33, 37);
            this.lbl_makh.Name = "lbl_makh";
            this.lbl_makh.Size = new System.Drawing.Size(104, 17);
            this.lbl_makh.TabIndex = 106;
            this.lbl_makh.Text = "Mã Khách Hàng:";
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Dong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.ForeColor = System.Drawing.Color.White;
            this.btn_Dong.Location = new System.Drawing.Point(627, 162);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(121, 46);
            this.btn_Dong.TabIndex = 102;
            this.btn_Dong.Text = "ĐÓNG";
            this.btn_Dong.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(442, 162);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(126, 45);
            this.btn_Sua.TabIndex = 101;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(257, 162);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 45);
            this.btn_Xoa.TabIndex = 100;
            this.btn_Xoa.Text = "XÓA";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(72, 162);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(126, 45);
            this.btn_Them.TabIndex = 99;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // QL_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 529);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.grpb_ttkh);
            this.Controls.Add(this.grpDanhSach);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "QL_KhachHang";
            this.Text = "QL_KhachHang";
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.grpb_ttkh.ResumeLayout(false);
            this.grpb_ttkh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox grpb_ttkh;
        private System.Windows.Forms.ComboBox cbb_hangkh;
        private System.Windows.Forms.TextBox txtb_sdt;
        private System.Windows.Forms.TextBox txtb_tenkh;
        private System.Windows.Forms.TextBox txtb_makh;
        private System.Windows.Forms.Label lbl_sdtkh;
        private System.Windows.Forms.Label lbl_hangkh;
        private System.Windows.Forms.Label lbl_tenkh;
        private System.Windows.Forms.Label lbl_makh;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
    }
}