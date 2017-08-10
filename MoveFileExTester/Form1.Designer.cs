namespace MoveFileExTester
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxSourceFileName = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.textBoxTargetFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxWriteThorugh = new System.Windows.Forms.CheckBox();
            this.checkBoxReplaceExisting = new System.Windows.Forms.CheckBox();
            this.checkBoxFailIfNotTrackable = new System.Windows.Forms.CheckBox();
            this.checkBoxDelayUntilReboot = new System.Windows.Forms.CheckBox();
            this.checkBoxCreateHardlink = new System.Windows.Forms.CheckBox();
            this.checkBoxCopyAllowd = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxIsNull = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(369, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Browse...";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxSourceFileName
            // 
            this.textBoxSourceFileName.Location = new System.Drawing.Point(95, 14);
            this.textBoxSourceFileName.Name = "textBoxSourceFileName";
            this.textBoxSourceFileName.Size = new System.Drawing.Size(268, 19);
            this.textBoxSourceFileName.TabIndex = 1;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(369, 41);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFolder.TabIndex = 5;
            this.buttonSelectFolder.Text = "Browse...";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // textBoxTargetFolder
            // 
            this.textBoxTargetFolder.Location = new System.Drawing.Point(95, 43);
            this.textBoxTargetFolder.Name = "textBoxTargetFolder";
            this.textBoxTargetFolder.Size = new System.Drawing.Size(268, 19);
            this.textBoxTargetFolder.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source file : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target folder : ";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(454, 232);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 8;
            this.buttonExecute.Text = "Run";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxWriteThorugh);
            this.groupBox1.Controls.Add(this.checkBoxReplaceExisting);
            this.groupBox1.Controls.Add(this.checkBoxFailIfNotTrackable);
            this.groupBox1.Controls.Add(this.checkBoxDelayUntilReboot);
            this.groupBox1.Controls.Add(this.checkBoxCreateHardlink);
            this.groupBox1.Controls.Add(this.checkBoxCopyAllowd);
            this.groupBox1.Location = new System.Drawing.Point(85, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // checkBoxWriteThorugh
            // 
            this.checkBoxWriteThorugh.AutoSize = true;
            this.checkBoxWriteThorugh.Location = new System.Drawing.Point(13, 132);
            this.checkBoxWriteThorugh.Name = "checkBoxWriteThorugh";
            this.checkBoxWriteThorugh.Size = new System.Drawing.Size(176, 16);
            this.checkBoxWriteThorugh.TabIndex = 5;
            this.checkBoxWriteThorugh.Text = "MOVEFILE_WRITE_THROUGH";
            this.checkBoxWriteThorugh.UseVisualStyleBackColor = true;
            // 
            // checkBoxReplaceExisting
            // 
            this.checkBoxReplaceExisting.AutoSize = true;
            this.checkBoxReplaceExisting.Location = new System.Drawing.Point(13, 110);
            this.checkBoxReplaceExisting.Name = "checkBoxReplaceExisting";
            this.checkBoxReplaceExisting.Size = new System.Drawing.Size(188, 16);
            this.checkBoxReplaceExisting.TabIndex = 4;
            this.checkBoxReplaceExisting.Text = "MOVEFILE_REPLACE_EXISTING";
            this.checkBoxReplaceExisting.UseVisualStyleBackColor = true;
            // 
            // checkBoxFailIfNotTrackable
            // 
            this.checkBoxFailIfNotTrackable.AutoSize = true;
            this.checkBoxFailIfNotTrackable.Location = new System.Drawing.Point(13, 88);
            this.checkBoxFailIfNotTrackable.Name = "checkBoxFailIfNotTrackable";
            this.checkBoxFailIfNotTrackable.Size = new System.Drawing.Size(219, 16);
            this.checkBoxFailIfNotTrackable.TabIndex = 3;
            this.checkBoxFailIfNotTrackable.Text = "MOVEFILE_FAIL_IF_NOT_TRACKABLE";
            this.checkBoxFailIfNotTrackable.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelayUntilReboot
            // 
            this.checkBoxDelayUntilReboot.AutoSize = true;
            this.checkBoxDelayUntilReboot.Location = new System.Drawing.Point(13, 66);
            this.checkBoxDelayUntilReboot.Name = "checkBoxDelayUntilReboot";
            this.checkBoxDelayUntilReboot.Size = new System.Drawing.Size(205, 16);
            this.checkBoxDelayUntilReboot.TabIndex = 2;
            this.checkBoxDelayUntilReboot.Text = "MOVEFILE_DELAY_UNTIL_REBOOT";
            this.checkBoxDelayUntilReboot.UseVisualStyleBackColor = true;
            // 
            // checkBoxCreateHardlink
            // 
            this.checkBoxCreateHardlink.AutoSize = true;
            this.checkBoxCreateHardlink.Location = new System.Drawing.Point(13, 44);
            this.checkBoxCreateHardlink.Name = "checkBoxCreateHardlink";
            this.checkBoxCreateHardlink.Size = new System.Drawing.Size(188, 16);
            this.checkBoxCreateHardlink.TabIndex = 1;
            this.checkBoxCreateHardlink.Text = "MOVEFILE_CREATE_HARDLINK";
            this.checkBoxCreateHardlink.UseVisualStyleBackColor = true;
            // 
            // checkBoxCopyAllowd
            // 
            this.checkBoxCopyAllowd.AutoSize = true;
            this.checkBoxCopyAllowd.Location = new System.Drawing.Point(13, 22);
            this.checkBoxCopyAllowd.Name = "checkBoxCopyAllowd";
            this.checkBoxCopyAllowd.Size = new System.Drawing.Size(169, 16);
            this.checkBoxCopyAllowd.TabIndex = 0;
            this.checkBoxCopyAllowd.Text = "MOVEFILE_COPY_ALLOWED";
            this.checkBoxCopyAllowd.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsNull
            // 
            this.checkBoxIsNull.AutoSize = true;
            this.checkBoxIsNull.Location = new System.Drawing.Point(450, 43);
            this.checkBoxIsNull.Name = "checkBoxIsNull";
            this.checkBoxIsNull.Size = new System.Drawing.Size(52, 16);
            this.checkBoxIsNull.TabIndex = 6;
            this.checkBoxIsNull.Text = "NULL";
            this.checkBoxIsNull.UseVisualStyleBackColor = true;
            this.checkBoxIsNull.CheckedChanged += new System.EventHandler(this.checkBoxIsNull_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 267);
            this.Controls.Add(this.checkBoxIsNull);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTargetFolder);
            this.Controls.Add(this.textBoxSourceFileName);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.buttonOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "MoveFileExTester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxSourceFileName;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.TextBox textBoxTargetFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxWriteThorugh;
        private System.Windows.Forms.CheckBox checkBoxReplaceExisting;
        private System.Windows.Forms.CheckBox checkBoxFailIfNotTrackable;
        private System.Windows.Forms.CheckBox checkBoxDelayUntilReboot;
        private System.Windows.Forms.CheckBox checkBoxCreateHardlink;
        private System.Windows.Forms.CheckBox checkBoxCopyAllowd;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox checkBoxIsNull;
    }
}

