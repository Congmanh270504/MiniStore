namespace MiniStore.Forms
{
    partial class frm_BackupDatabase
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btnPathBackup = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.btnPathRestore = new System.Windows.Forms.Button();
            this.txtPathRestore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lbl_hoadon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "File";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(47, 67);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(409, 27);
            this.txtPath.TabIndex = 92;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 140);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(503, 23);
            this.progressBar1.TabIndex = 94;
            this.progressBar1.Visible = false;
            // 
            // btn_Backup
            // 
            this.btn_Backup.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Backup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backup.ForeColor = System.Drawing.Color.White;
            this.btn_Backup.Location = new System.Drawing.Point(415, 100);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(100, 34);
            this.btn_Backup.TabIndex = 95;
            this.btn_Backup.Text = "SAO LƯU";
            this.btn_Backup.UseVisualStyleBackColor = false;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btnPathBackup
            // 
            this.btnPathBackup.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPathBackup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathBackup.ForeColor = System.Drawing.Color.White;
            this.btnPathBackup.Location = new System.Drawing.Point(463, 67);
            this.btnPathBackup.Name = "btnPathBackup";
            this.btnPathBackup.Size = new System.Drawing.Size(52, 27);
            this.btnPathBackup.TabIndex = 96;
            this.btnPathBackup.Text = "...";
            this.btnPathBackup.UseVisualStyleBackColor = false;
            this.btnPathBackup.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(531, 22);
            this.statusStrip1.TabIndex = 97;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btn_Restore
            // 
            this.btn_Restore.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Restore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restore.ForeColor = System.Drawing.Color.White;
            this.btn_Restore.Location = new System.Drawing.Point(414, 274);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(100, 34);
            this.btn_Restore.TabIndex = 104;
            this.btn_Restore.Text = "KHÔI PHỤC";
            this.btn_Restore.UseVisualStyleBackColor = false;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // btnPathRestore
            // 
            this.btnPathRestore.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPathRestore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathRestore.ForeColor = System.Drawing.Color.White;
            this.btnPathRestore.Location = new System.Drawing.Point(462, 240);
            this.btnPathRestore.Name = "btnPathRestore";
            this.btnPathRestore.Size = new System.Drawing.Size(52, 27);
            this.btnPathRestore.TabIndex = 103;
            this.btnPathRestore.Text = "...";
            this.btnPathRestore.UseVisualStyleBackColor = false;
            this.btnPathRestore.Click += new System.EventHandler(this.btnPathRestore_Click);
            // 
            // txtPathRestore
            // 
            this.txtPathRestore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathRestore.Location = new System.Drawing.Point(47, 241);
            this.txtPathRestore.Name = "txtPathRestore";
            this.txtPathRestore.Size = new System.Drawing.Size(409, 27);
            this.txtPathRestore.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(8, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 101;
            this.label2.Text = "File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 376);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(531, 22);
            this.statusStrip2.TabIndex = 106;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 314);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(503, 23);
            this.progressBar2.TabIndex = 105;
            this.progressBar2.Visible = false;
            // 
            // lbl_hoadon
            // 
            this.lbl_hoadon.AutoSize = true;
            this.lbl_hoadon.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoadon.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_hoadon.Location = new System.Drawing.Point(183, 7);
            this.lbl_hoadon.Name = "lbl_hoadon";
            this.lbl_hoadon.Size = new System.Drawing.Size(158, 45);
            this.lbl_hoadon.TabIndex = 108;
            this.lbl_hoadon.Text = "SAO LƯU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(183, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 45);
            this.label3.TabIndex = 109;
            this.label3.Text = "PHỤC HỒI";
            // 
            // frm_BackupDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 420);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_hoadon);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.btnPathRestore);
            this.Controls.Add(this.txtPathRestore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPathBackup);
            this.Controls.Add(this.btn_Backup);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Name = "frm_BackupDatabase";
            this.Text = "SAO LƯU DỮ LIỆU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Button btnPathBackup;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.Button btnPathRestore;
        private System.Windows.Forms.TextBox txtPathRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lbl_hoadon;
        private System.Windows.Forms.Label label3;
    }
}