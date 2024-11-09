namespace MiniStore.Forms
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.panel_lefttop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_lefttop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lefttop
            // 
            this.panel_lefttop.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel_lefttop.Controls.Add(this.pictureBox2);
            this.panel_lefttop.Controls.Add(this.pictureBox1);
            this.panel_lefttop.Location = new System.Drawing.Point(1, 2);
            this.panel_lefttop.Name = "panel_lefttop";
            this.panel_lefttop.Size = new System.Drawing.Size(200, 120);
            this.panel_lefttop.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnPersonnel);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(1, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 372);
            this.panel1.TabIndex = 2;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 321);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(200, 47);
            this.btnSetting.TabIndex = 13;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = global::MiniStore.Properties.Resources.sorting_answers_32px1;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 268);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(200, 47);
            this.btnAdmin.TabIndex = 12;
            this.btnAdmin.Text = "Quản lý";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::MiniStore.Properties.Resources.graph_report_32px;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 162);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 47);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Thống kê";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPersonnel.FlatAppearance.BorderSize = 0;
            this.btnPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonnel.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonnel.ForeColor = System.Drawing.Color.White;
            this.btnPersonnel.Image = global::MiniStore.Properties.Resources.conference_32px;
            this.btnPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonnel.Location = new System.Drawing.Point(0, 109);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(200, 47);
            this.btnPersonnel.TabIndex = 9;
            this.btnPersonnel.Text = "Nhân sự";
            this.btnPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonnel.UseVisualStyleBackColor = false;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::MiniStore.Properties.Resources.kawaii_french_fries_32px;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 215);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(200, 47);
            this.btnProduct.TabIndex = 8;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Image = global::MiniStore.Properties.Resources.shopping_cart_32px;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 56);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(200, 47);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Gọi món";
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::MiniStore.Properties.Resources.home_32px;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 47);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel_header.Location = new System.Drawing.Point(198, 2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(539, 42);
            this.panel_header.TabIndex = 1;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_lefttop);
            this.Name = "frm_Main";
            this.Text = "frm_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.panel_lefttop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lefttop;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnProduct;
    }
}