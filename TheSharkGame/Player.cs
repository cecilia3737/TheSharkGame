using System;
using System.Collections.Generic;
using System.Text;

namespace TheSharkGame
{
    class Player
    {
        private string name;
        private int level = 1;
        private int hp = 30;
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
            Console.WriteLine("  " +
                "\n  You attack the " + sharkName + " with your fancy towel! It gets a hit and loses " + AtkDmg + "hp.");
        }

        public void SmileAndWave(string sharkname)
        {
            Console.WriteLine("  ----------------------------------" +
                "\n  " +
                "\n  You smile and wave at the " + sharkname);
        }

        public void ShowHp()
        {
            Console.WriteLine("  Your hp: " + Hp);
        }

        public virtual int GetAttacked(int sharkDmg)
        {
            return Hp -= sharkDmg;
        }

        public int WinExp(int sharkExp)
        {
            return Exp += sharkExp;
        }

        public void WinBattle(int sharkExp)
        {
            Console.WriteLine("  ----------------------------------" +
                        "\n   " +
                        "\n  You won against the shark! You gain " + sharkExp + " exp!" +
                        "\n  " +
                        "\n  ----------------------------------");
        }

        public void LevelUp()
        {
            Level++;
            AtkDmg *= 2;
            Hp *= 4;
            Console.WriteLine("  " +
                "\n  *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*" +
                "\n  *                                                                 *" +
                "\n  *  You Leveled up! You are now at Level " + Level + " You get some extra hp!  *" +
                "\n  *                                                                 *" +
                "\n  *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            PlayerInfo();
        }

        public void Lose()
        {
            Console.WriteLine("  " +
                "\n  ----------------------------------" +
                "\n  " +
                "\n  Oh no! You lost against the mighty sharks! Don't be ashamed, this is a really hard game!" +
                "\n  Did that encourage you to play again?" +
                "\n  ");
        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Exp { get => exp; set => exp = value; }
        public int AtkDmg { get => atkDmg; set => atkDmg = value; }

    }
}
