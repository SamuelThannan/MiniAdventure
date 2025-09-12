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


            if(chosenClass == 1)
            {
                new Warrior();
            }
            else if(chosenClass == 2)
            {
                new Mage();
            }


        }
    }
}
