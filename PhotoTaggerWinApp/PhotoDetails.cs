using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoTaggerWinApp
{
    public class PhotoDetails
    {
        public string PeopleNames { get; set; }
        public DateTime DateTaken { get; set; }
        //public string Year { get; set; }
        public string ImageDescription { get; set; }
        public string Comment { get; internal set; }
        public DateTime DateArchived { get; internal set; }
        public string DateEncoded { get; internal set; }
        public string Copyright { get; internal set; }
        public string Keywords { get; internal set; }

        public PhotoDetails GetTestObject()
        {
            PhotoDetails p = new PhotoDetails();

            p.DateTaken = DateTime.Parse("1903-05-10");
            //p.Year = "1903";
            //p.PeopleNames = new string[] { "Person 1, Person 2, Person 3" };
            p.PeopleNames =  "Person 1, Person 2, Person 3";

            p.ImageDescription = "Photo showing blah blah blah etc Description here.";
            p.Comment = "From the personal archives of Joyce Fletcher. Billings, Montana";

            p.DateArchived = DateTime.Parse("2023-11-07");
            p.DateEncoded = "2023-11-07";

            p.Copyright ="Copyright 2023 Scott Fletcher";
            p.Keywords = "Myers, Fletcher, historical, vintage";

            return p;
        }
    }
}
