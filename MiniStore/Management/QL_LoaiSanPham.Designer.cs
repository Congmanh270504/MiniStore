namespace MiniStore.Management
{
    partial class QL_LoaiSanPham
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
            this.LoaiSPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpLoaiSanPham = new System.Windows.Forms.GroupBox();
            this.txtb_Maloaisp = new System.Windows.Forms.TextBox();
            this.lbl_Maloaisp = new System.Windows.Forms.Label();
            this.lblLoaiSanPham = new System.Windows.Forms.Label();
            this.txtLoaiSanPham = new System.Windows.Forms.TextBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.grpLoaiSanPham.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LoaiSPID
            // 
            this.LoaiSPID.DataPropertyName = "LoaiSPID";
            this.LoaiSPID.HeaderText = "LoaiSPID";
            this.LoaiSPID.Name = "LoaiSPID";
            this.LoaiSPID.ReadOnly = true;
            this.LoaiSPID.Visible = false;
            // 
            // TenLoaiSP
            // 
            this.TenLoaiSP.DataPropertyName = "TenLoaiSP";
            this.TenLoaiSP.HeaderText = "Tên loại sản phẩm";
            this.TenLoaiSP.Name = "TenLoaiSP";
            this.TenLoaiSP.ReadOnly = true;
            // 
            // grpLoaiSanPham
            // 
            this.grpLoaiSanPham.Controls.Add(this.txtb_Maloaisp);
            this.grpLoaiSanPham.Controls.Add(this.lbl_Maloaisp);
            this.grpLoaiSanPham.Controls.Add(this.lblLoaiSanPham);
            this.grpLoaiSanPham.Controls.Add(this.txtLoaiSanPham);
            this.grpLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoaiSanPham.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpLoaiSanPham.Location = new System.Drawing.Point(40, 12);
            this.grpLoaiSanPham.Name = "grpLoaiSanPham";
            this.grpLoaiSanPham.Size = new System.Drawing.Size(724, 117);
            this.grpLoaiSanPham.TabIndex = 2;
            this.grpLoaiSanPham.TabStop = false;
            this.grpLoaiSanPham.Text = "Loại sản phẩm";
            // 
            // txtb_Maloaisp
            // 
            this.txtb_Maloaisp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Maloaisp.Location = new System.Drawing.Point(185, 36);
            this.txtb_Maloaisp.Name = "txtb_Maloaisp";
            this.txtb_Maloaisp.Size = new System.Drawing.Size(295, 27);
            this.txtb_Maloaisp.TabIndex = 72;
            // 
            // lbl_Maloaisp
            // 
            this.lbl_Maloaisp.AutoSize = true;
            this.lbl_Maloaisp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Maloaisp.Location = new System.Drawing.Point(39, 36);
            this.lbl_Maloaisp.Name = "lbl_Maloaisp";
            this.lbl_Maloaisp.Size = new System.Drawing.Size(127, 20);
            this.lbl_Maloaisp.TabIndex = 71;
            this.lbl_Maloaisp.Text = "Mã loại sản phẩm";
            // 
            // lblLoaiSanPham
            // 
            this.lblLoaiSanPham.AutoSize = true;
            this.lblLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSanPham.Location = new System.Drawing.Point(39, 85);
            this.lblLoaiSanPham.Name = "lblLoaiSanPham";
            this.lblLoaiSanPham.Size = new System.Drawing.Size(129, 20);
            this.lblLoaiSanPham.TabIndex = 73;
            this.lblLoaiSanPham.Text = "Tên loại sản phẩm";
            // 
            // txtLoaiSanPham
            // 
            this.txtLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiSanPham.Location = new System.Drawing.Point(185, 82);
            this.txtLoaiSanPham.Name = "txtLoaiSanPham";
            this.txtLoaiSanPham.Size = new System.Drawing.Size(295, 27);
            this.txtLoaiSanPham.TabIndex = 74;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dataGridView);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpDanhSach.Location = new System.Drawing.Point(12, 202);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(794, 297);
            this.grpDanhSach.TabIndex = 77;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách loại sản phẩm";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(781, 259);
            this.dataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LoaiSPID";
            this.dataGridViewTextBoxColumn1.HeaderText = "LoaiSPID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenLoaiSP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên loại sản phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Dong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.ForeColor = System.Drawing.Color.White;
            this.btn_Dong.Location = new System.Drawing.Point(596, 135);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(121, 46);
            this.btn_Dong.TabIndex = 88;
            this.btn_Dong.Text = "ĐÓNG";
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(469, 135);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(121, 46);
            this.btn_Luu.TabIndex = 87;
            this.btn_Luu.Text = "LƯU";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(337, 135);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(126, 45);
            this.btn_Sua.TabIndex = 86;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(205, 135);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 45);
            this.btn_Xoa.TabIndex = 85;
            this.btn_Xoa.Text = "XÓA";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(69, 135);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(126, 45);
            this.btn_Them.TabIndex = 84;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // QL_LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 512);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpLoaiSanPham);
            this.Name = "QL_LoaiSanPham";
            this.Text = "QUẢN LÝ LOẠI SẢN PHẨM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QL_LoaiSanPham_FormClosing);
            this.Load += new System.EventHandler(this.QL_LoaiSanPham_Load);
            this.grpLoaiSanPham.ResumeLayout(false);
            this.grpLoaiSanPham.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSP;
        private System.Windows.Forms.GroupBox grpLoaiSanPham;
        private System.Windows.Forms.Label lblLoaiSanPham;
        private System.Windows.Forms.TextBox txtLoaiSanPham;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtb_Maloaisp;
        private System.Windows.Forms.Label lbl_Maloaisp;
    }
}