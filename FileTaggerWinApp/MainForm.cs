using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack;



namespace FileTaggerWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            JpegMetadataAdapter j = new JpegMetadataAdapter("blah");
            //j.Metadata.Location
            //j.Metadata.Rating
            //j.Metadata.Title
            //j.Metadata.Subject
            //j.Metadata.Comment
            //j.Metadata.Copyright
            //j.Metadata.DateTaken

            //Date Acquired
            //
        }
 
        public static void Main(string[] args)
        {
            List<string> arrHeaders = new List<string>();

            Shell32.Shell shell = new Shell32.Shell();
            Shell32.Folder objFolder;

            objFolder = shell.NameSpace(@"C:\temp\testprop");

            for (int i = 0; i < short.MaxValue; i++)
            {
                string header = objFolder.GetDetailsOf(null, i);
                if (String.IsNullOrEmpty(header))
                    break;
                arrHeaders.Add(header);
            }

            foreach (Shell32.FolderItem2 item in objFolder.Items())
            {
                for (int i = 0; i < arrHeaders.Count; i++)
                {
                    Console.WriteLine(
                      $"{i}\t{arrHeaders[i]}: {objFolder.GetDetailsOf(item, i)}");
                }
            }
        }


        /*
         * https://stackoverflow.com/questions/24040248/is-it-possible-to-set-edit-a-file-extended-properties-with-windows-api-code-pack/51188687#51188687
         * This should also work?
         * var shellFile = ShellFile.FromFilePath(filePath);
         * shellFile.Properties.System.Author.Value = new string[] { "MyTest", "Test" };
         * shellFile.Properties.System.Music.Artist.Value = new string[] { "MyTest", "Test" };
         * shellFile.Properties.System.Music.DisplayArtist.Value = "Test";
        */

    }
}



//https://officetricks.com/excel-vba-get-file-property-author-modified-date-time/

//https://learn.microsoft.com/en-us/windows/win32/shell/folder-getdetailsof

