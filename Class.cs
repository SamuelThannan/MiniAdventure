

using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace MiniAdventure
{
    public class Player
    {
        public string Class { get; set; }
        public int Health { get; set; }
        public int MaxHP { get; set; }
        public int Damage { get; set; }
        public int Gold { get; set; }
        public int HealPower { get; set; }
    }
    public class Warrior : Player
    {
        public Warrior()
        {
            
            Class = "Warrior";
            Health = 100;
            MaxHP = 100;
            Damage = 10;
            HealPower = 10;
            Gold = 20;
        }
        
       
    }
    public class Mage : Player
    {
        public Mage()
        {
            
            Class = "Mage";
            Health = 80;
            MaxHP = 80;
            Damage = 15;
            HealPower = 15;
            Gold = 20;
        }
        
    }
}
