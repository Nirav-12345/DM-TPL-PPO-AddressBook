using System;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace UC15
{
    public class Class1
    {

        public static void Json()
        {
            string path = @"C:\Users\Nirav Raj\Desktop\day 28\UC15\addressBook.csv";
            string path1 = @"C:\Users\Nirav Raj\Desktop\day 28\UC15\AdressExport.json";

            using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Class2>().ToList();
                Console.WriteLine("Read data successfully from data");
                foreach (Class2 address in records)
                {
                    Console.WriteLine(address.FirstName);
                    Console.WriteLine(address.LastName);
                    Console.WriteLine(address.addre);
                    Console.WriteLine(address.city);
                    Console.WriteLine(address.State);
                    Console.WriteLine(address.Zip);
                    Console.WriteLine(address.PhoneNumber);
                    Console.WriteLine(address.Email);

                }

                //Console.WriteLine("Writing To The file");
                //using(var writer=new StreamWriter(ExportFilepath))
                //using(var csvExport = new CsvWriter(writer,CultureInfo.InvariantCulture))
                //{
                //csvExport.WriteRecords(records);
                //}

                JsonSerializer serialize = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(path1))
                using (JsonWriter write = new JsonTextWriter(sw))
                {
                    serialize.Serialize(write, records);
                }
            }


        }




      
                    



    }
}
