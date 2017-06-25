using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Project.Game
{
    class Dice
    {
         public int Roll(int sides)
        {
            Random rnd = new Random();
            int result = rnd.Next(1, sides);
            return result;
        }
    }
}
