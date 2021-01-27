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

        public void SharkAttack()
        {
            Console.WriteLine("  A wild " + Name + " appears! ");
        }

        public int SharkRestore()
        {
            return Hp += 10;
        }

        public void LevelUpShark()
        {
            Hp += 10;
            GiveExp += 5;
            FirstDmg++;
            SecondDmg++;
            ThirdDmg++;
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
