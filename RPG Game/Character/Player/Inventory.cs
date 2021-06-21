using System;

namespace GameByMe
{
    class Inventory
    {
        public string ItemName;
        ProgramerTools tools = new ProgramerTools();
        public void SelectItem(Character character)
        {
            tools.Texting("Which item do you want us?\n" +
                "1 for HEALTH POTIONS (" + character.HealthPotion +
                ")\n2 for MANA POTION (" + character.ManaPotion +
                ")\n3 for USE ITEM" +
                "\n4 for NO",0,ConsoleColor.Blue);
            int selectedItem = int.Parse(Console.ReadLine());
            if (selectedItem == 1) HealPotionUse(character);
            else if (selectedItem == 2) ManaPotionUse(character);
        }
        //------------------------ ITEMS \/ ----------------------------
        public void HealPotionUse(Character character)
        {
            if (character.HealthPotion > 0)
            {
                ItemName = "Heal potion";
                tools.Texting(character.Name + " using " + ItemName + 
                    ".", 2000, ConsoleColor.Green);
                character.Health += 25;
                character.HealthPotion -= 1;
                if (character.Health > character.BaseHealth) character.Health = character.BaseHealth;
                tools.Texting("You have now " + 
                    character.Health, 2000, ConsoleColor.Green);
            }
            else tools.Texting("You don't have any health potions!", 2000, ConsoleColor.Red);
        }
        public void ManaPotionUse(Character character)
        {
            if (character.ManaPotion > 0)
            {
                ItemName = "Mana potion";
                tools.Texting(character.Name + " using " + ItemName +
                    ".", 2000, ConsoleColor.Green);
                character.Mana += 25;
                character.ManaPotion -= 1;
                if (character.Mana > character.BaseMana) character.Mana = character.BaseMana;
                tools.Texting("You have now " +
                    character.Mana, 2000, ConsoleColor.Green);
            }
            else tools.Texting("You don't have any mana potions!", 2000, ConsoleColor.Red);
        }
    }
}
