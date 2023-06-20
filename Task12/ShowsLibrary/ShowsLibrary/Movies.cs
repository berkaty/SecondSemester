using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Movies : Shows
    {
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Countries { get; set; }
        public int Year { get; set; }

        public Movies(string genre, string director, string countries, int year) 
        {
            Genre = genre;
            Director = director;
            Countries = countries;
            Year = year;
        }

        public override string GetInfo() =>
            $"Genre: {Genre}, director: {Director}, countries: {Countries}, year: {Year}";
    }
}