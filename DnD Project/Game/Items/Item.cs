using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Project.Game.Items
{
    class Item
    {
        protected int maxUses { get; set; }
        public int currentUses { get; set; }
        public bool isUseable { get; set; }

        public void Use() { }
    }
}
