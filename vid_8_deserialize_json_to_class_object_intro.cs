using System;
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

            Learn firstApp = 
                JsonConvert
                .DeserializeObject<Learn>(json);


        }
        
        
    }

    public class Learn
    {
        public string a_string { get; set; }
    }
}
