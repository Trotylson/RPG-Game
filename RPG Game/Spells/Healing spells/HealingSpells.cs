using System;

namespace GameByMe
{
    class HealingSpells : Spells
    {
        ProgramerTools tools = new ProgramerTools();
        
        public void ChooseHealingSpell(Character character1, Character character2)
        {
            while (true)
            {
                AskForSpellHealing();

                if (Spell == "1")
                {
                    LightHealing lightHealing = new LightHealing();
                    lightHealing.Cast(character1, character2); 
                    break; 
                }
                else if (Spell == "2") 
                    break;
                else tools.Texting("Wrong choice...", 2000, ConsoleColor.Red);
            }
        }

        public void AskForSpellHealing()
        {
            tools.Texting("Which spell you like to use?", 0, ConsoleColor.Yellow);
            LightHealing lightHealing = new LightHealing();
            tools.Texting("\n1 for Light healing (" + lightHealing.ManaUsage + " mana usage / " +
                lightHealing.LowerHitTreshold + "-" + lightHealing.UpperHitTreshold + " cure.)", 
                0, ConsoleColor.Yellow);
            tools.Texting("\n2 for EXIT ", 0, ConsoleColor.Yellow);
            Spell = Console.ReadLine();
        }
    }
}
