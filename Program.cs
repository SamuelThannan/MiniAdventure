using System.Runtime.InteropServices;

namespace MiniAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy[] enemies = new Enemy[]
            {
                new Enemy{Name = "Dementor", StartHP = 40, Damage = 6, GoldDrop = 8},
                new Enemy{Name = "Murloc", StartHP = 15, Damage = 10, GoldDrop = 5},
                new Enemy{Name = "Pain", StartHP = 60, Damage = 10, GoldDrop = 50},
                new Enemy{Name = "Sakura", StartHP = 10, Damage = 1, GoldDrop = 2 }
            };
            
            
            Console.Write("Hello adventurer, What is your name?: ");
            string name = Console.ReadLine();
            Console.Write($"{name}, what class are you (1 / 2)?:\n[1] Warrior\n[2] Mage\n");
            int chosenClass = int.Parse(Console.ReadLine());
            Player player;

            if(chosenClass == 1)
            {
                player = new Warrior();
                
            }
            else if(chosenClass == 2)
            {
                player = new Mage();
                
            }
            else
            {
                Console.WriteLine("Invalid option, try again");
                return;
            }

               

            bool running = true;
            while (running)
            {
                Console.Clear();

                Console.WriteLine("==== MENU ====");
                Console.WriteLine("[1] Adventure");
                Console.WriteLine("[2] Rest");
                Console.WriteLine("[3] Status");
                Console.WriteLine("[4] Quit");
                Console.Write("Option: ");
                int choice = int.Parse( Console.ReadLine() );

                switch (choice)
                {
                    case 1:
                        AdventureHelper.RandomAdventure(enemies, player);
                        if(player.Health <= 0)
                        {
                            running = false;
                        }
                        break;
                    case 2:
                        AdventureHelper.RestTime(player);
                        break;
                    case 3:
                        AdventureHelper.StatusCheck(name, player);
                        break;
                    case 4:
                        Console.WriteLine("Quit");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            



        }
    }
}
