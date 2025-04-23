using System;

namespace FourthWingRPG
{
    class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }

        public Player(string name)
        {
            Name = name;
            Health = 100;
            Mana = 50;
            Attack = 10;
            Defense = 5;
            Level = 1;
            XP = 0;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"{Name}'s Stats: \nHealth: {Health} \nMana: {Mana} \nAttack: {Attack} \nDefense: {Defense} \nLevel: {Level} \nXP: {XP}");
        }
    }
}