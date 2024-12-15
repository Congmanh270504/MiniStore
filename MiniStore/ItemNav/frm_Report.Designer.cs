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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RevueneDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_hoadon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.lbTimeType = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalQuantity = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(12, 213);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(797, 408);
            this.dataGridView.TabIndex = 131;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RevueneDetailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 26);
            // 
            // RevueneDetailToolStripMenuItem
            // 
            this.RevueneDetailToolStripMenuItem.Name = "RevueneDetailToolStripMenuItem";
            this.RevueneDetailToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.RevueneDetailToolStripMenuItem.Text = "Chi tiết doanh thu";
            this.RevueneDetailToolStripMenuItem.Click += new System.EventHandler(this.RevueneDetailToolStripMenuItem_Click);
            // 
            // lbl_hoadon
            // 
            this.lbl_hoadon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_hoadon.AutoSize = true;
            this.lbl_hoadon.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoadon.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_hoadon.Location = new System.Drawing.Point(216, 8);
            this.lbl_hoadon.Name = "lbl_hoadon";
            this.lbl_hoadon.Size = new System.Drawing.Size(391, 36);
            this.lbl_hoadon.TabIndex = 129;
            this.lbl_hoadon.Text = "THỐNG KÊ DOANH THU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 130;
            this.label1.Text = "Tổng thu nhập:";
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRevenue.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTotalRevenue.Location = new System.Drawing.Point(158, 65);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(45, 19);
            this.lbTotalRevenue.TabIndex = 134;
            this.lbTotalRevenue.Text = "label2";
            // 
            // lbTimeType
            // 
            this.lbTimeType.AutoSize = true;
            this.lbTimeType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTimeType.Location = new System.Drawing.Point(65, 37);
            this.lbTimeType.Name = "lbTimeType";
            this.lbTimeType.Size = new System.Drawing.Size(42, 19);
            this.lbTimeType.TabIndex = 127;
            this.lbTimeType.Text = "Năm:";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(124, 35);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(143, 27);
            this.tbTime.TabIndex = 128;
            this.tbTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTime_KeyPress);
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Tim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.ForeColor = System.Drawing.Color.White;
            this.btn_Tim.Location = new System.Drawing.Point(302, 30);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(99, 36);
            this.btn_Tim.TabIndex = 129;
            this.btn_Tim.Text = "TÌM";
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            this.btn_Tim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Tim_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Tim);
            this.groupBox1.Controls.Add(this.tbTime);
            this.groupBox1.Controls.Add(this.lbTimeType);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(38, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 90);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 136;
            this.label3.Text = "Tổng số mặt hàng:";
            // 
            // lbTotalQuantity
            // 
            this.lbTotalQuantity.AutoSize = true;
            this.lbTotalQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalQuantity.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTotalQuantity.Location = new System.Drawing.Point(158, 29);
            this.lbTotalQuantity.Name = "lbTotalQuantity";
            this.lbTotalQuantity.Size = new System.Drawing.Size(101, 19);
            this.lbTotalQuantity.TabIndex = 137;
            this.lbTotalQuantity.Text = "lbTotalQuantity";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::MiniStore.Properties.Resources.cancel_32px1;
            this.btnClose.Location = new System.Drawing.Point(656, 151);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 46);
            this.btnClose.TabIndex = 133;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::MiniStore.Properties.Resources.available_updates;
            this.btnRefresh.Location = new System.Drawing.Point(491, 151);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 46);
            this.btnRefresh.TabIndex = 132;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTotalQuantity);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbTotalRevenue);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(491, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 91);
            this.groupBox2.TabIndex = 139;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin ";
            // 
            // frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 633);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lbl_hoadon);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Name = "frm_Report";
            this.Text = "THỐNG KÊ DOANH THU";
            this.Load += new System.EventHandler(this.frm_Report2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl_hoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Label lbTimeType;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalQuantity;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RevueneDetailToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}