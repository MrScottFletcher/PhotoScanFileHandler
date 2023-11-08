using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Microsoft.WindowsAPICodePack.Shell;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Serialization;
using System.IO;

namespace PhotoTaggerWinApp
{
    public class PropertyWriter
    {
        public void Test(string filePath)
        {
            ShellPropertyWriter w = null;
            try
            {
                var shellFile = ShellFile.FromParsingName(filePath);
                w = shellFile.Properties.GetPropertyWriter();
                try
                {
                    //w.WriteProperty(SystemProperties.System.Author, new string[] { "MyTest", "Test" });
                    //w.WriteProperty(SystemProperties.System.Music.Artist, new string[] { "MyTest", "Test" });
                    //w.WriteProperty(SystemProperties.System.Music.DisplayArtist, "Test");

                    
                    w.WriteProperty(SystemProperties.System.Photo.DateTaken, "1903-05-10");
                    w.WriteProperty(SystemProperties.System.Photo.PeopleNames, "Person 1, Person 2, Person 3");
                    w.WriteProperty(SystemProperties.System.Photo.PeopleNames, new string[] { "Person 1", "Person 2", "Person 3" });

                    w.WriteProperty(SystemProperties.System.FileDescription, "Photo showing blah blah blah etc Description here.");
                    w.WriteProperty(SystemProperties.System.Comment, "From the personal archives of Joyce Fletcher. Billings, Montana");

                    w.WriteProperty(SystemProperties.System.DateArchived, "2023-11-07");
                    w.WriteProperty(SystemProperties.System.Media.DateEncoded, "2023-11-07");

                    w.WriteProperty(SystemProperties.System.Copyright, "Copyright © 2023 Scott Fletcher");
                    w.WriteProperty(SystemProperties.System.Keywords, new string[] { "Myers, Fletcher, historical, vintage" });

                    //Bitmap CODEC does not support these properties:
                    //w.WriteProperty(SystemProperties.System.Media.Year, "1903");


                }
                catch (Exception ex)
                {
                    //maybe do some property-specific error handling here
                    throw;
                }
            }
            catch (Exception exOpen)
            {
                //Wanna do anything when opening the filewriter fails?
                throw;
            }
            finally 
            {
                if (w != null)
                {
                    w.Close();
                }
            }
        }

        public void Test2(string filePath)
        {
            ShellObject f = null;
            try
            {
                f = ShellFile.FromParsingName(filePath);
                try
                {
                    //w.WriteProperty(SystemProperties.System.Author, new string[] { "MyTest", "Test" });
                    //w.WriteProperty(SystemProperties.System.Music.Artist, new string[] { "MyTest", "Test" });
                    //w.WriteProperty(SystemProperties.System.Music.DisplayArtist, "Test");

                    f.Properties.System.Photo.DateTaken.Value = DateTime.Parse("1903-05-10");
                    //f.Properties.System.Photo.PeopleNames = "Person 1, Person 2, Person 3";
                    f.Properties.System.Photo.PeopleNames.Value = new string[] { "Person 1", "Person 2", "Person 3" };

                    f.Properties.System.FileDescription.Value = "Photo showing blah blah blah etc Description here.";
                    f.Properties.System.Comment.Value = "From the personal archives of Joyce Fletcher. Billings, Montana";

                    f.Properties.System.DateArchived.Value = DateTime.Parse("2023-11-07");
                    f.Properties.System.Media.DateEncoded.Value = DateTime.Parse("2023-11-07");

                    f.Properties.System.Copyright.Value = "Copyright © 2023 Scott Fletcher";
                    f.Properties.System.Keywords.Value = new string[] { "Myers, Fletcher, historical, vintage" };

                    //Bitmap CODEC does not support these properties:
                    //w.WriteProperty(SystemProperties.System.Media.Year, "1903");


                }
                catch (Exception ex)
                {
                    //maybe do some property-specific error handling here
                    throw;
                }
            }
            catch (Exception exOpen)
            {
                //Wanna do anything when opening the filewriter fails?
                throw;
            }
            finally
            {
                if (f != null)
                {
                    f.Dispose();
                }
            }
        }

        public void Test3(string filePath, string targetFolderPath, string appendFileNameWith)
        {
            // Load the JPEG image
            using (Image image = Image.FromFile(filePath))
            {
                PhotoDetails p = new PhotoDetails().GetTestObject();

                WritePhotoDetails(image, p, targetFolderPath, filePath, appendFileNameWith);
            }
        }

        private static PropertyItem SetProperty(Image image, int propID, string val)
        {
            PropertyItem p = FindPropertyItem(image, propID);
            if (p == null)
            {
                p = (PropertyItem)FormatterServices.GetUninitializedObject(typeof(PropertyItem));
                p.Id = propID; 
                p.Type = 2; // Type 2 represents a null-terminated ASCII string
            }
            p.Value = System.Text.Encoding.ASCII.GetBytes(val + '\0');
            p.Len = p.Value.Length;
            return p;
        }

        static PropertyItem FindPropertyItem(Image image, int id)
        {
            foreach (PropertyItem propertyItem in image.PropertyItems)
            {
                if (propertyItem.Id == id)
                {
                    return propertyItem;
                }
            }
            return null;
        }


        private static ShellPropertyWriter GetFilePropertyWriter(string filePath)
        {
            var shellFile = ShellFile.FromParsingName(filePath);
            ShellPropertyWriter w = shellFile.Properties.GetPropertyWriter();
            return w;
        }

        private static void WritePhotoDetails(Image image, PhotoDetails p, string targetFilePath, string origFileName, string appendNameWith)
        {

            #region Property IDs
            /*
             *  Title (0x00002): This property is used for the title of a file.
             *  Author (0x00003): This property is used to specify the author of a file.
             *  Subject (0x00004): The subject of the file can be set using this property.
             *  Keywords (0x00005): This property is used to store keywords related to the file.
             *  Comments (0x00006): You can add comments or descriptions to a file using this property.
             *  Template (0x00007): Specifies the template used to create the file.
             *  Last Author (0x00008): Stores the name of the last person to modify the file.
             *  Revision Number (0x00009): This property tracks the revision number of the file.
             *  Application Name (0x00012): Specifies the name of the application that created the file.
             *  Copyright (0x00029): Used to store copyright information for the file.
             *  Date Taken (0x9003): This property is used to indicate the date and time when a photo was taken.
             *  Camera Make (0x010F): Stores the make of the camera that took the photo.
             *  Camera Model (0x0110): Specifies the model of the camera that took the photo.
             *  Dimensions (0x0103): This property can store the width and height of an image.
             *  Image Description (0x010E): Used to store a description of the image.
             *  Exposure Time (0x829A): Stores the exposure time of the image.
             *  Focal Length (0x920A): Specifies the focal length of the lens when the image was taken.
             */
            #endregion

            try
            {

                // Create PropertyItem for DateTaken (ID: 0x9003)
                PropertyItem dateTakenProperty = SetProperty(image, SystemProperties.System.Photo.DateTaken.PropertyId, p.DateTaken.ToString("yyyy:MM:dd HH:mm:ss"));

                // Create PropertyItem for Copyright (ID: 0x8298)
                //PropertyItem copyrightProperty = SetProperty(image, SystemProperties.System.Copyright.PropertyId, p.Copyright);
                PropertyItem copyrightProperty = SetProperty(image, 0x8298, p.Copyright);

                //PropertyItem yearProperty = SetProperty(image, SystemProperties.System.Media.Year.PropertyId, p.Year);
                //PropertyItem peopleNamesProperty = SetProperty(image, SystemProperties.System.Photo.PeopleNames.PropertyId, p.PeopleNames);

                //PropertyItem descriptionProperty = SetProperty(image, SystemProperties.System.FileDescription.PropertyId, p.FileDescription);
                PropertyItem descriptionProperty = SetProperty(image, 0x010E, p.ImageDescription);

                //PropertyItem commentProperty = SetProperty(image, SystemProperties.System.Comment.PropertyId, p.Comment);
                PropertyItem commentProperty = SetProperty(image, 0x00006, p.Comment);

                PropertyItem dateArchivedProperty = SetProperty(image, SystemProperties.System.DateArchived.PropertyId, p.DateArchived.ToString("yyyy:MM:dd HH:mm:ss"));
                PropertyItem dateEncodedProperty = SetProperty(image, SystemProperties.System.Media.DateEncoded.PropertyId, p.DateEncoded);

                PropertyItem keywordsProperty = SetProperty(image, SystemProperties.System.Keywords.PropertyId, p.Keywords);

                // Apply the property changes to the image
                image.SetPropertyItem(dateTakenProperty);
                image.SetPropertyItem(copyrightProperty);
                //image.SetPropertyItem(yearProperty);
                //image.SetPropertyItem(peopleNamesProperty);
                image.SetPropertyItem(descriptionProperty);
                image.SetPropertyItem(commentProperty);
                image.SetPropertyItem(dateArchivedProperty);
                image.SetPropertyItem(dateEncodedProperty);
                image.SetPropertyItem(keywordsProperty);

                // Save the modified image with the new properties
                string fqnTarget =  Path.Combine(targetFilePath, Path.GetFileNameWithoutExtension(origFileName) + appendNameWith + Path.GetExtension(origFileName));
                image.Save(fqnTarget);

            }
            catch (Exception ex)
            {

            }
        }
    }

}
