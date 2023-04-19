using System;
using System.Data.Common;
using System.IO;
using Newtonsoft.Json;

namespace MyApp
{
    public class Program
    {

        static void Main(string[] args)
        {

            string fname = @"c:\temp\learning.JSON";

            if (File.Exists(fname) == false)
            {
                Console.WriteLine(
                     $"{fname} is not available");
                return;
            }

            var json = 
                File
               .ReadAllText(fname);

            Learn 
            firstApp = 
                JsonConvert
                .DeserializeObject<Learn>(json);
        }
    }

    public class Learn
    {
        public string a_string { get; set; }
        public int a_number { get; set; }
        public bool a_bool { get; set; }
        public Location location_object
                        { get; set; }
        public string[] metals { get; set; }
    }

    public class Location
    {
        public string city_name { get; set; }
        public string state_name { get; set; }
        public int zip_code { get; set; }
    }
}
