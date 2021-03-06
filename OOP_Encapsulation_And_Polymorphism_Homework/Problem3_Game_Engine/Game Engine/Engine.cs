﻿using Problem3_Game_Engine;

namespace TheSlum.GameEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class Engine
    {
        internal List<Character> characterList = new List<Character>();
        internal List<Bonus> timeoutItems;

        private const int GameTurns = 4;

        public virtual void Run()
        {
            this.ReadUserInput();
            this.InitializeTimeoutItems();

            for (int i = 0; i < GameTurns; i++)
            {
                foreach (var character in this.characterList)
                {
                    if (character.IsAlive)
                    {
                        this.ProcessTargetSearch(character);
                    }
                }

                this.ProcessItemTimeout(this.timeoutItems);
            }

            this.PrintGameOutcome();
        }

        private void ReadUserInput()
        {
            string inputLine = Console.ReadLine();
            while (inputLine != string.Empty)
            {
                string[] parameters = inputLine
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                this.ExecuteCommand(parameters);
                inputLine = Console.ReadLine();
            }
        }

        protected virtual void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    this.PrintCharactersStatus(this.characterList);
                    break;
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
            }
        }

        protected void PrintCharactersStatus(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
                Console.WriteLine(character.ToString());
            }
        }

        public void InitializeTimeoutItems()
        {
            this.timeoutItems = this.characterList
                .SelectMany(c => c.Inventory)
                .Where(i => i is Bonus)
                .Cast<Bonus>()
                .ToList();
        }

        protected void ProcessTargetSearch(Character currentCharacter)
        {
            var availableTargets = this.characterList
                .Where(t => this.IsWithinRange(currentCharacter.X, currentCharacter.Y, t.X, t.Y, currentCharacter.Range))
                .ToList();

            if (availableTargets.Count == 0)
            {
                return;
            }

            var target = currentCharacter.GetTarget(availableTargets);
            if (target == null)
            {
                return;
            }

            this.ProcessInteraction(currentCharacter, target);
        }

        public void ProcessItemTimeout(List<Bonus> timeoutItems)
        {
            for (int i = 0; i < timeoutItems.Count; i++)
            {
                timeoutItems[i].Countdown--;
                if (timeoutItems[i].Countdown == 0)
                {
                    var item = timeoutItems[i];
                    item.HasTimedOut = true;
                    var itemHolder = this.GetCharacterByItem(item);
                    itemHolder.RemoveFromInventory(item);
                    i--;
                }
            }
        }

        protected virtual void CreateCharacter(string[] inputParams)
        {
            switch (inputParams[1])
            {
                case "warrior":
                {
                    if (inputParams[5] == "Blue")
                    {
                        characterList.Add(new Warrior(inputParams[2], int.Parse(inputParams[3]),
                            int.Parse(inputParams[4]), Team.Blue));
                    }
                    else
                    {
                        characterList.Add(new Warrior(inputParams[2], int.Parse(inputParams[3]),
                            int.Parse(inputParams[4]), Team.Red));
                    }
                    break;
                }
                case "mage":
                {
                    if (inputParams[5]=="Blue")
                    {
                        characterList.Add(new Mage(inputParams[2], int.Parse(inputParams[3]),
                            int.Parse(inputParams[4]), Team.Blue));
                    }
                    else
                    {
                        characterList.Add(new Mage(inputParams[2], int.Parse(inputParams[3]),
                            int.Parse(inputParams[4]), Team.Red));
                    }
                    break;
                }
                case "healer":
                {
                    if (inputParams[5] == "Blue")
                    {
                        characterList.Add(new Healer(inputParams[2], int.Parse(inputParams[3]),
                            int.Parse(inputParams[4]), Team.Blue));
                    }
                    else
                    {
                        characterList.Add(new Healer(inputParams[2], int.Parse(inputParams[3]),
                            int.Parse(inputParams[4]), Team.Red));
                    }
                    break;
                }
            }
        }

        protected void AddItem(string[] inputParams)
        {
            switch (inputParams[2])
            {
                case "axe":
                    GetCharacterById(inputParams[1]).AddToInventory(new Axe(inputParams[3]));
                    break;
                case "shield":
                    GetCharacterById(inputParams[1]).AddToInventory(new Shield(inputParams[3]));
                    break;
                case "injection":
                    GetCharacterById(inputParams[1]).AddToInventory(new Injection(inputParams[3]));
                    break;
                case "pill":
                    GetCharacterById(inputParams[1]).AddToInventory(new Pill(inputParams[3]));
                    break;
            }
        }

        protected void ProcessInteraction(Character currentCharacter, Character target)
        {
            if (currentCharacter is IHeal)
            {
                target.HealthPoints += (currentCharacter as IHeal).HealingPoints;
            }
            else if (currentCharacter is IAttack)
            {
                target.HealthPoints -= (currentCharacter as IAttack).AttackPoints - target.DefensePoints;
                if (target.HealthPoints <= 0)
                {
                    target.IsAlive = false;
                }
            }
        }

        protected bool IsWithinRange(int attackerX, int attackerY, int targetX, int targetY, int range)
        {
             double distance = Math.Sqrt(
                (attackerX - targetX)*(attackerX - targetX) +
                (attackerY - targetY)*(attackerY - targetY));

            return distance <= range;
        }

        protected Character GetCharacterById(string characterId)
        {
            return this.characterList.FirstOrDefault(x => x.Id == characterId);
        }

        protected Character GetCharacterByItem(Item item)
        {
            return this.characterList.FirstOrDefault(x => x.Inventory.Contains(item));
        }

        protected void PrintGameOutcome()
        {
            var charactersAlive = this.characterList.Where(c => c.IsAlive);
            var redTeamCount = charactersAlive.Count(x => x.Team == Team.Red);
            var blueTeamCount = charactersAlive.Count(x => x.Team == Team.Blue);
            string winningTeam = "";
            if (redTeamCount == blueTeamCount)
            {
                Console.WriteLine("Tie game!");
            }
            else
            {
                winningTeam = redTeamCount > blueTeamCount ? "Red" : "Blue";
                Console.WriteLine(winningTeam + " team wins the game!");
            }

            var aliveCharacters = this.characterList.Where(c => c.IsAlive && c.Team.ToString() == winningTeam);
            this.PrintCharactersStatus(aliveCharacters);
        }
    }
}