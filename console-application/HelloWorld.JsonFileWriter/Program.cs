using static System.Console;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using HelloWorld.JsonFileWriter.Models;

namespace HelloWorld.JsonFileWriter
{
    class Program
    {
        static async Task Main()
        {
            // This code assumes a "C:\Temp" folder on your machine.
            // You can modify the path if necessary.

            var items = InitItems();

            WriteToFile(items);

            await WriteToFileAsync(items);
        }

        static List<Item> InitItems()
        {
            var items = new List<Item>();

            items.Add(new Item { Name = "Item 1", Description = "This is an item with ID 1." });
            items.Add(new Item { Name = "Item 2", Description = "This is an item with ID 2." });
            items.Add(new Item { Name = "Item 3", Description = "This is an item with ID 3." });
            items.Add(new Item { Name = "Item 4", Description = "This is an item with ID 4." });
            items.Add(new Item { Name = "Item 5", Description = "This is an item with ID 5." });

            return items;
        }

        static void WriteToFile(List<Item> items)
        {
            string jsonString = JsonSerializer.Serialize(items);

            File.WriteAllText(@"C:\Temp\HelloWorld.JsonFileWriter.Output1.json", jsonString);
        }

        static async Task WriteToFileAsync(List<Item> items)
        {
            using (var fileStream = File.Create(@"C:\Temp\HelloWorld.JsonFileWriter.Output2.json"))
            {
                await JsonSerializer.SerializeAsync(fileStream, items);
            }
        }
    }
}
