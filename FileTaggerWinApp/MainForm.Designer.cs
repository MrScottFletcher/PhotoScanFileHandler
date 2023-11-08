
namespace FileTaggerWinApp
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCurrentFile = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.dgFiles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpCurrentFile = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblDateTaken = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBatch = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCurrentFile.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).BeginInit();
            this.grpCurrentFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabCurrentFile);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(339, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 738);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCurrentFile
            // 
            this.tabCurrentFile.Controls.Add(this.grpBatch);
            this.tabCurrentFile.Controls.Add(this.grpCurrentFile);
            this.tabCurrentFile.Location = new System.Drawing.Point(4, 22);
            this.tabCurrentFile.Name = "tabCurrentFile";
            this.tabCurrentFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrentFile.Size = new System.Drawing.Size(440, 712);
            this.tabCurrentFile.TabIndex = 0;
            this.tabCurrentFile.Text = "Current File";
            this.tabCurrentFile.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.textBox2);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(440, 394);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // dgFiles
            // 
            this.dgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiles.Location = new System.Drawing.Point(12, 34);
            this.dgFiles.Name = "dgFiles";
            this.dgFiles.Size = new System.Drawing.Size(322, 276);
            this.dgFiles.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // grpCurrentFile
            // 
            this.grpCurrentFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCurrentFile.Controls.Add(this.txtFileName);
            this.grpCurrentFile.Controls.Add(this.lblFileName);
            this.grpCurrentFile.Controls.Add(this.txtCopyright);
            this.grpCurrentFile.Controls.Add(this.lblCopyright);
            this.grpCurrentFile.Controls.Add(this.lblDateTaken);
            this.grpCurrentFile.Controls.Add(this.dateTimePicker1);
            this.grpCurrentFile.Controls.Add(this.textBox1);
            this.grpCurrentFile.Controls.Add(this.lblComments);
            this.grpCurrentFile.Controls.Add(this.txtTitle);
            this.grpCurrentFile.Controls.Add(this.lblTitle);
            this.grpCurrentFile.Location = new System.Drawing.Point(12, 6);
            this.grpCurrentFile.Name = "grpCurrentFile";
            this.grpCurrentFile.Size = new System.Drawing.Size(422, 378);
            this.grpCurrentFile.TabIndex = 10;
            this.grpCurrentFile.TabStop = false;
            this.grpCurrentFile.Text = "Current File";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(66, 29);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(352, 20);
            this.txtFileName.TabIndex = 19;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(4, 32);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(49, 13);
            this.lblFileName.TabIndex = 18;
            this.lblFileName.Text = "Filename";
            // 
            // txtCopyright
            // 
            this.txtCopyright.Location = new System.Drawing.Point(66, 294);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(281, 20);
            this.txtCopyright.TabIndex = 17;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(4, 297);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(51, 13);
            this.lblCopyright.TabIndex = 16;
            this.lblCopyright.Text = "Copyright";
            // 
            // lblDateTaken
            // 
            this.lblDateTaken.AutoSize = true;
            this.lblDateTaken.Location = new System.Drawing.Point(4, 275);
            this.lblDateTaken.Name = "lblDateTaken";
            this.lblDateTaken.Size = new System.Drawing.Size(38, 13);
            this.lblDateTaken.TabIndex = 15;
            this.lblDateTaken.Text = "Taken";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 166);
            this.textBox1.TabIndex = 13;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(4, 84);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 12;
            this.lblComments.Text = "Comments";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(66, 55);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(352, 20);
            this.txtTitle.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(4, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title";
            // 
            // grpBatch
            // 
            this.grpBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBatch.Location = new System.Drawing.Point(12, 400);
            this.grpBatch.Name = "grpBatch";
            this.grpBatch.Size = new System.Drawing.Size(418, 306);
            this.grpBatch.TabIndex = 11;
            this.grpBatch.TabStop = false;
            this.grpBatch.Text = "Current Batch Settings";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(131, 381);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 755);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.dgFiles);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "FileTagger App";
            this.tabControl1.ResumeLayout(false);
            this.tabCurrentFile.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).EndInit();
            this.grpCurrentFile.ResumeLayout(false);
            this.grpCurrentFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCurrentFile;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.DataGridView dgFiles;
        private System.Windows.Forms.GroupBox grpCurrentFile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblDateTaken;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBatch;
        private System.Windows.Forms.Button btnTest;
    }
}

