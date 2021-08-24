using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace ThirdPartyLibrary
{
    class csvHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = @"C:\Users\kkancha\source\repos\ThirdPartyLibrary\ThirdPartyLibrary\Utility\address.csv";
            string exportFilePath = @"C:\Users\kkancha\source\repos\ThirdPartyLibrary\ThirdPartyLibrary\Utility\export.csv";

            //reading csv file
           var reader = new StreamReader(importFilePath);
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from addresses csv");
                foreach(AddressData addressData in records)
                {
                    Console.WriteLine("\t"+addressData.firstname);
                    Console.WriteLine("\t" + addressData.lastname);
                    Console.WriteLine("\t" + addressData.address);
                    Console.WriteLine("\t" + addressData.city);
                    Console.WriteLine("\t" + addressData.state);
                    Console.WriteLine("\t" + addressData.code);
                }
                Console.WriteLine("______Now readding from csv file and writing to csv file______");

                //writing csv file
                var writer = new StreamWriter(exportFilePath);
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
    }
}
