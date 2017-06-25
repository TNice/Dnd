using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Project.Game
{
    class Race
    {
        //Public Properties Properties
        public string name { get; set; }

        //Protected Properties
        protected int strength;

        //Set Default Values For Properties Here
        public Race()
        {
            name = "Name";
        }
    }
}
