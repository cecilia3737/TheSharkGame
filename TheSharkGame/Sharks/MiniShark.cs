using System;
using System.Collections.Generic;
using System.Text;

namespace TheSharkGame.Monsters
{
    class MiniShark : Sharks
    {
        public MiniShark()
        {
            base.Name = "Mini Shark";
            base.Hp = 7;
            base.FirstAtk = "Baby Shark do-do-do-do-do-doh. Oh my, now it's going to be stuck in your head all day.";
            base.FirstDmg = 2;
            base.SecondAtk = "The Mini Shark takes a bite off you. Wow, could those little fangs really hurt so much?";
            base.SecondDmg = 3;
            base.ThirdAtk = "The Mini Shark attacks you with his big, cute eyes. He is so adorable! " +
                "\n  Nothing happens, except for your icy heart melting.";
            base.ThirdDmg = 0;
            base.GiveExp = 5;
        }
    }
}
