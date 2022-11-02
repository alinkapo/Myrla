using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myrla
{
    internal class Controller
    {
        public void Save(Cat[] cats)
        {
            var json = JsonSerializer.Serialize<Cat>(cats);
            File.WriteAllText("cats.json", json);
        }
        public Cats[]Load (string path)
        {
            path = "cats.json";
                if (!File.Exists(path))
            {
                return null;

                else
                {
                    var json = File.ReadAllText(path);
                    Cats[] cats = JsonSerializer.Deserialize<Cats[]>(json);
                    return cats;
                }
            }
        }
    }
}
