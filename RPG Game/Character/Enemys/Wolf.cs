using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameByMe
{
    class Wolf : Character
    {
        ProgramerTools tools = new ProgramerTools();
        public Wolf()
        {
            Name = "Wolf";
            BaseHealth = 25;
            ExperienceForMob = 100;
            LowerHitTreshold = 7;
            UpperHitTreshold = 10;
            Weapon = "jaw";
            Health = BaseHealth;
            Warn();
        }
        public void Warn()
        {
            tools.Texting("Wrrr... Woooofff... !", 2000, ConsoleColor.Red, true);
        }
    }
}
