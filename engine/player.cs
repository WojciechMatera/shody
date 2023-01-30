using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public class player
    {
        public int Gold { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }

        public player(int gold, int exp, int level)
        {
            Gold = gold;
            Exp = exp;
            Level = level;

            Inventory = new List<InventoryItem>();

        }
    }
}
