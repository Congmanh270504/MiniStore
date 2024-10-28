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
            this.btn_saoluu = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "File";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(51, 18);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(409, 27);
            this.txtPath.TabIndex = 92;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 91);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(503, 23);
            this.progressBar1.TabIndex = 94;
            this.progressBar1.Visible = false;
            // 
            // btn_saoluu
            // 
            this.btn_saoluu.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_saoluu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saoluu.ForeColor = System.Drawing.Color.White;
            this.btn_saoluu.Location = new System.Drawing.Point(419, 51);
            this.btn_saoluu.Name = "btn_saoluu";
            this.btn_saoluu.Size = new System.Drawing.Size(100, 34);
            this.btn_saoluu.TabIndex = 95;
            this.btn_saoluu.Text = "SAO LƯU";
            this.btn_saoluu.UseVisualStyleBackColor = false;
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.ForeColor = System.Drawing.Color.White;
            this.btnPath.Location = new System.Drawing.Point(467, 18);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(52, 27);
            this.btnPath.TabIndex = 96;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 115);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(531, 22);
            this.statusStrip1.TabIndex = 97;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frm_BackupDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 137);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btn_saoluu);
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
        private System.Windows.Forms.Button btn_saoluu;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}