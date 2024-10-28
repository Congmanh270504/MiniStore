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
            this.grpLoaiSanPham.Controls.Add(this.lblLoaiSanPham);
            this.grpLoaiSanPham.Controls.Add(this.txtLoaiSanPham);
            this.grpLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoaiSanPham.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpLoaiSanPham.Location = new System.Drawing.Point(40, 12);
            this.grpLoaiSanPham.Name = "grpLoaiSanPham";
            this.grpLoaiSanPham.Size = new System.Drawing.Size(724, 101);
            this.grpLoaiSanPham.TabIndex = 2;
            this.grpLoaiSanPham.TabStop = false;
            this.grpLoaiSanPham.Text = "Loại sản phẩm";
            // 
            // lblLoaiSanPham
            // 
            this.lblLoaiSanPham.AutoSize = true;
            this.lblLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSanPham.Location = new System.Drawing.Point(129, 45);
            this.lblLoaiSanPham.Name = "lblLoaiSanPham";
            this.lblLoaiSanPham.Size = new System.Drawing.Size(129, 20);
            this.lblLoaiSanPham.TabIndex = 71;
            this.lblLoaiSanPham.Text = "Tên loại sản phẩm";
            // 
            // txtLoaiSanPham
            // 
            this.txtLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiSanPham.Location = new System.Drawing.Point(264, 42);
            this.txtLoaiSanPham.Name = "txtLoaiSanPham";
            this.txtLoaiSanPham.Size = new System.Drawing.Size(295, 27);
            this.txtLoaiSanPham.TabIndex = 2;
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
    }
}