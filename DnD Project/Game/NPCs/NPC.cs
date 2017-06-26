using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_Project.Game.Items;

namespace DnD_Project.Game.NPCs
{
    class NPC
    {
        //NPC Info
        public string name { get; set; }

        //Attrinbutes
        protected string strength { get; set; }
        protected List<Item> inv { get; set; }

        public List<Item> GetInv()
        {
            return this.inv;
        }

    }
}
