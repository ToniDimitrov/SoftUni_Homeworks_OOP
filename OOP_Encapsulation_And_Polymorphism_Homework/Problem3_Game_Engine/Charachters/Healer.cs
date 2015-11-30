using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum;
using TheSlum.Interfaces;

namespace Problem3_Game_Engine
{
    internal class Healer : Character, IHeal
    {
        public int HealingPoints { get; set; }

        public Healer(string id, int x, int y, Team team) : base(id, x, y, 75, 50, team, 6)
        {
            this.HealingPoints = 60;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            int minHealth = int.MaxValue;
            int count = 0;
            int targetIndex = 0;
            foreach (var character in targetsList)
            {
                int health = character.HealthPoints;
                if (health <= minHealth  && character.Team == this.Team && character.Id!=this.Id)
                {
                    targetIndex = count;
                    minHealth = health;
                }
                count++;
            }
            if (targetIndex == -1)
            {
                return null;
            }
            return targetsList.ElementAt(targetIndex);
        }

        public override void AddToInventory(Item item)
        {
            this.ApplyItemEffects(item);
            this.Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.RemoveItemEffects(item);
            this.Inventory.Remove(item);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" Healing: {0}", this.HealingPoints);
        }
    }
}