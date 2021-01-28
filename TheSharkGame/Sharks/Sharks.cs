using System;
using System.Collections.Generic;
using System.Text;

namespace TheSharkGame.Monsters
{
    abstract class Sharks
    {
        private string name;
        private int hp;
        private string firstAtk;
        private int firstDmg;
        private string secondAtk;
        private int secondDmg;
        private string thirdAtk;
        private int thirdDmg;
        private int giveExp;


        public Sharks()
        {

        }

        public virtual int GetAttacked(int playerDmg)
        {
            return Hp -= playerDmg;
        }

        public void SharkAppears()
        {
            Console.WriteLine("  A " + Name + " appears! ");
        }

        public void ShowHp()
        {
            Console.WriteLine("  " + Name + " hp: " + Hp);
        }

        public void SmileAndWave()
        {
            Console.WriteLine(" " +
            "\n  The " + Name + " smiles and waves back" +
            "\n  You're a good mannered chap! It wishes you a good day and swims away!");
        }

        public void LevelUpShark()
        {
            Hp *= 3;
            GiveExp *= 2;
            FirstDmg *= 2;
            SecondDmg *= 2;
        }



        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
        public string FirstAtk { get => firstAtk; set => firstAtk = value; }
        public int FirstDmg { get => firstDmg; set => firstDmg = value; }
        public string SecondAtk { get => secondAtk; set => secondAtk = value; }
        public int SecondDmg { get => secondDmg; set => secondDmg = value; }
        public string ThirdAtk { get => thirdAtk; set => thirdAtk = value; }
        public int ThirdDmg { get => thirdDmg; set => thirdDmg = value; }
        public int GiveExp { get => giveExp; set => giveExp = value; }

    }
}
