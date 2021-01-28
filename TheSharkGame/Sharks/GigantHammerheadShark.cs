using System;
using System.Collections.Generic;
using System.Text;

namespace TheSharkGame.Monsters
{
    class GigantHammerheadShark : Sharks
    {
        public GigantHammerheadShark()
        {
            base.Name = "Gigant Hammerhead Shark";
            base.Hp = 13;
            base.FirstAtk = "The Giant Hammerhead Shark challanges you in a bench press battle. " +
                "\n  You stand no chance against his awesome pecs.";
            base.FirstDmg = 5;
            base.SecondAtk = "The Giant Hammerhead Shark served in Namm. Where were you? " +
                "\n  You were probably not even born yet, you millenial.";
            base.SecondDmg = 7;
            base.ThirdAtk = "The Giant Hammerhead Shark needs to get a protein bar. " +
                "\n  He will be right back to kick your butt after he has secured his rightful gains.";
            base.ThirdDmg = 0;
            base.GiveExp = 10;
        }
    }
}
