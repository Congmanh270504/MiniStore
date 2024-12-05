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
            this.lbl_makh = new System.Windows.Forms.Label();
            this.cbb_hangkh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_hoadon
            // 
            this.lbl_hoadon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_hoadon.AutoSize = true;
            this.lbl_hoadon.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoadon.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_hoadon.Location = new System.Drawing.Point(183, 32);
            this.lbl_hoadon.Name = "lbl_hoadon";
            this.lbl_hoadon.Size = new System.Drawing.Size(389, 45);
            this.lbl_hoadon.TabIndex = 1;
            this.lbl_hoadon.Text = "THỐNG KÊ DOANH THU";
            // 
            // lbl_makh
            // 
            this.lbl_makh.AutoSize = true;
            this.lbl_makh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_makh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_makh.Location = new System.Drawing.Point(97, 119);
            this.lbl_makh.Name = "lbl_makh";
            this.lbl_makh.Size = new System.Drawing.Size(149, 21);
            this.lbl_makh.TabIndex = 107;
            this.lbl_makh.Text = "Theo dạng thời gian";
            // 
            // cbb_hangkh
            // 
            this.cbb_hangkh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hangkh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_hangkh.FormattingEnabled = true;
            this.cbb_hangkh.Location = new System.Drawing.Point(252, 115);
            this.cbb_hangkh.Name = "cbb_hangkh";
            this.cbb_hangkh.Size = new System.Drawing.Size(226, 25);
            this.cbb_hangkh.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(532, 115);
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
            this.dataGridView.Location = new System.Drawing.Point(12, 158);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(754, 304);
            this.dataGridView.TabIndex = 120;
            // 
            // frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 474);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_hangkh);
            this.Controls.Add(this.lbl_makh);
            this.Controls.Add(this.lbl_hoadon);
            this.Name = "frm_Report";
            this.Text = "frm_Report";
            this.Load += new System.EventHandler(this.frm_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hoadon;
        private System.Windows.Forms.Label lbl_makh;
        private System.Windows.Forms.ComboBox cbb_hangkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}