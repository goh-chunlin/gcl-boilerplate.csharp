using static System.Console;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using HelloWorld.JsonFileReader.Models;

namespace HelloWorld.JsonFileReader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length < 1)
            {
                WriteLine("Please specify the file path to the JSON file as the first argument.");

                return;
            } 

            string filePath = args[0];
            if (!File.Exists(filePath))
            {
                WriteLine($"The file {filePath} does not exist.");

                return;
            }

            ReadFromFile(filePath);

            await ReadFromFileAsync(filePath);
        }

        static void ReadFromFile(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            var items = JsonSerializer.Deserialize<List<Item>>(jsonString);

            WriteLine($"==== Syncchronous Method ====");
            foreach(var item in items)
            {
                WriteLine($"Item ID: {item.Id}: ");
                WriteLine($"Name: {item.Name}");
                WriteLine($"Description: {item.Description}");
                WriteLine($"Created At: {item.CreatedAt.ToString("dd MMM yyyy")}");
                WriteLine("");
            }
        }

        static async Task ReadFromFileAsync(string filePath)
        {
            using (var fileStream = File.OpenRead(filePath))
            {
                var items = await JsonSerializer.DeserializeAsync<List<Item>>(fileStream);

                WriteLine($"==== Asyncchronous Method ====");
                foreach(var item in items)
                {
                    WriteLine($"Item ID: {item.Id}: ");
                    WriteLine($"Name: {item.Name}");
                    WriteLine($"Description: {item.Description}");
                    WriteLine($"Created At: {item.CreatedAt.ToString("dd MMM yyyy")}");
                    WriteLine("");
                }
            }
        }
    }
}
