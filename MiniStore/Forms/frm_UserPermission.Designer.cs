namespace MiniStore.Forms
{
    partial class frm_UserPermission
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
            this.grpb_thongtin = new System.Windows.Forms.GroupBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.lbl_tendangnhap = new System.Windows.Forms.Label();
            this.lbl_nhanvien = new System.Windows.Forms.Label();
            this.grpb_phanquyen = new System.Windows.Forms.GroupBox();
            this.rdoSell = new System.Windows.Forms.RadioButton();
            this.rdoWareHouse = new System.Windows.Forms.RadioButton();
            this.rdoManager = new System.Windows.Forms.RadioButton();
            this.rdoOwner = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.grpb_thongtin.SuspendLayout();
            this.grpb_phanquyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpb_thongtin
            // 
            this.grpb_thongtin.Controls.Add(this.tbPosition);
            this.grpb_thongtin.Controls.Add(this.cmbNhanVien);
            this.grpb_thongtin.Controls.Add(this.lbl_tendangnhap);
            this.grpb_thongtin.Controls.Add(this.lbl_nhanvien);
            this.grpb_thongtin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_thongtin.ForeColor = System.Drawing.Color.SlateGray;
            this.grpb_thongtin.Location = new System.Drawing.Point(22, 12);
            this.grpb_thongtin.Name = "grpb_thongtin";
            this.grpb_thongtin.Size = new System.Drawing.Size(355, 114);
            this.grpb_thongtin.TabIndex = 1;
            this.grpb_thongtin.TabStop = false;
            this.grpb_thongtin.Text = "Thông tin";
            // 
            // tbPosition
            // 
            this.tbPosition.Enabled = false;
            this.tbPosition.Location = new System.Drawing.Point(124, 77);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(216, 29);
            this.tbPosition.TabIndex = 76;
            this.tbPosition.Text = " ";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(124, 31);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(216, 28);
            this.cmbNhanVien.TabIndex = 75;
            this.cmbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmbNhanVien_SelectedIndexChanged);
            // 
            // lbl_tendangnhap
            // 
            this.lbl_tendangnhap.AutoSize = true;
            this.lbl_tendangnhap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tendangnhap.Location = new System.Drawing.Point(11, 81);
            this.lbl_tendangnhap.Name = "lbl_tendangnhap";
            this.lbl_tendangnhap.Size = new System.Drawing.Size(61, 20);
            this.lbl_tendangnhap.TabIndex = 73;
            this.lbl_tendangnhap.Text = "Chức vụ";
            // 
            // lbl_nhanvien
            // 
            this.lbl_nhanvien.AutoSize = true;
            this.lbl_nhanvien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhanvien.Location = new System.Drawing.Point(11, 34);
            this.lbl_nhanvien.Name = "lbl_nhanvien";
            this.lbl_nhanvien.Size = new System.Drawing.Size(75, 20);
            this.lbl_nhanvien.TabIndex = 73;
            this.lbl_nhanvien.Text = "Nhân viên";
            // 
            // grpb_phanquyen
            // 
            this.grpb_phanquyen.Controls.Add(this.rdoSell);
            this.grpb_phanquyen.Controls.Add(this.rdoWareHouse);
            this.grpb_phanquyen.Controls.Add(this.rdoManager);
            this.grpb_phanquyen.Controls.Add(this.rdoOwner);
            this.grpb_phanquyen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_phanquyen.ForeColor = System.Drawing.Color.SlateGray;
            this.grpb_phanquyen.Location = new System.Drawing.Point(22, 132);
            this.grpb_phanquyen.Name = "grpb_phanquyen";
            this.grpb_phanquyen.Size = new System.Drawing.Size(355, 202);
            this.grpb_phanquyen.TabIndex = 2;
            this.grpb_phanquyen.TabStop = false;
            this.grpb_phanquyen.Text = "Phân Quyền";
            // 
            // rdoSell
            // 
            this.rdoSell.AutoSize = true;
            this.rdoSell.ForeColor = System.Drawing.Color.Black;
            this.rdoSell.Location = new System.Drawing.Point(169, 102);
            this.rdoSell.Name = "rdoSell";
            this.rdoSell.Size = new System.Drawing.Size(171, 25);
            this.rdoSell.TabIndex = 4;
            this.rdoSell.TabStop = true;
            this.rdoSell.Text = "Nhân viên bán hàng";
            this.rdoSell.UseVisualStyleBackColor = true;
            // 
            // rdoWareHouse
            // 
            this.rdoWareHouse.AutoSize = true;
            this.rdoWareHouse.ForeColor = System.Drawing.Color.Black;
            this.rdoWareHouse.Location = new System.Drawing.Point(15, 102);
            this.rdoWareHouse.Name = "rdoWareHouse";
            this.rdoWareHouse.Size = new System.Drawing.Size(131, 25);
            this.rdoWareHouse.TabIndex = 3;
            this.rdoWareHouse.TabStop = true;
            this.rdoWareHouse.Text = "Nhân viên kho";
            this.rdoWareHouse.UseVisualStyleBackColor = true;
            // 
            // rdoManager
            // 
            this.rdoManager.AutoSize = true;
            this.rdoManager.ForeColor = System.Drawing.Color.Black;
            this.rdoManager.Location = new System.Drawing.Point(169, 41);
            this.rdoManager.Name = "rdoManager";
            this.rdoManager.Size = new System.Drawing.Size(152, 25);
            this.rdoManager.TabIndex = 2;
            this.rdoManager.TabStop = true;
            this.rdoManager.Text = "Quản lý cửa hàng";
            this.rdoManager.UseVisualStyleBackColor = true;
            // 
            // rdoOwner
            // 
            this.rdoOwner.AutoSize = true;
            this.rdoOwner.ForeColor = System.Drawing.Color.Black;
            this.rdoOwner.Location = new System.Drawing.Point(15, 41);
            this.rdoOwner.Name = "rdoOwner";
            this.rdoOwner.Size = new System.Drawing.Size(126, 25);
            this.rdoOwner.TabIndex = 1;
            this.rdoOwner.TabStop = true;
            this.rdoOwner.Text = "Chủ cửa hàng";
            this.rdoOwner.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Image = global::MiniStore.Properties.Resources.cancel_32px5;
            this.btnCancel.Location = new System.Drawing.Point(280, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_luu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_luu.Image = global::MiniStore.Properties.Resources.edit_file_20px2;
            this.btn_luu.Location = new System.Drawing.Point(146, 340);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(97, 40);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "LƯU";
            this.btn_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // frm_UserPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 391);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.grpb_phanquyen);
            this.Controls.Add(this.grpb_thongtin);
            this.Name = "frm_UserPermission";
            this.Text = "PHÂN QUYỀN NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.frm_UserPermission_Load);
            this.grpb_thongtin.ResumeLayout(false);
            this.grpb_thongtin.PerformLayout();
            this.grpb_phanquyen.ResumeLayout(false);
            this.grpb_phanquyen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpb_thongtin;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label lbl_tendangnhap;
        private System.Windows.Forms.Label lbl_nhanvien;
        private System.Windows.Forms.GroupBox grpb_phanquyen;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.RadioButton rdoSell;
        private System.Windows.Forms.RadioButton rdoWareHouse;
        private System.Windows.Forms.RadioButton rdoManager;
        private System.Windows.Forms.RadioButton rdoOwner;
    }
}