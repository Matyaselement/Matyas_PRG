using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPrague
{
    internal class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
