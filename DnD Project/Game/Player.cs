using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_Project.Game.Races;
using DnD_Project.Game.Items;
using DnD_Project.Game.NPCs;

namespace DnD_Project.Game
{
    class Player
    {
        //Player Info
        protected string name;
        protected int id;
        protected Race race;
        public enum playerState
        {
            Waiting,
            Deciding
        };


        //Attributes
        protected float health;
        protected List<Item> inv = new List<Item>();

        public Player(string name, int id, Race race)
        {
            this.name = name;
            this.id = id;
            this.race = race;                   
        }

        public float GetAttribute(string attribute)
        {
            return 0;
        }

        public float GetAttributeFromPlayer(Player p, string attribute)
        {
            return 0;
        }

        public float GetAttributFromAI(NPC npc, string Attrbute)
        {
            return 0;
        }
    
        //Overrides ToString function to print name and race of the player
        public override string ToString()
        {
            return $"Player {id} -- Name: {name} Race: {race.name}";
        }
    }
}
