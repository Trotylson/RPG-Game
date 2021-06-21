using System;

namespace GameByMe
{
    class FireMagic : Spells
    {
        ProgramerTools tools = new ProgramerTools();

        public void ChooseFireSpell(Character character1, Character character2)
        {
            while (true)
            {
                AskForSpellFire();

                if (Spell == "1")
                {
                    Sparks sparks = new Sparks();
                    sparks.Cast(character1, character2);
                    break;
                }
                else if (Spell == "2")
                {
                    Fireball fireball = new Fireball();
                    fireball.Cast(character1, character2);
                    break;
                }
                else if (Spell == "3")
                    break;
                else tools.Texting("Wrong choice...", 2000, ConsoleColor.Red);
            }
        }

        public void AskForSpellFire()
        {
            tools.Texting("Which spell you like to use?",
                0, ConsoleColor.Yellow);
            Sparks sparks = new Sparks();
            tools.Texting("\n1 for SPARKS (" + sparks.ManaUsage + " mana usage / " +
                sparks.LowerHitTreshold + "-" + sparks.UpperHitTreshold + " damage power.)",
                0, ConsoleColor.Yellow);
            Fireball fireball = new Fireball();
            tools.Texting("\n2 for FIREBALL (" + fireball.ManaUsage + " mana usage / " +
                fireball.LowerHitTreshold + "-" + fireball.UpperHitTreshold + " damage power.)",
                0, ConsoleColor.Yellow);
            tools.Texting("\n3 for EXIT", 0, ConsoleColor.Yellow);
            Spell = Console.ReadLine();
        }
    }
}
