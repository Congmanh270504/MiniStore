namespace KFC_FASTFOOD.Forms
{
    partial class frm_RestoreDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RestoreDatabase));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnPath = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKhoiPhuc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelHeader.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkCyan;
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.label4);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(523, 28);
            this.panelHeader.TabIndex = 85;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(491, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(195, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "KHÔI PHỤC DỮ LIỆU";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.DarkCyan;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(519, 28);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(4, 163);
            this.panelRight.TabIndex = 88;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.DarkCyan;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 187);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(519, 4);
            this.panelFooter.TabIndex = 90;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkCyan;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 28);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(4, 159);
            this.panelLeft.TabIndex = 91;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(4, 165);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(515, 22);
            this.statusStrip1.TabIndex = 100;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 132);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(497, 23);
            this.progressBar1.TabIndex = 99;
            this.progressBar1.Visible = false;
            // 
            // btnPath
            // 
            this.btnPath.Activecolor = System.Drawing.Color.DarkCyan;
            this.btnPath.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPath.BorderRadius = 5;
            this.btnPath.ButtonText = "...";
            this.btnPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPath.DisabledColor = System.Drawing.Color.Gray;
            this.btnPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPath.Iconimage = null;
            this.btnPath.Iconimage_right = null;
            this.btnPath.Iconimage_right_Selected = null;
            this.btnPath.Iconimage_Selected = null;
            this.btnPath.IconMarginLeft = 0;
            this.btnPath.IconMarginRight = 0;
            this.btnPath.IconRightVisible = true;
            this.btnPath.IconRightZoom = 0D;
            this.btnPath.IconVisible = true;
            this.btnPath.IconZoom = 90D;
            this.btnPath.IsTab = false;
            this.btnPath.Location = new System.Drawing.Point(465, 56);
            this.btnPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPath.Name = "btnPath";
            this.btnPath.Normalcolor = System.Drawing.Color.DarkCyan;
            this.btnPath.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnPath.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPath.selected = false;
            this.btnPath.Size = new System.Drawing.Size(44, 27);
            this.btnPath.TabIndex = 97;
            this.btnPath.Text = "...";
            this.btnPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPath.Textcolor = System.Drawing.Color.White;
            this.btnPath.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Activecolor = System.Drawing.Color.DarkCyan;
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.DarkCyan;
            this.btnKhoiPhuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKhoiPhuc.BorderRadius = 5;
            this.btnKhoiPhuc.ButtonText = "KHÔI PHỤC";
            this.btnKhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoiPhuc.DisabledColor = System.Drawing.Color.Gray;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKhoiPhuc.Iconimage = null;
            this.btnKhoiPhuc.Iconimage_right = null;
            this.btnKhoiPhuc.Iconimage_right_Selected = null;
            this.btnKhoiPhuc.Iconimage_Selected = null;
            this.btnKhoiPhuc.IconMarginLeft = 0;
            this.btnKhoiPhuc.IconMarginRight = 0;
            this.btnKhoiPhuc.IconRightVisible = true;
            this.btnKhoiPhuc.IconRightZoom = 0D;
            this.btnKhoiPhuc.IconVisible = true;
            this.btnKhoiPhuc.IconZoom = 90D;
            this.btnKhoiPhuc.IsTab = false;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(406, 91);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Normalcolor = System.Drawing.Color.DarkCyan;
            this.btnKhoiPhuc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnKhoiPhuc.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.selected = false;
            this.btnKhoiPhuc.Size = new System.Drawing.Size(103, 33);
            this.btnKhoiPhuc.TabIndex = 98;
            this.btnKhoiPhuc.Text = "KHÔI PHỤC";
            this.btnKhoiPhuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKhoiPhuc.Textcolor = System.Drawing.Color.White;
            this.btnKhoiPhuc.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(50, 56);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(409, 27);
            this.txtPath.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 95;
            this.label1.Text = "File";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelHeader;
            this.bunifuDragControl2.Vertical = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_RestoreDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 191);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_RestoreDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khôi phục dữ liệu";
            this.Load += new System.EventHandler(this.frm_RestoreDatabase_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPath;
        private Bunifu.Framework.UI.BunifuFlatButton btnKhoiPhuc;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}