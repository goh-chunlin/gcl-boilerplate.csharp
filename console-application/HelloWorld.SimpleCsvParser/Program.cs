using static System.Console;
using System.Text;
using System.IO;
using System.Linq;
using HelloWorld.SimpleCsvParser.Models;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace HelloWorld.SimpleCsvParser
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                WriteLine("Please specify the file path to the CSV file as the first argument.");

                return;
            } 
            
            string filePath = args[0];
            if (!File.Exists(filePath))
            {
                WriteLine($"The file {filePath} does not exist.");

                return;
            }

            var csvParserOptions = new CsvParserOptions(true, ',');
            var csvMapper = new UserMappingCsv();
            var csvParser = new CsvParser<User>(csvParserOptions, csvMapper);

            var records = csvParser
                .ReadFromFile(filePath, Encoding.UTF8)
                .ToList();

            foreach(var record in records)
            {
                if (!record.IsValid)
                {
                    continue;
                }

                WriteLine($"User {record.Result.Id}: ");
                WriteLine($"Name: {record.Result.FirstName} {record.Result.LastName}");
                WriteLine($"Address: {record.Result.Address}");
                WriteLine($"Reg. Date: {record.Result.RegistrationDate.ToString("dd MMM yyyy")}");
                WriteLine($"Status: {(record.Result.IsEnabled ? "Enabled" : "Disabled")}");
                WriteLine("");
            }
        }
    }
}
