namespace MiniStore.Management
{
    partial class QL_DSHoaDon
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
            this.lbl_dshoadon = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.GroupBox();
            this.btn_In = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lbPhuongThuctinh = new System.Windows.Forms.Label();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.maskDateTime = new System.Windows.Forms.MaskedTextBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.cbCell = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbNhap = new System.Windows.Forms.Label();
            this.grpb_dshoadon = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_print.SuspendLayout();
            this.grpb_dshoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_dshoadon
            // 
            this.lbl_dshoadon.AutoSize = true;
            this.lbl_dshoadon.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dshoadon.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_dshoadon.Location = new System.Drawing.Point(263, 19);
            this.lbl_dshoadon.Name = "lbl_dshoadon";
            this.lbl_dshoadon.Size = new System.Drawing.Size(364, 36);
            this.lbl_dshoadon.TabIndex = 1;
            this.lbl_dshoadon.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // btn_print
            // 
            this.btn_print.Controls.Add(this.btn_In);
            this.btn_print.Controls.Add(this.btnLoad);
            this.btn_print.Controls.Add(this.tbDate);
            this.btn_print.Controls.Add(this.lbPhuongThuctinh);
            this.btn_print.Controls.Add(this.cbPayment);
            this.btn_print.Controls.Add(this.lbTime);
            this.btn_print.Controls.Add(this.cbDate);
            this.btn_print.Controls.Add(this.lbDateTime);
            this.btn_print.Controls.Add(this.maskDateTime);
            this.btn_print.Controls.Add(this.btn_Dong);
            this.btn_print.Controls.Add(this.label2);
            this.btn_print.Controls.Add(this.btn_Tim);
            this.btn_print.Controls.Add(this.cbCell);
            this.btn_print.Controls.Add(this.txtSearch);
            this.btn_print.Controls.Add(this.lbNhap);
            this.btn_print.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_print.Location = new System.Drawing.Point(13, 69);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(875, 171);
            this.btn_print.TabIndex = 2;
            this.btn_print.TabStop = false;
            this.btn_print.Text = "Tìm kiếm hóa đơn";
            // 
            // btn_In
            // 
            this.btn_In.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_In.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.ForeColor = System.Drawing.Color.White;
            this.btn_In.Location = new System.Drawing.Point(698, 21);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(118, 46);
            this.btn_In.TabIndex = 29;
            this.btn_In.Text = "IN DANH SÁCH";
            this.btn_In.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_In.UseVisualStyleBackColor = false;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Image = global::MiniStore.Properties.Resources.available_updates_32px1;
            this.btnLoad.Location = new System.Drawing.Point(509, 21);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 46);
            this.btnLoad.TabIndex = 28;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(204, 122);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(121, 26);
            this.tbDate.TabIndex = 27;
            this.tbDate.Visible = false;
            this.tbDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDate_KeyPress);
            // 
            // lbPhuongThuctinh
            // 
            this.lbPhuongThuctinh.AutoSize = true;
            this.lbPhuongThuctinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhuongThuctinh.Location = new System.Drawing.Point(45, 80);
            this.lbPhuongThuctinh.Name = "lbPhuongThuctinh";
            this.lbPhuongThuctinh.Size = new System.Drawing.Size(112, 19);
            this.lbPhuongThuctinh.TabIndex = 26;
            this.lbPhuongThuctinh.Text = "Phương thức tính";
            this.lbPhuongThuctinh.Visible = false;
            // 
            // cbPayment
            // 
            this.cbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Location = new System.Drawing.Point(204, 79);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(121, 27);
            this.cbPayment.TabIndex = 25;
            this.cbPayment.Visible = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(46, 125);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(67, 19);
            this.lbTime.TabIndex = 24;
            this.lbTime.Text = "Thời gian:";
            // 
            // cbDate
            // 
            this.cbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(204, 79);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(229, 27);
            this.cbDate.TabIndex = 23;
            this.cbDate.Visible = false;
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.Location = new System.Drawing.Point(49, 79);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(98, 19);
            this.lbDateTime.TabIndex = 22;
            this.lbDateTime.Text = "Dạng thời gian:";
            this.lbDateTime.Visible = false;
            // 
            // maskDateTime
            // 
            this.maskDateTime.Location = new System.Drawing.Point(204, 122);
            this.maskDateTime.Mask = "00/00/0000";
            this.maskDateTime.Name = "maskDateTime";
            this.maskDateTime.Size = new System.Drawing.Size(121, 26);
            this.maskDateTime.TabIndex = 21;
            this.maskDateTime.ValidatingType = typeof(System.DateTime);
            this.maskDateTime.Visible = false;
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.ForeColor = System.Drawing.Color.White;
            this.btn_Dong.Image = global::MiniStore.Properties.Resources.cancel_32px6;
            this.btn_Dong.Location = new System.Drawing.Point(698, 91);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(121, 46);
            this.btn_Dong.TabIndex = 20;
            this.btn_Dong.Text = "ĐÓNG";
            this.btn_Dong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm theo :";
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Tim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.ForeColor = System.Drawing.Color.White;
            this.btn_Tim.Location = new System.Drawing.Point(509, 90);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(118, 46);
            this.btn_Tim.TabIndex = 19;
            this.btn_Tim.Text = "TÌM";
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // cbCell
            // 
            this.cbCell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCell.FormattingEnabled = true;
            this.cbCell.Location = new System.Drawing.Point(204, 38);
            this.cbCell.Name = "cbCell";
            this.cbCell.Size = new System.Drawing.Size(229, 27);
            this.cbCell.TabIndex = 2;
            this.cbCell.SelectedIndexChanged += new System.EventHandler(this.cbCell_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(204, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(229, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Chỉ nhập số";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhap.Location = new System.Drawing.Point(46, 78);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(46, 19);
            this.lbNhap.TabIndex = 0;
            this.lbNhap.Text = "Nhập:";
            // 
            // grpb_dshoadon
            // 
            this.grpb_dshoadon.Controls.Add(this.dataGridView);
            this.grpb_dshoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_dshoadon.ForeColor = System.Drawing.Color.DarkCyan;
            this.grpb_dshoadon.Location = new System.Drawing.Point(13, 246);
            this.grpb_dshoadon.Name = "grpb_dshoadon";
            this.grpb_dshoadon.Size = new System.Drawing.Size(873, 282);
            this.grpb_dshoadon.TabIndex = 3;
            this.grpb_dshoadon.TabStop = false;
            this.grpb_dshoadon.Text = "Danh Sách Hóa Đơn";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.Location = new System.Drawing.Point(7, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(860, 251);
            this.dataGridView.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 28);
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.orderDetailsToolStripMenuItem.Text = "Xem chi tiết hóa đơn";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // QL_DSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 535);
            this.Controls.Add(this.grpb_dshoadon);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lbl_dshoadon);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QL_DSHoaDon";
            this.Text = "DANH SÁCH HÓA ĐƠN";
            this.Load += new System.EventHandler(this.QL_DSHoaDon_Load);
            this.btn_print.ResumeLayout(false);
            this.btn_print.PerformLayout();
            this.grpb_dshoadon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dshoadon;
        private System.Windows.Forms.GroupBox btn_print;
        private System.Windows.Forms.GroupBox grpb_dshoadon;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCell;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox maskDateTime;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.Label lbPhuongThuctinh;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btn_In;
    }
}