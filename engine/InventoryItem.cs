using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public class InventoryItem
    {
        public int tree { get; set; }
        public int kamien { get; set; }

        public String Name { get; set; }

        public InventoryItem(String name)
        {
            Name = name;
        }

    }
}