using System;

namespace ThirdPartyLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Read data from csv and Write data to csv");
            //    csvHandler.ImplementCSVDataHandling();
            //    Console.WriteLine();
            //

            Console.WriteLine("Read data from csv and write to json");
            ReadCSV_And_WriteJSON.ImplementCSVtoJSON();
        }
    }
}
