using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameByMe
{
    class HealingSpells
    {
        string Spell;
        ProgramerTools tools = new ProgramerTools();
        LightHealing lightHealing = new LightHealing();

        public void ChooseHealingSpell(Character character1, Character character2)
        {
            while (true)
            {
                AskForSpell();
                if (Spell == "1") { lightHealing.Heal(character1, character2); break; }
                else if (Spell == "2") break;
                else tools.Texting("Wrong choice...", 2000, ConsoleColor.Red);
            }
        }

        public void AskForSpell()
        {
            tools.Texting("Which spell you like to use?" +
                "\n1 for Light healing (" + lightHealing.ManaUsage + " mana usage / " + lightHealing.LowerHitTreshold + "-" + lightHealing.UpperHitTreshold + " cure.)" +
                "\n2 for EXIT "
                , 0, ConsoleColor.Yellow);
            Spell = Console.ReadLine();
        }
    }
}
