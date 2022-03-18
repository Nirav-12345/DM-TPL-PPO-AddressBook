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

namespace UC14ThirdPartyLibCsvAddressBook
{
    public class Class1
    {
        public static void ImplementCsvHandling()
        {
            string ImportFilepath = @"C:\Users\Nirav Raj\Desktop\day 28\UC14ThirdPartyLibCsvAddressBook\Addressbook.csv";
            string ExportFilepath = @"C:\Users\Nirav Raj\Desktop\day 28\UC14ThirdPartyLibCsvAddressBook\AdressExport.csv";
            //string ExportFilepath = @"C:\Users\Nirav Raj\Desktop\day23\ThirdPartyLibraryDemo\ExportJson.json";
            //reading csv file
            using (var reader = new StreamReader(ImportFilepath))
                using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from data");
                foreach (AddressData address in records)
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
                Console.WriteLine("Writing To The file");
                using(var writer=new StreamWriter(ExportFilepath))
                    using(var csvExport = new CsvWriter(writer,CultureInfo.InvariantCulture))
                {
                csvExport.WriteRecords(records);
                }

                JsonSerializer serialize = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(ExportFilepath))
                using (JsonWriter write = new JsonTextWriter(sw))
                {
                    serialize.Serialize(write, records);
                }

            }

        }
    }
}
