using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameByMe
{
    class Bear : Character
    {
        ProgramerTools tools = new ProgramerTools();
        public Bear()
        {
            Name = "Bear";
            BaseHealth = 75;
            ExperienceForMob = 150;
            LowerHitTreshold = 10;
            UpperHitTreshold = 20;
            Weapon = "claws";
            Health = BaseHealth;
            Warn();
        }
        public void Warn()
        {
            tools.Texting("Wrrr... Rooaarrr... !", 2000, ConsoleColor.Red, true);
        }
    }
}
