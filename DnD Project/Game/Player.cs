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
        public string name;
        public int id;
        public Race race;
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
            var result = GetType().GetField(attribute).GetValue(this);
            return (float)result;
        }

        public List<Item> GetInv()
        {
            return this.inv;
        }

        public void AddItemToInv(Item item)
        {
            inv.Add(item);
        }

        public void RemoveItemFromInv(Item item)
        {
            inv.Remove(item);
        }

        public void UseItem(ref Item item)
        {
            if(!item.isUseable)
            {
                //Give Error Message
                return;
            }

            if (item.currentUses <= 0)
            {
                RemoveItemFromInv(item);
                return;
            }

            item.Use();
            item.currentUses--;

            if (item.currentUses == 0) RemoveItemFromInv(item);

        }

        public float GetAttributeFromPlayer(Player p, string attribute)
        {
            var result = p.GetType().GetField(attribute).GetValue(p);
            return (float)result;
        }

        public float GetAttributFromAI(NPC npc, string attribute)
        {
            var result = npc.GetType().GetField(attribute).GetValue(npc);
            return (float)result;
        }

        public List<Item> GetAiInv(NPC npc)
        {
            return npc.GetInv();
        }
    
        //Overrides ToString function to print name and race of the player
        public override string ToString()
        {
            return $"Player {id} -- Name: {name} Race: {race.name}";
        }
    }
}
