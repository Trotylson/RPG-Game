using System;
using System.Collections.Generic;

namespace GameByMe
{
    class PlayerRace
    {
        ProgramerTools tools = new ProgramerTools();
        public void ChoseRace(Character character)
        {
            while (true)
            {
                AskForRace(character);
                if (character.Race == "1") { Human(character); break; }
                else if (character.Race == "2") { Dwarf(character); break; }
                else if (character.Race == "3") { Elf(character); break; }
                else { tools.Texting("Wrong choice...", 2000, ConsoleColor.Red, true); }
            }
            Console.WriteLine("Selected race: " + character.Race + "\n");
        }

        public void AskForRace(Character character)
        {
            tools.Texting(character.Name + ", choose your race:\n", 0, ConsoleColor.Yellow);
            tools.Texting(
                "1 for Human\n" +
                "2 for Dwarf\n" +
                "3 for Elf\n"
                , 0, ConsoleColor.Green);
            character.Race = Console.ReadLine();
        }
        public void Human(Character character)
        {
            character.Race = "Human";
            character.LifeSignatureType = "Humanoid";
            character.MagicUse = true;
            character.BaseHealth += 30;
            character.Armor += 20;
            character.BaseMana += 40;
            character.BaseHitPower += 2;
            character.Health = character.BaseHealth;
            character.Mana = character.BaseMana;
        }
        public void Dwarf(Character character)
        {
            character.Race = "Dwarf";
            character.LifeSignatureType = "Humanoid";
            character.MagicUse = true;
            character.BaseHealth += 60;
            character.Armor += 30;
            character.BaseMana += 20;
            character.BaseHitPower += 3;
            character.Health = character.BaseHealth;
            character.Mana = character.BaseMana;
        }
        public void Elf (Character character)
        {
            character.Race = "Elf";
            character.LifeSignatureType = "Humanoid";
            character.MagicUse = true;
            character.BaseHealth += 45;
            character.Armor += 25;
            character.BaseMana += 30;
            character.BaseHitPower += 2;
            character.Health = character.BaseHealth;
            character.Mana = character.BaseMana;
        }
    }
}
