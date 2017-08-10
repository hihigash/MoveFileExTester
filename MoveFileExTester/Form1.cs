using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveFileExTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            this.textBoxSourceFileName.Text = openFileDialog.FileName;
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;

            this.textBoxTargetFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void checkBoxIsNull_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = !((CheckBox) sender).Checked;

            this.textBoxTargetFolder.Enabled = @checked;
            this.buttonSelectFolder.Enabled = @checked;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string sourcePath = this.textBoxSourceFileName.Text;
            string targetPath = (this.checkBoxIsNull.Checked) ? null : Path.Combine(this.textBoxTargetFolder.Text, Path.GetFileName(sourcePath));
            MoveFileFlags flags = GetMoveFileOptions();

            var result = NativeMethods.MoveFileEx(sourcePath, targetPath, flags);
            if (result)
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show($"Failed (0x{NativeMethods.GetLastError():x8})");
            }
        }

        private MoveFileFlags GetMoveFileOptions()
        {
            var result = MoveFileFlags.None;

            if (this.checkBoxCopyAllowd.Checked) result |= MoveFileFlags.CopyAllowed;
            if (this.checkBoxCreateHardlink.Checked) result |= MoveFileFlags.CreateHardlink;
            if (this.checkBoxDelayUntilReboot.Checked) result |= MoveFileFlags.DelayUntilReboot;
            if (this.checkBoxFailIfNotTrackable.Checked) result |= MoveFileFlags.FailIfNotTrackable;
            if (this.checkBoxReplaceExisting.Checked) result |= MoveFileFlags.ReplaceExisting;
            if (this.checkBoxWriteThorugh.Checked) result |= MoveFileFlags.WriteThrough;
            
            return result;
        }
    }
}
