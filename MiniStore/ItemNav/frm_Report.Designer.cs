namespace MiniStore.ItemNav
{
    partial class frm_Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.lbTimeType = new System.Windows.Forms.Label();
            this.cb_TimeType = new System.Windows.Forms.ComboBox();
            this.lbl_makh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_hoadon
            // 
            this.lbl_hoadon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_hoadon.AutoSize = true;
            this.lbl_hoadon.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoadon.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_hoadon.Location = new System.Drawing.Point(148, 25);
            this.lbl_hoadon.Name = "lbl_hoadon";
            this.lbl_hoadon.Size = new System.Drawing.Size(389, 45);
            this.lbl_hoadon.TabIndex = 1;
            this.lbl_hoadon.Text = "THỐNG KÊ DOANH THU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(456, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 119;
            this.label1.Text = "Tổng thu nhập:";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 176);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(660, 286);
            this.dataGridView.TabIndex = 120;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(460, 120);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 36);
            this.btnRefresh.TabIndex = 125;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(573, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 36);
            this.btnClose.TabIndex = 126;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTotal.Location = new System.Drawing.Point(569, 92);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(51, 20);
            this.lbTotal.TabIndex = 127;
            this.lbTotal.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Tim);
            this.groupBox1.Controls.Add(this.tbTime);
            this.groupBox1.Controls.Add(this.lbTimeType);
            this.groupBox1.Controls.Add(this.cb_TimeType);
            this.groupBox1.Controls.Add(this.lbl_makh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 97);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo dạng thời gian";
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Tim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.ForeColor = System.Drawing.Color.White;
            this.btn_Tim.Location = new System.Drawing.Point(290, 55);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(99, 36);
            this.btn_Tim.TabIndex = 129;
            this.btn_Tim.Text = "TÌM";
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(163, 63);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(121, 27);
            this.tbTime.TabIndex = 128;
            this.tbTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTime_KeyPress);
            // 
            // lbTimeType
            // 
            this.lbTimeType.AutoSize = true;
            this.lbTimeType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTimeType.Location = new System.Drawing.Point(82, 62);
            this.lbTimeType.Name = "lbTimeType";
            this.lbTimeType.Size = new System.Drawing.Size(75, 21);
            this.lbTimeType.TabIndex = 127;
            this.lbTimeType.Text = "Thời gian";
            // 
            // cb_TimeType
            // 
            this.cb_TimeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TimeType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TimeType.FormattingEnabled = true;
            this.cb_TimeType.Location = new System.Drawing.Point(163, 24);
            this.cb_TimeType.Name = "cb_TimeType";
            this.cb_TimeType.Size = new System.Drawing.Size(226, 25);
            this.cb_TimeType.TabIndex = 126;
            // 
            // lbl_makh
            // 
            this.lbl_makh.AutoSize = true;
            this.lbl_makh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_makh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_makh.Location = new System.Drawing.Point(8, 28);
            this.lbl_makh.Name = "lbl_makh";
            this.lbl_makh.Size = new System.Drawing.Size(149, 21);
            this.lbl_makh.TabIndex = 125;
            this.lbl_makh.Text = "Theo dạng thời gian";
            // 
            // frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_hoadon);
            this.Name = "frm_Report";
            this.Text = "frm_Report";
            this.Load += new System.EventHandler(this.frm_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label lbTimeType;
        private System.Windows.Forms.ComboBox cb_TimeType;
        private System.Windows.Forms.Label lbl_makh;
    }
}