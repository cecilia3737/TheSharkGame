using System;
using System.Collections.Generic;
using System.Text;

namespace TheSharkGame
{
    class Player
    {
        private string name;
        private int level = 1;
        private int hp = 50;
        private int exp;
        private int atkDmg = 4;

        public Player()
        {

        }

        public void PlayerInfo()
        {
            Console.WriteLine("  ----------------------------------");
            Console.WriteLine($"   Name: " + Name +
                $"\n   Level: " + Level +
                $"\n   HP: " + Hp +
                $"\n   Exp: " + Exp +
                $"\n   Attackpower: " + AtkDmg);
            Console.WriteLine("  ----------------------------------");
        }


        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Exp { get => exp; set => exp = value; }
        public int AtkDmg { get => atkDmg; set => atkDmg = value; }

    }
}
