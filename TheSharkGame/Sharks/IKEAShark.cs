using System;
using System.Collections.Generic;
using System.Text;

namespace TheSharkGame.Monsters
{
    class IKEAShark : Sharks
    {
        public IKEAShark()
        {
            base.Name = "IKEA Shark";
            base.Hp = 10;
            base.FirstAtk = "This is the first attack, The Ikea shark does something to the player.";
            base.FirstDmg = 2;
            base.SecondAtk = "This is the second attack, The Ikea shark does something to the player.";
            base.SecondDmg = 2;
            base.ThirdAtk = "This is the third attack, The Ikea shark does something to the player.";
            base.ThirdDmg = 0;
            base.GiveExp = 5;
        }
    }
}
