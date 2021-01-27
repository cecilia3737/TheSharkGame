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
            Console.WriteLine("  " +
                "\n  ----------------------------------" +
                "\n   Player stats:" +
                "\n   Name: " + Name +
                "\n   Level: " + Level +
                "\n   HP: " + Hp +
                "\n   Exp: " + Exp +
                "\n   Attackpower: " + AtkDmg);
            Console.WriteLine("  ----------------------------------");
        }

        public void AttackShark(string sharkName)
        {
            Console.WriteLine("  You attack the " + sharkName + " with your weapon! It gets a hit and loses " + AtkDmg + "hp.");
        }

        public virtual int GetAttacked(int sharkDmg)
        {
            return Hp -= sharkDmg;
        }

        public int WinExp(int sharkExp)
        {
            return Exp += sharkExp;
        }

        public void LevelUp()
        {
            Level++;
            AtkDmg += 2;
            Hp += 20;
            Console.WriteLine("  " +
                "\n  *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*" +
                "\n  *                                                                 *" +
                "\n  *  You Leveled up! You are now at Level " + Level + " Your hp got restored!  *" +
                "\n  *                                                                 *" +
                "\n  *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            PlayerInfo();
        }


        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Exp { get => exp; set => exp = value; }
        public int AtkDmg { get => atkDmg; set => atkDmg = value; }

    }
}
