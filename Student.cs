using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myrla
{
    [Serializable]
    internal class Cat
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Age { get; set; }
        [NonSerialized]
        public string NumTelephone;

        public void someMethod(string[] cats)
        {
            cats = new string[] { "Name", "Breed", "Age" };
        }
    }
    
}
