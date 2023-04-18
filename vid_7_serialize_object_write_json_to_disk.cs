using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.IO;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {

         var agBar = BuildInventory();

         var json =
              JsonConvert.SerializeObject(
                    agBar,
                    Formatting.Indented);

            
        string fname = @"c:\temp\silver.json";

         if(File.Exists(fname)==true)
         {
                File.Delete(fname);
         }

         File.WriteAllText(fname, json);
    }


    static public Silver BuildInventory()
    {
        var agBar = new Silver();
        agBar.SerialNumber = "AG000001";
        agBar.Grams = 100;
        agBar.PurchasePrice = 102.40;
        agBar.Status = UserStatus.Ordered;

        return (agBar);
    }

    public class Silver
    {
        public string SerialNumber{get;set;}
        public int Grams {get;set;}
        public double PurchasePrice{get;set;}
        public UserStatus Status{get;set;}
    }

    public enum UserStatus
    {
        Ordered = 0,
        Shipped = 1,
        Received = 2
    }

  }
}
