using System;
using System.Collections.Generic;
using System.Text;

namespace TheSharkGame.Monsters
{
    class MagicalWhaleShark : Sharks
    {
        public MagicalWhaleShark()
        {
            base.Name = "Magical Whale Shark";
            base.Hp = 8;
            base.FirstAtk = "You say it is quite late in the game for a Magical Whale Shark to appear. " +
                "\n  You fool. The Magical Whale Shark is never late. Nor is he early. " +
                "\n  You are wrong. Dead wrong. Simple as that.";
            base.FirstDmg = 1;
            base.SecondAtk = "The Magical Whale Shark pulls a rabbit out of his hat. " +
                "\n  Wow, how did he do that? While you are not looking, he steals your watch.";
            base.SecondDmg = 2;
            base.ThirdAtk = "The Magical Whale Shark tries a waterfall attack. Hey, we're below the surface. It has no effect.";
            base.ThirdDmg = 0;
            base.GiveExp = 5;
        }
    }
}
