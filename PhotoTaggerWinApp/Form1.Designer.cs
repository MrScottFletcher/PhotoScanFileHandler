
namespace PhotoTaggerWinApp
{
    partial class Form1
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
            this.fsw1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.testButton = new System.Windows.Forms.Button();
            this.testFileTextBox1 = new System.Windows.Forms.TextBox();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.closeFrontImageButton = new System.Windows.Forms.Button();
            this.saveOpenChangesButton = new System.Windows.Forms.Button();
            this.closeBackImageButton = new System.Windows.Forms.Button();
            this.fileChangeListBox = new System.Windows.Forms.ListBox();
            this.abandonBackImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backFileNameTextBox = new System.Windows.Forms.TextBox();
            this.frontFileNameLabel = new System.Windows.Forms.Label();
            this.frontFileNameTextBox = new System.Windows.Forms.TextBox();
            this.unlinkButton = new System.Windows.Forms.Button();
            this.swapButton = new System.Windows.Forms.Button();
            this.backPictureBox = new System.Windows.Forms.PictureBox();
            this.backLabel = new System.Windows.Forms.Label();
            this.frontPictureBox = new System.Windows.Forms.PictureBox();
            this.frontLabel = new System.Windows.Forms.Label();
            this.targetPathTextBox = new System.Windows.Forms.TextBox();
            this.appendFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.watchFolderTextBox = new System.Windows.Forms.TextBox();
            this.startMonitorButton = new System.Windows.Forms.Button();
            this.stopMonitorButton = new System.Windows.Forms.Button();
            this.forceGetButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.backResultingFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.frontResultingFileNameTextBox = new System.Windows.Forms.TextBox();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fsw1)).BeginInit();
            this.filesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fsw1
            // 
            this.fsw1.EnableRaisingEvents = true;
            this.fsw1.NotifyFilter = ((System.IO.NotifyFilters)((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.CreationTime)));
            this.fsw1.SynchronizingObject = this;
            this.fsw1.Created += new System.IO.FileSystemEventHandler(this.fsw1_Created);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(51, 16);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 54);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // testFileTextBox1
            // 
            this.testFileTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testFileTextBox1.Location = new System.Drawing.Point(238, 24);
            this.testFileTextBox1.Name = "testFileTextBox1";
            this.testFileTextBox1.Size = new System.Drawing.Size(1007, 20);
            this.testFileTextBox1.TabIndex = 1;
            this.testFileTextBox1.Text = "C:\\Temp_ScanTest\\Front.jpg";
            // 
            // filesGroupBox
            // 
            this.filesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesGroupBox.Controls.Add(this.propertiesGroupBox);
            this.filesGroupBox.Controls.Add(this.label9);
            this.filesGroupBox.Controls.Add(this.backResultingFileNameTextBox);
            this.filesGroupBox.Controls.Add(this.label10);
            this.filesGroupBox.Controls.Add(this.frontResultingFileNameTextBox);
            this.filesGroupBox.Controls.Add(this.closeFrontImageButton);
            this.filesGroupBox.Controls.Add(this.saveOpenChangesButton);
            this.filesGroupBox.Controls.Add(this.closeBackImageButton);
            this.filesGroupBox.Controls.Add(this.fileChangeListBox);
            this.filesGroupBox.Controls.Add(this.abandonBackImage);
            this.filesGroupBox.Controls.Add(this.label5);
            this.filesGroupBox.Controls.Add(this.label6);
            this.filesGroupBox.Controls.Add(this.label7);
            this.filesGroupBox.Controls.Add(this.textBox3);
            this.filesGroupBox.Controls.Add(this.textBox4);
            this.filesGroupBox.Controls.Add(this.textBox5);
            this.filesGroupBox.Controls.Add(this.label1);
            this.filesGroupBox.Controls.Add(this.backFileNameTextBox);
            this.filesGroupBox.Controls.Add(this.frontFileNameLabel);
            this.filesGroupBox.Controls.Add(this.frontFileNameTextBox);
            this.filesGroupBox.Controls.Add(this.unlinkButton);
            this.filesGroupBox.Controls.Add(this.swapButton);
            this.filesGroupBox.Controls.Add(this.backPictureBox);
            this.filesGroupBox.Controls.Add(this.backLabel);
            this.filesGroupBox.Controls.Add(this.frontPictureBox);
            this.filesGroupBox.Controls.Add(this.frontLabel);
            this.filesGroupBox.Location = new System.Drawing.Point(42, 110);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(1203, 767);
            this.filesGroupBox.TabIndex = 3;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "Files Info";
            // 
            // closeFrontImageButton
            // 
            this.closeFrontImageButton.Location = new System.Drawing.Point(599, 393);
            this.closeFrontImageButton.Name = "closeFrontImageButton";
            this.closeFrontImageButton.Size = new System.Drawing.Size(75, 23);
            this.closeFrontImageButton.TabIndex = 24;
            this.closeFrontImageButton.Text = "Close File";
            this.closeFrontImageButton.UseVisualStyleBackColor = true;
            this.closeFrontImageButton.Click += new System.EventHandler(this.closeFrontImageButton_Click);
            // 
            // saveOpenChangesButton
            // 
            this.saveOpenChangesButton.Location = new System.Drawing.Point(351, 382);
            this.saveOpenChangesButton.Name = "saveOpenChangesButton";
            this.saveOpenChangesButton.Size = new System.Drawing.Size(113, 44);
            this.saveOpenChangesButton.TabIndex = 22;
            this.saveOpenChangesButton.Text = "Save Open Files";
            this.saveOpenChangesButton.UseVisualStyleBackColor = true;
            // 
            // closeBackImageButton
            // 
            this.closeBackImageButton.Location = new System.Drawing.Point(158, 393);
            this.closeBackImageButton.Name = "closeBackImageButton";
            this.closeBackImageButton.Size = new System.Drawing.Size(75, 23);
            this.closeBackImageButton.TabIndex = 22;
            this.closeBackImageButton.Text = "Close File";
            this.closeBackImageButton.UseVisualStyleBackColor = true;
            this.closeBackImageButton.Click += new System.EventHandler(this.closeBackImageButton_Click);
            // 
            // fileChangeListBox
            // 
            this.fileChangeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileChangeListBox.FormattingEnabled = true;
            this.fileChangeListBox.Location = new System.Drawing.Point(817, 90);
            this.fileChangeListBox.Name = "fileChangeListBox";
            this.fileChangeListBox.Size = new System.Drawing.Size(363, 498);
            this.fileChangeListBox.TabIndex = 23;
            this.fileChangeListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileChangeListBox_DragDrop);
            this.fileChangeListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileChangeListBox_DragEnter);
            this.fileChangeListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fileChangeListBox_MouseDown);
            // 
            // abandonBackImage
            // 
            this.abandonBackImage.BackColor = System.Drawing.SystemColors.Info;
            this.abandonBackImage.Location = new System.Drawing.Point(123, 88);
            this.abandonBackImage.Name = "abandonBackImage";
            this.abandonBackImage.Size = new System.Drawing.Size(149, 23);
            this.abandonBackImage.TabIndex = 18;
            this.abandonBackImage.Text = "Abandon Back Image";
            this.abandonBackImage.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 727);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Append Name with";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 701);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Target Folder";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 674);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Source";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(123, 724);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(621, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "_tagged";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(123, 698);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1007, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "C:\\Temp_ScanTest\\";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(123, 672);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1007, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "C:\\Temp_ScanTest\\Front.jpg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filename";
            // 
            // backFileNameTextBox
            // 
            this.backFileNameTextBox.Location = new System.Drawing.Point(123, 36);
            this.backFileNameTextBox.Name = "backFileNameTextBox";
            this.backFileNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.backFileNameTextBox.TabIndex = 10;
            // 
            // frontFileNameLabel
            // 
            this.frontFileNameLabel.AutoSize = true;
            this.frontFileNameLabel.Location = new System.Drawing.Point(453, 39);
            this.frontFileNameLabel.Name = "frontFileNameLabel";
            this.frontFileNameLabel.Size = new System.Drawing.Size(49, 13);
            this.frontFileNameLabel.TabIndex = 9;
            this.frontFileNameLabel.Text = "Filename";
            // 
            // frontFileNameTextBox
            // 
            this.frontFileNameTextBox.Location = new System.Drawing.Point(508, 37);
            this.frontFileNameTextBox.Name = "frontFileNameTextBox";
            this.frontFileNameTextBox.Size = new System.Drawing.Size(205, 20);
            this.frontFileNameTextBox.TabIndex = 8;
            // 
            // unlinkButton
            // 
            this.unlinkButton.Location = new System.Drawing.Point(352, 90);
            this.unlinkButton.Name = "unlinkButton";
            this.unlinkButton.Size = new System.Drawing.Size(112, 23);
            this.unlinkButton.TabIndex = 7;
            this.unlinkButton.Text = "-> Unlink Back<-";
            this.unlinkButton.UseVisualStyleBackColor = true;
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(368, 225);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(75, 67);
            this.swapButton.TabIndex = 7;
            this.swapButton.Text = "<- SWAP ->";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // backPictureBox
            // 
            this.backPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backPictureBox.Location = new System.Drawing.Point(26, 117);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new System.Drawing.Size(327, 261);
            this.backPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPictureBox.TabIndex = 6;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.backPictureBox_DragDrop);
            this.backPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.Location = new System.Drawing.Point(155, 16);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(46, 18);
            this.backLabel.TabIndex = 5;
            this.backLabel.Text = "Back";
            // 
            // frontPictureBox
            // 
            this.frontPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frontPictureBox.Location = new System.Drawing.Point(461, 117);
            this.frontPictureBox.Name = "frontPictureBox";
            this.frontPictureBox.Size = new System.Drawing.Size(327, 261);
            this.frontPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frontPictureBox.TabIndex = 4;
            this.frontPictureBox.TabStop = false;
            this.frontPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.frontPictureBox_DragDrop);
            this.frontPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            // 
            // frontLabel
            // 
            this.frontLabel.AutoSize = true;
            this.frontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontLabel.Location = new System.Drawing.Point(596, 16);
            this.frontLabel.Name = "frontLabel";
            this.frontLabel.Size = new System.Drawing.Size(48, 18);
            this.frontLabel.TabIndex = 3;
            this.frontLabel.Text = "Front";
            // 
            // targetPathTextBox
            // 
            this.targetPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetPathTextBox.Location = new System.Drawing.Point(238, 50);
            this.targetPathTextBox.Name = "targetPathTextBox";
            this.targetPathTextBox.Size = new System.Drawing.Size(1007, 20);
            this.targetPathTextBox.TabIndex = 4;
            this.targetPathTextBox.Text = "C:\\Temp_ScanTest\\";
            // 
            // appendFileNameTextBox
            // 
            this.appendFileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appendFileNameTextBox.Location = new System.Drawing.Point(238, 76);
            this.appendFileNameTextBox.Name = "appendFileNameTextBox";
            this.appendFileNameTextBox.Size = new System.Drawing.Size(621, 20);
            this.appendFileNameTextBox.TabIndex = 5;
            this.appendFileNameTextBox.Text = "_tagged";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Target Folder";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Append Name with";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveButton.Location = new System.Drawing.Point(572, 883);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(140, 55);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Watch Folder";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // watchFolderTextBox
            // 
            this.watchFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.watchFolderTextBox.Location = new System.Drawing.Point(238, 0);
            this.watchFolderTextBox.Name = "watchFolderTextBox";
            this.watchFolderTextBox.Size = new System.Drawing.Size(1007, 20);
            this.watchFolderTextBox.TabIndex = 18;
            this.watchFolderTextBox.Text = "C:\\Temp_ScanTest\\";
            // 
            // startMonitorButton
            // 
            this.startMonitorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startMonitorButton.Location = new System.Drawing.Point(1074, 79);
            this.startMonitorButton.Name = "startMonitorButton";
            this.startMonitorButton.Size = new System.Drawing.Size(75, 23);
            this.startMonitorButton.TabIndex = 20;
            this.startMonitorButton.Text = "Start Monitor";
            this.startMonitorButton.UseVisualStyleBackColor = true;
            this.startMonitorButton.Click += new System.EventHandler(this.startMonitorButton_Click);
            // 
            // stopMonitorButton
            // 
            this.stopMonitorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopMonitorButton.Location = new System.Drawing.Point(1155, 79);
            this.stopMonitorButton.Name = "stopMonitorButton";
            this.stopMonitorButton.Size = new System.Drawing.Size(75, 23);
            this.stopMonitorButton.TabIndex = 21;
            this.stopMonitorButton.Text = "Stop Monitor";
            this.stopMonitorButton.UseVisualStyleBackColor = true;
            this.stopMonitorButton.Click += new System.EventHandler(this.stopMonitorButton_Click);
            // 
            // forceGetButton
            // 
            this.forceGetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.forceGetButton.Enabled = false;
            this.forceGetButton.Location = new System.Drawing.Point(913, 79);
            this.forceGetButton.Name = "forceGetButton";
            this.forceGetButton.Size = new System.Drawing.Size(147, 23);
            this.forceGetButton.TabIndex = 20;
            this.forceGetButton.Text = "Force Get Latest two";
            this.forceGetButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Resulting Filename";
            // 
            // backResultingFileNameTextBox
            // 
            this.backResultingFileNameTextBox.Location = new System.Drawing.Point(123, 62);
            this.backResultingFileNameTextBox.Name = "backResultingFileNameTextBox";
            this.backResultingFileNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.backResultingFileNameTextBox.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(406, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Resulting Filename";
            // 
            // frontResultingFileNameTextBox
            // 
            this.frontResultingFileNameTextBox.Location = new System.Drawing.Point(508, 63);
            this.frontResultingFileNameTextBox.Name = "frontResultingFileNameTextBox";
            this.frontResultingFileNameTextBox.Size = new System.Drawing.Size(205, 20);
            this.frontResultingFileNameTextBox.TabIndex = 25;
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.propertiesGroupBox.Location = new System.Drawing.Point(26, 432);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(760, 213);
            this.propertiesGroupBox.TabIndex = 29;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Properties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 950);
            this.Controls.Add(this.stopMonitorButton);
            this.Controls.Add(this.forceGetButton);
            this.Controls.Add(this.startMonitorButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.watchFolderTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appendFileNameTextBox);
            this.Controls.Add(this.targetPathTextBox);
            this.Controls.Add(this.filesGroupBox);
            this.Controls.Add(this.testFileTextBox1);
            this.Controls.Add(this.testButton);
            this.Name = "Form1";
            this.Text = "Photo Tagger";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fsw1)).EndInit();
            this.filesGroupBox.ResumeLayout(false);
            this.filesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fsw1;
        private System.Windows.Forms.TextBox testFileTextBox1;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.Label frontLabel;
        private System.Windows.Forms.TextBox targetPathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox appendFileNameTextBox;
        private System.Windows.Forms.PictureBox frontPictureBox;
        private System.Windows.Forms.PictureBox backPictureBox;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox backFileNameTextBox;
        private System.Windows.Forms.Label frontFileNameLabel;
        private System.Windows.Forms.TextBox frontFileNameTextBox;
        private System.Windows.Forms.Button swapButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox watchFolderTextBox;
        private System.Windows.Forms.Button stopMonitorButton;
        private System.Windows.Forms.Button startMonitorButton;
        private System.Windows.Forms.Button abandonBackImage;
        private System.Windows.Forms.Button unlinkButton;
        private System.Windows.Forms.Button forceGetButton;
        private System.Windows.Forms.ListBox fileChangeListBox;
        private System.Windows.Forms.Button closeFrontImageButton;
        private System.Windows.Forms.Button saveOpenChangesButton;
        private System.Windows.Forms.Button closeBackImageButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox backResultingFileNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox frontResultingFileNameTextBox;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
    }
}

