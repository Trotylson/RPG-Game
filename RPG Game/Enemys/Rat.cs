using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameByMe
{
    class Rat : Character
    {
        ProgramerTools tools = new ProgramerTools();
        public Rat()
        {
            Name = "Rat";
            BaseHealth = 10;
            ExperienceForMob = 50;
            LowerHitTreshold = 2;
            UpperHitTreshold = 5;
            Weapon = "jaw";
            Health = BaseHealth;
            Warn();
        }
        public void Warn()
        {
            tools.Texting("Piiii piiiiii... !", 2000, ConsoleColor.Red, true);
        }
    }
}
