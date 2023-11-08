using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoTaggerWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //         // Allow the ListBox to be a drag-and-drop source
            //listBox1.AllowDrop = true;
            //// Allow the PictureBox to be a drag-and-drop target
            //pictureBox1.AllowDrop = true;

            //// Subscribe to the ListBox's DragDrop and DragEnter events
            //listBox1.DragDrop += ListBox_DragDrop;
            //listBox1.DragEnter += ListBox_DragEnter;

            //// Subscribe to the PictureBox's DragEnter and DragDrop events
            //pictureBox1.DragEnter += PictureBox_DragEnter;
            //pictureBox1.DragDrop += PictureBox_DragDrop;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fsw1.Path = watchFolderTextBox.Text;
            fsw1.EnableRaisingEvents = true;
            backPictureBox.AllowDrop = true;
            frontPictureBox.AllowDrop = true;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            try
            {
                PropertyWriter w = new PropertyWriter();
                w.Test3(this.testFileTextBox1.Text, targetPathTextBox.Text, appendFileNameTextBox.Text );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void fsw1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            //MessageBox.Show(e.FullPath + " ---- " + e.ChangeType.ToString());
            string fullPath = e.FullPath;

            SetFrontOrBackImage(fullPath);
        }

        private void SetFrontOrBackImage(string fullPath)
        {
            SetImageInEmptySlot(fullPath);
        }

        private void SetImageInEmptySlot(string fullPath)
        {
            fileChangeListBox.Items.Insert(0, fullPath);

            PictureBox p = null;
            TextBox t = null;

            if (backPictureBox.Image == null)
            {
                p = backPictureBox;
                t = backFileNameTextBox;
            }
            else if (frontPictureBox.Image == null)
            {
                p = frontPictureBox;
                t = frontFileNameTextBox;
            }
            if (t != null && p != null)
            {
                t.Text = fullPath;
                p.Image = Image.FromFile(fullPath);
            }
        }


        private void closeBackImageButton_Click(object sender, EventArgs e)
        {
            CloseBackImage();
        }

        private void closeFrontImageButton_Click(object sender, EventArgs e)
        {
            CloseFrontImage();
        }

        private void CloseFrontImage()
        {
            CloseImage(frontPictureBox);
        }

        private void CloseBackImage()
        {
            CloseImage(backPictureBox);
        }

        private void CloseImage(PictureBox box)
        {
            if (box.Image != null)
            {
                Image img = box.Image;
                box.Image = null;
                img.Dispose();
            }
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            SwapFrontAndBack();
        }

        private void SwapFrontAndBack()
        {
            Image f = frontPictureBox.Image;
            Image b = backPictureBox.Image;

            string fs = frontFileNameTextBox.Text;
            string bs = backFileNameTextBox.Text;
            //--------------------------
            frontPictureBox.Image = null;
            backPictureBox.Image = null;
            //--------------------------
            frontPictureBox.Image = b;
            backPictureBox.Image = f;

            frontFileNameTextBox.Text = bs;
            backFileNameTextBox.Text = fs;

        }

        private void startMonitorButton_Click(object sender, EventArgs e)
        {
            fsw1.EnableRaisingEvents = true;
        }

        private void stopMonitorButton_Click(object sender, EventArgs e)
        {
            fsw1.EnableRaisingEvents = false;
        }

        private void frontPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string droppedText = (string)e.Data.GetData(DataFormats.Text);

                if (!String.IsNullOrEmpty(droppedText))
                {
                    CloseFrontImage();
                    frontFileNameTextBox.Text = droppedText;
                    frontPictureBox.Image = Image.FromFile(droppedText);
                }
            }
        }

        private void backPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            // Get the dropped text and display it on the PictureBox
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string droppedText = (string)e.Data.GetData(DataFormats.Text);

                if (!String.IsNullOrEmpty(droppedText))
                {
                    CloseBackImage();
                    backFileNameTextBox.Text = droppedText;
                    backPictureBox.Image = Image.FromFile(droppedText);
                }
            }
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the data being dragged is text
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void fileChangeListBox_DragDrop(object sender, DragEventArgs e)
        {
            //// Get the dropped text and display it on the PictureBox
            //if (e.Data.GetDataPresent(DataFormats.Text))
            //{
            //    string droppedText = (string)e.Data.GetData(DataFormats.Text);
            //    pictureBox1.Text = droppedText;
            //}
        }

        private void fileChangeListBox_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the data being dragged is text
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void fileChangeListBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Start the drag-and-drop operation from the ListBox
            int index = fileChangeListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string selectedText = fileChangeListBox.Items[index].ToString();
                fileChangeListBox.DoDragDrop(selectedText, DragDropEffects.Copy);
            }
        }
    }
}
