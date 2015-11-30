using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum;
using TheSlum.GameEngine;
using TheSlum.Interfaces;

namespace Problem3_Game_Engine
{
    internal class Warrior : Character, IAttack
    {
        public int AttackPoints { get; set; }

        public Warrior(string id, int x, int y, Team team) : base(id, x, y, 200, 100, team, 2)
        {
            this.AttackPoints = 150;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            double minDistance = double.MaxValue;
            int count = 0;
            int targetIndex = 0;
            foreach (var character in targetsList)
            {
                double distance =
                    Math.Sqrt(Math.Pow(this.X - character.X, 2) +
                              Math.Pow(this.Y - character.Y, 2));
                if (distance <= minDistance && character.Team != this.Team)
                {
                    targetIndex = count;
                    minDistance = distance;
                }
                count++;
            }
            if (targetIndex == -1)
            {
                return null;
            }
            return targetsList.ElementAt(targetIndex);
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }

        public override void AddToInventory(Item item)
        {
            this.ApplyItemEffects(item);
            this.Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            if (item.GetType().Name == "Injection")
            {
                base.RemoveItemEffects(item);
            }
            else
            {
                this.HealthPoints -= item.HealthEffect;
                this.DefensePoints -= item.DefenseEffect;
            }
            this.Inventory.Remove(item);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" Attack: {0}", this.AttackPoints);
        }
    }
}