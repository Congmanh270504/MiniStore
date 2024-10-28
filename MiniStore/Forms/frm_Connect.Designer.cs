namespace MiniStore.Forms
{
    partial class frm_Connect
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
            this.lbl_servername = new System.Windows.Forms.Label();
            this.lbl_authentication = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtb_servername = new System.Windows.Forms.TextBox();
            this.txtb_username = new System.Windows.Forms.TextBox();
            this.txtb_password = new System.Windows.Forms.TextBox();
            this.cbb_authentication = new System.Windows.Forms.ComboBox();
            this.btn_dsdatabase = new System.Windows.Forms.Button();
            this.lbl_selectdb = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_servername
            // 
            this.lbl_servername.AutoSize = true;
            this.lbl_servername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servername.Location = new System.Drawing.Point(12, 156);
            this.lbl_servername.Name = "lbl_servername";
            this.lbl_servername.Size = new System.Drawing.Size(88, 16);
            this.lbl_servername.TabIndex = 0;
            this.lbl_servername.Text = "Server name:";
            // 
            // lbl_authentication
            // 
            this.lbl_authentication.AutoSize = true;
            this.lbl_authentication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_authentication.Location = new System.Drawing.Point(6, 205);
            this.lbl_authentication.Name = "lbl_authentication";
            this.lbl_authentication.Size = new System.Drawing.Size(94, 16);
            this.lbl_authentication.TabIndex = 1;
            this.lbl_authentication.Text = "Authentication:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(23, 254);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(77, 16);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "User name:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(29, 298);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(71, 16);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password:";
            // 
            // txtb_servername
            // 
            this.txtb_servername.Location = new System.Drawing.Point(106, 147);
            this.txtb_servername.Name = "txtb_servername";
            this.txtb_servername.Size = new System.Drawing.Size(323, 25);
            this.txtb_servername.TabIndex = 4;
            // 
            // txtb_username
            // 
            this.txtb_username.Location = new System.Drawing.Point(106, 245);
            this.txtb_username.Name = "txtb_username";
            this.txtb_username.Size = new System.Drawing.Size(323, 25);
            this.txtb_username.TabIndex = 5;
            // 
            // txtb_password
            // 
            this.txtb_password.Location = new System.Drawing.Point(106, 289);
            this.txtb_password.Name = "txtb_password";
            this.txtb_password.Size = new System.Drawing.Size(323, 25);
            this.txtb_password.TabIndex = 6;
            // 
            // cbb_authentication
            // 
            this.cbb_authentication.FormattingEnabled = true;
            this.cbb_authentication.Location = new System.Drawing.Point(106, 196);
            this.cbb_authentication.Name = "cbb_authentication";
            this.cbb_authentication.Size = new System.Drawing.Size(323, 25);
            this.cbb_authentication.TabIndex = 7;
            // 
            // btn_dsdatabase
            // 
            this.btn_dsdatabase.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_dsdatabase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsdatabase.ForeColor = System.Drawing.Color.White;
            this.btn_dsdatabase.Location = new System.Drawing.Point(264, 338);
            this.btn_dsdatabase.Name = "btn_dsdatabase";
            this.btn_dsdatabase.Size = new System.Drawing.Size(165, 38);
            this.btn_dsdatabase.TabIndex = 8;
            this.btn_dsdatabase.Text = "Lấy danh sách Database";
            this.btn_dsdatabase.UseVisualStyleBackColor = false;
            // 
            // lbl_selectdb
            // 
            this.lbl_selectdb.AutoSize = true;
            this.lbl_selectdb.Location = new System.Drawing.Point(0, 409);
            this.lbl_selectdb.Name = "lbl_selectdb";
            this.lbl_selectdb.Size = new System.Drawing.Size(100, 17);
            this.lbl_selectdb.TabIndex = 9;
            this.lbl_selectdb.Text = "Chọn Database:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 406);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(323, 25);
            this.comboBox1.TabIndex = 10;
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_connect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.Color.White;
            this.btn_connect.Location = new System.Drawing.Point(223, 459);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(100, 38);
            this.btn_connect.TabIndex = 11;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(329, 459);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 38);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniStore.Properties.Resources.sql;
            this.pictureBox1.Location = new System.Drawing.Point(41, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 94);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_selectdb);
            this.Controls.Add(this.btn_dsdatabase);
            this.Controls.Add(this.cbb_authentication);
            this.Controls.Add(this.txtb_password);
            this.Controls.Add(this.txtb_username);
            this.Controls.Add(this.txtb_servername);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_authentication);
            this.Controls.Add(this.lbl_servername);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Connect";
            this.Text = "frm_Connect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Connect_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_servername;
        private System.Windows.Forms.Label lbl_authentication;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtb_servername;
        private System.Windows.Forms.TextBox txtb_username;
        private System.Windows.Forms.TextBox txtb_password;
        private System.Windows.Forms.ComboBox cbb_authentication;
        private System.Windows.Forms.Button btn_dsdatabase;
        private System.Windows.Forms.Label lbl_selectdb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}