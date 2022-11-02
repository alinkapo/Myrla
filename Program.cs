


using System;
using System.IO;
using System.Text.Json;

namespace Myrla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cats = new Cat();
            cats = NewMethod(cats);
            cats.Name = "Мурзик";

            var json = JsonSerializer.Serialize<Cat>(cats);

            Console.WriteLine(json);

            File.WriteAllText("File.json", json);

            var json = File.ReadAllText("File.json");

            File.ReadAllText("File.json");

            Cat cats = JsonSerializer.Deserialize<Cat>(json);
            Console.WriteLine($"{cats.Name} {cats.Group}");

        }

        private static Cat NewMethod(Cat cats)
        { 
            cats.Group = "2";
            return cats;
        }
    }
}
