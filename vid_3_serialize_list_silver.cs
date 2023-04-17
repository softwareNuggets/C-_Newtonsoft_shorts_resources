using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace MyApp 
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List<Silver> allAg = BuildInventory();

            var json =
                JsonConvert.SerializeObject(
                    allAg, 
                    Formatting.Indented);

            Console.WriteLine(json);
        }


        static public List<Silver> BuildInventory()
        {
            var allAg = new List<Silver>()
            {
                new Silver() {  
                            SerialNumber = "AG0001", 
                            Grams = 100,
                            PurchasePrice = 103.52 },

                new Silver() { 
                            SerialNumber = "AG0002", 
                            Grams = 200,
                            PurchasePrice = 140.89 },

                new Silver() { 
                            SerialNumber = "AG0002", 
                            Grams = 300,
                            PurchasePrice = 238.15 }
            };

            return (List<Silver>)allAg;
        }

    }





    
    public class Silver
    {
        [Required]
        public string   SerialNumber { get; set; }
        [Required]
        public int      Grams { get; set; }
        [Required]
        public double   PurchasePrice { get; set; }
    }
}
