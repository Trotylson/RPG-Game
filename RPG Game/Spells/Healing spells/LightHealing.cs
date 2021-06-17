using System;
using System.Collections.Generic;
using System.Threading;

namespace GameByMe
{ 
    class LightHealing
    {
        ProgramerTools tools = new ProgramerTools();
        Random random = new Random();

        string Name = "Light healing";
        public int LowerHitTreshold = 20;
        public int UpperHitTreshold = 30;
        public int ManaUsage = 20;
        int Healing { get; set; }

        public int Heal(Character character1, Character character2)
        {
            if (character1.Mana >= ManaUsage)
            {
                CastSpell();
                Healing = random.Next(LowerHitTreshold, UpperHitTreshold);
                character1.Health += Healing;
                if (character1.Health > character1.BaseHealth) character1.Health = character1.BaseHealth;
                character1.Mana -= ManaUsage;
                character1.SpellCasted = true;
                ShowEffect(character1, character2);
                return Healing;
            }
            else
            {
                tools.Texting("You don't have to much mana!", 2000, 
                    ConsoleColor.Red);
                return 0;
            }
        }
        public void ShowEffect(Character character1, Character character2)
        {
            tools.Texting("\n" + character1.Name + " healing for " + Healing + 
                " using " + Name + ".", 1000, ConsoleColor.Blue);
        }
        public void CastSpell()
        {
            tools.Texting("Casting " + Name + "!", 0, ConsoleColor.Yellow);
            string cast = ".";
            for (int i = 0; i < 3; i++) { Console.Write(cast); Thread.Sleep(1000); }
        }
    }
}
