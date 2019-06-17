using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class LootItems
    {
        public Item Details { get; set; }
        public int DropPercent { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootItems(Item details, int droppercent, bool isdefaultitem)
        {
            Details = details;
            DropPercent = droppercent;
            IsDefaultItem = isdefaultitem;
        }
    }
}
