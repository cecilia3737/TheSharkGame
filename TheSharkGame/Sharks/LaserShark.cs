using System;
using System.Collections.Generic;
using System.Text;

namespace TheSharkGame.Monsters
{
    class LaserShark : Sharks
    {
        public LaserShark()
        {
            base.Name = "Laser Shark";
            base.Hp = 12;
            base.FirstAtk = "The Laser Shark yells 'Imaffahringmalasah' and his eyes shoot hot laser beams towards you. " +
                "\n  It is a direct hit!";
            base.FirstDmg = 3;
            base.SecondAtk = "The Laser Shark starts a laser rave! You get stomped to the beat of the music.";
            base.SecondDmg = 2;
            base.ThirdAtk = "The Laser Shark fires his pew pew canon, you feel the heat of the laser passing right next to your ear. " +
                "\n  Pew pew phew.";
            base.ThirdDmg = 0;
            base.GiveExp = 7;
        }
    }
}
