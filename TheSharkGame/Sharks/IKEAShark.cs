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
            base.FirstAtk = "The IKEA Shark begins a dance battle, you make some moves to but trip and fall...";
            base.FirstDmg = 1;
            base.SecondAtk = "The IKEA Shark mocks you. Does it hurt?";
            base.SecondDmg = 1;
            base.ThirdAtk = "The IKEA Shark bestows a dance lesson upon you. He encourages you to keep practicing your moves.";
            base.ThirdDmg = 0;
            base.GiveExp = 3;
        }
    }
}
