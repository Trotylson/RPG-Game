using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameByMe
{
    class Goblin : Character
    {
        ProgramerTools tools = new ProgramerTools();
        public Goblin()
        {
            Name = "Goblin";
            BaseHealth = 55;
            ExperienceForMob = 70;
            LowerHitTreshold = 10;
            UpperHitTreshold = 15;
            Weapon = "goblin spear";
            Health = BaseHealth;
            Warn();
        }
        public void Warn()
        {
            tools.Texting("Niaaaahahahahaa... !", 2000, ConsoleColor.Red, true);
        }
    }
}