using System;
using System.Collections.Generic;

namespace GameByMe
{
    class Spells
    {
        string Spell;
        Random random = new Random();
        ProgramerTools tools = new ProgramerTools();

        public void UseSpell(Character character1, Character character2)
        {
            while (true)
            {
                AskForSpell();
                if (Spell == "1") { FireMagic(character1, character2); break; }
                else if (Spell == "2") { HealingMagic(character1, character2); break; }
                else if (Spell == "3") break;
                else tools.Texting("Wrong choice...", 2000, ConsoleColor.Red);
            }
        }

        public void AskForSpell()
        {
            tools.Texting("Which spell you like to use?" +
                "\n1 for FIRE MAGIC " +
                "\n2 for HEALING MAGIC " +
                "\n3 for EXIT",
                0, ConsoleColor.Yellow);
            Spell = Console.ReadLine();
        }

        //----- DAMAGING SPELLS \/ -----
        public void FireMagic(Character character1, Character character2)
        {
            if (character1.FireMagicUse == true)
            {
                FireMagic fireMagic = new FireMagic();
                fireMagic.ChooseFireSpell(character1, character2);
            }
            else tools.Texting("You can not use fire magic!", 2000, ConsoleColor.Red);
        }
        //----- HEALING SPELLS \/ -----
        public void HealingMagic(Character character1, Character character2)
        {
            if (character1.HealingMagicUse == true)
            {
                HealingSpells healing = new HealingSpells();
                healing.ChooseHealingSpell(character1, character2);
            }
            else tools.Texting("You can not use healing magic!", 2000, ConsoleColor.Red);
        }
    }
}
