namespace KFC_FASTFOOD.UCFunction
{
    partial class UC_RpProfileEmployess
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.lblBoPhan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.btnXemHoSo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rpProfile = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = global::KFC_FASTFOOD.Properties.Resources.left_round_32px1;
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 73;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(41, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 21);
            this.lblTitle.TabIndex = 72;
            this.lblTitle.Text = "HỒ SƠ MỘT NHÂN VIÊN";
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoPhan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(170, 51);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(186, 28);
            this.cmbBoPhan.TabIndex = 75;
            this.cmbBoPhan.SelectedIndexChanged += new System.EventHandler(this.cmbBoPhan_SelectedIndexChanged);
            // 
            // lblBoPhan
            // 
            this.lblBoPhan.AutoSize = true;
            this.lblBoPhan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.lblBoPhan.Location = new System.Drawing.Point(100, 55);
            this.lblBoPhan.Name = "lblBoPhan";
            this.lblBoPhan.Size = new System.Drawing.Size(64, 20);
            this.lblBoPhan.TabIndex = 74;
            this.lblBoPhan.Text = "Bộ phận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(368, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Nhân viên";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(449, 51);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(186, 28);
            this.cmbNhanVien.TabIndex = 75;
            // 
            // btnXemHoSo
            // 
            this.btnXemHoSo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnXemHoSo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXemHoSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnXemHoSo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXemHoSo.BorderRadius = 5;
            this.btnXemHoSo.ButtonText = "XEM HỒ SƠ";
            this.btnXemHoSo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemHoSo.DisabledColor = System.Drawing.Color.Gray;
            this.btnXemHoSo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXemHoSo.Iconimage = null;
            this.btnXemHoSo.Iconimage_right = null;
            this.btnXemHoSo.Iconimage_right_Selected = null;
            this.btnXemHoSo.Iconimage_Selected = null;
            this.btnXemHoSo.IconMarginLeft = 0;
            this.btnXemHoSo.IconMarginRight = 0;
            this.btnXemHoSo.IconRightVisible = true;
            this.btnXemHoSo.IconRightZoom = 0D;
            this.btnXemHoSo.IconVisible = true;
            this.btnXemHoSo.IconZoom = 90D;
            this.btnXemHoSo.IsTab = false;
            this.btnXemHoSo.Location = new System.Drawing.Point(658, 51);
            this.btnXemHoSo.Name = "btnXemHoSo";
            this.btnXemHoSo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnXemHoSo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnXemHoSo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXemHoSo.selected = false;
            this.btnXemHoSo.Size = new System.Drawing.Size(114, 28);
            this.btnXemHoSo.TabIndex = 76;
            this.btnXemHoSo.Text = "XEM HỒ SƠ";
            this.btnXemHoSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXemHoSo.Textcolor = System.Drawing.Color.White;
            this.btnXemHoSo.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemHoSo.Click += new System.EventHandler(this.btnXemHoSo_Click);
            // 
            // rpProfile
            // 
            this.rpProfile.ActiveViewIndex = -1;
            this.rpProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpProfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpProfile.DisplayStatusBar = false;
            this.rpProfile.Location = new System.Drawing.Point(3, 88);
            this.rpProfile.Name = "rpProfile";
            this.rpProfile.Size = new System.Drawing.Size(887, 528);
            this.rpProfile.TabIndex = 77;
            this.rpProfile.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // UC_RpProfileEmployess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rpProfile);
            this.Controls.Add(this.btnXemHoSo);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoPhan);
            this.Controls.Add(this.lblBoPhan);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_RpProfileEmployess";
            this.Size = new System.Drawing.Size(893, 619);
            this.Load += new System.EventHandler(this.UC_RpProfileEmployess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbBoPhan;
        private System.Windows.Forms.Label lblBoPhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private Bunifu.Framework.UI.BunifuFlatButton btnXemHoSo;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpProfile;
    }
}
