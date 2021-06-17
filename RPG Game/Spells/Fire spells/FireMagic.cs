using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameByMe
{
    class FireMagic
    {
        string Spell;
        ProgramerTools tools = new ProgramerTools();
        Sparks sparks = new Sparks();
        Fireball fireball = new Fireball();

        public void ChooseFireSpell(Character character1, Character character2)
        {
            while (true)
            {
                AskForSpell();
                if (Spell == "1") { sparks.Attack(character1, character2); break; }
                else if (Spell == "2") { fireball.Attack(character1, character2); break; }
                else if (Spell == "3") break;
                else tools.Texting("Wrong choice...", 2000, ConsoleColor.Red);
            }
        }

        public void AskForSpell()
        {
            tools.Texting("Which spell you like to use?" +
                "\n1 for SPARKS (" + sparks.ManaUsage + " mana usage / "+ 
                sparks.LowerHitTreshold + "-" + sparks.UpperHitTreshold +" damage power.)" +
                "\n2 for FIREBALL (" + fireball.ManaUsage + " mana usage / " + 
                fireball.LowerHitTreshold + "-" + fireball.UpperHitTreshold + " damage power.)" +
                "\n3 for EXIT",
                0, ConsoleColor.Yellow);
            Spell = Console.ReadLine();
        }
    }
}
