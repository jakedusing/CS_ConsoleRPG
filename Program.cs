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

    class Enemy
    {
        public string Name { get; set;}
        public int Health { get; set; }
        public int Attack { get; set; }

        public Enemy(string name, int health, int attack)
        {
            Name = name;
            Health = health;
            Attack = attack;
        }

        public void AttackPlayer(Player player)
        {
            Console.WriteLine($"{Name} attacks you for {Attack} damage!");
        }
    }

    static class PlayerExtensions
    {
        public static void LevelUp(this Player player)
        {
            if (player.XP >= 100)
            {
                player.Level++;
                player.XP = 0;
                player.Health += 20;
                player.Mana += 10;
                player.Attack += 5;
                player.Defense += 3;
                Console.WriteLine($"{player.Name} leveled up to level {player.Level}!");
            }
        }        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fourth Wing RPG!");
            Console.Write("Enter your character's name:");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName);

            GameLoop(player);
        }

        static void GameLoop(Player player)
        {
            Console.Clear();
            bool gameRunning = true;

            while (gameRunning)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Check stats");
                Console.WriteLine("2. Explore the academy");
                Console.WriteLine("3. Fight a dragon!");
                Console.WriteLine("4. Exit the game");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        player.DisplayStats();
                        break;
                    case "2":
                        ExploreAcademy();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for playing! Goodbye.");
                        gameRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }

                if (player.Health <= 0)
                {
                    Console.WriteLine("You have died. Game Over.");
                    gameRunning = false;
                }
            }
        }

        static void ExploreAcademy()
        {
            Console.WriteLine("You walk through the grand halls of the academy. The sound of dragons fills the air");
            Console.WriteLine("You meet a fellow student who tells you about a secret quest that could help you gain power.");
        }
    }
}