using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiniAdventure
{
    public static class AdventureHelper
    {
         static Random random = new Random();

        public static void RandomAdventure(Enemy[] enemies, Player player)
        {
            int rng = random.Next(enemies.Length);
            Enemy enemy = enemies[rng];

            
            Console.WriteLine($"You encountered {enemy.Name}!");

            while(player.Health > 0 && enemy.StartHP > 0)
            {
                Console.Clear();
                Console.WriteLine($"==== {enemy.Name} ====");
                Console.WriteLine($"HP: {player.Health} |||| {enemy.Name} HP: {enemy.StartHP}");
                Console.WriteLine($"==Pick action==\n[1] Attack\n[2] Heal\n[3] Run");
                int choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    enemy.StartHP -= player.Damage;
                    Console.WriteLine($"You did {player.Damage} dmg to {enemy.Name}.");
                    
                }
                else if (choice == 2)
                {
                    player.Health += player.HealPower;
                    Console.WriteLine($"You healed for {player.HealPower} hp.");
                    
                }
                else if(choice == 3)
                {
                    Console.WriteLine("You fled from battle, press any key to continue.");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid option, choose between 1, 2 and 3");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    continue;
                }
                if (enemy.StartHP > 0)
                {
                    player.Health -= enemy.Damage;
                    Console.WriteLine($"You took {enemy.Damage} dmg.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }

            }
            if(player.Health <= 0)
            {
                Console.WriteLine("You died... Game over.");
                Console.ReadKey();
                return;
            }
            else if (enemy.StartHP <= 0)
            {
                Console.WriteLine($"You defeated {enemy.Name}, you earned {enemy.GoldDrop} gold!");
                player.Gold += enemy.GoldDrop;
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }

            
        }

        public static void RestTime(Player player)
        {
            player.Health += player.HealPower;
            if(player.Health > player.MaxHP)
            {
                player.Health = player.MaxHP;
            }
            Console.WriteLine($"You healed {player.HealPower} hp!\nHP: {player.Health}/{player.MaxHP}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public static void StatusCheck(string name, Player player)
        {
            Console.WriteLine($"Current status:\nName: {name}\nClass: {player.Class}\nHP: {player.Health}/{player.MaxHP}\nDamage: {player.Damage}\nGold: {player.Gold}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

    }
}
