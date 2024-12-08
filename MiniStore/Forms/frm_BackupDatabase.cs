using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL;
namespace MiniStore.Forms
{
    public partial class frm_BackupDatabase : Form
    {
        DBConnect db;
        public frm_BackupDatabase()
        {
            InitializeComponent();
            db = new DBConnect("miniMKT");
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string path = txtPath.Text + "\\MiniStore-" + date + ".bak";
            if (string.IsNullOrEmpty(txtPath.Text))
            {
                MessageBox.Show("Bạn chưa chọn đường dẫn để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string database = db.strDBName.ToString();
                string cmd = "BACKUP DATABASE " + database + " TO DISK = '" + path + "'";
                db.updateToDataBase(cmd);
                txtPath.Clear();
                MessageBox.Show("Sao lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Sao lưu dữ liệu thất bại", "Backup", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
        }

        private void btnPathRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak";
            dlg.Title = "Select backup file";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPathRestore.Text = dlg.FileName;
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            string database = db.strDBName.ToString();
            db.openConnect();
            if (string.IsNullOrEmpty(txtPathRestore.Text))
            {
                MessageBox.Show("Bạn chưa chọn đường dẫn để phục hồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    string strl = "ALTER DATABASE[" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    db.updateToDataBase(strl);
                    string cmd = "USE master RESTORE DATABASE[" + database + "] FROM DISK = '" + txtPathRestore.Text + "' WITH REPLACE";
                    db.updateToDataBase(cmd);
                    string str2 = "ALTER DATABASE[" + database + "] SET MULTI_USER";
                    db.updateToDataBase(str2);
                    MessageBox.Show("Phục hồi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Phục hồi dữ liệu thất bại", "Restore", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
    }
}
