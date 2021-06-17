using System;
using System.Collections.Generic;
using System.Threading;

namespace GameByMe
{
    class Fireball
    {
        ProgramerTools tools = new ProgramerTools();
        Random random = new Random();

        string Name = "Fireball";
        public int LowerHitTreshold = 20;
        public int UpperHitTreshold = 30;
        public int ManaUsage = 45;
        int Damage { get; set; }

        public int Attack(Character character1, Character character2)
        {
            if (character1.Mana >= ManaUsage)
            {
                CastSpell();
                Damage = random.Next(LowerHitTreshold, UpperHitTreshold);
                character2.Health -= Damage;
                character1.Mana -= ManaUsage;
                character1.HitPower = Damage;
                character1.SpellCasted = true;
                ShowEffect(character1, character2);
                return Damage;
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
            tools.Texting("\n" + character1.Name + " attack for " + Damage + " using " +
                Name + ".", 0, ConsoleColor.Yellow);
            tools.Texting(character2.Name + " have " + character2.Health +
                " health points.", 0, ConsoleColor.Yellow);
        }
        public void CastSpell()
        {
            tools.Texting("Casting " + Name + "!", 0, ConsoleColor.Yellow);
            string cast = ".";
            for (int i = 0; i < 3; i++) { Console.Write(cast); Thread.Sleep(1000); }
        }
    }
}
