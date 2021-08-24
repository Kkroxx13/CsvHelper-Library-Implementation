using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;
using CsvHelper;
using Newtonsoft.Json;


namespace ThirdPartyLibrary
{
    class ReadCSV_And_WriteJSON
    {
        public static void ImplementCSVtoJSON()
        {
            string importFilePath= @"C:\Users\kkancha\source\repos\ThirdPartyLibrary\ThirdPartyLibrary\Utility\address.csv";
            string exportFilePath = @"C:\Users\kkancha\source\repos\ThirdPartyLibrary\ThirdPartyLibrary\Utility\Jsonfile.json";

            //reading csv file
            var reader = new StreamReader(importFilePath);
            using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from csv file, Here are the codes");
                foreach(AddressData addressData in records)
                {
                    Console.WriteLine("\t"+addressData.code);
                }
                Console.WriteLine("Now reading from csv file and writing to json file");

                //write data to json file
                JsonSerializer jsonSerializer = new JsonSerializer();
                StreamWriter sw = new StreamWriter(exportFilePath);
                using(JsonWriter writer=new JsonTextWriter(sw))
                {
                    jsonSerializer.Serialize(writer, records);
                }
            }

        }
    }
}
