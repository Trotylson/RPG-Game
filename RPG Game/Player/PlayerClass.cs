using System;
using System.Collections.Generic;

namespace GameByMe
{
    class PlayerClass
    {
        ProgramerTools tools = new ProgramerTools();
        public void ChoseClass(Character character)
        {
            while (true)
            {
                AskForCharacterClass(character);
                if (character.Class == "1") { Mage(character); break; }
                else if (character.Class == "2") { Warrior(character); break; }
                else if (character.Class == "3") { Paladin(character); break; }
                else { tools.Texting("Wrong choice...", 2000, ConsoleColor.Red, true); }
            }
            Console.WriteLine("Selected class: " + character.Class + "\n");
        }
        public void AskForCharacterClass(Character character)
        {
            tools.Texting(character.Name + ", choose your class:\n", 0, ConsoleColor.Yellow);
            tools.Texting("1 for Mage\n" +
                "2 for Warrior\n" +
                "3 for Paladin", 0, ConsoleColor.Green);
            character.Class = Console.ReadLine();
        }
        public void Mage(Character character)
        {
            character.Class = "Mage";
            character.BaseHealth += 20;
            character.Armor += 10;
            character.BaseMana += 150;
            character.BaseHitPower += 1;
            character.Health = character.BaseHealth;
            character.Mana = character.BaseMana;
            int MagicModificator = 3;
            character.BaseHitPower *= MagicModificator;
            character.MagicUse = true;
            character.FireMagicUse = true;
            character.HealingMagicUse = true;
        }
        public void Warrior(Character character)
        {
            character.Class = "Warrior";
            character.BaseHealth += 60;
            character.Armor += 30;
            character.Mana += 10;
            character.Health = character.BaseHealth;
            character.Mana = character.BaseMana;
            character.BaseHitPower += 3;
            int StranghtModification = 3;
            character.BaseHitPower *= StranghtModification;
            character.MagicUse = false;
            character.FireMagicUse = false;
            character.HealingMagicUse = false;
        }
        public void Paladin(Character character)
        {
            character.Class = "Paladin";
            character.BaseHealth += 40;
            character.Armor += 40;
            character.Mana += 40;
            character.Health = character.BaseHealth;
            character.Mana = character.BaseMana;
            character.BaseHitPower += 2;
            int StranghtModification = 2;
            character.BaseHitPower *= StranghtModification;
            character.MagicUse = true;
            character.FireMagicUse = false;
            character.HealingMagicUse = true;
        }
    }
}
