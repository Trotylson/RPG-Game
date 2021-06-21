using System;
using System.Collections.Generic;
using System.Threading;

namespace GameByMe
{
    class FightSystem
    {
        Random random = new Random();
        LevelingSystem checkStats = new LevelingSystem();
        ProgramerTools tools = new ProgramerTools();
        public void Fight(Character player, Character enemy)
        {
            tools.Texting("Wild " + enemy.Name + " attack!", 2000, ConsoleColor.Red, true);
            int i = 1;
            while (player.CanAlive() && enemy.CanAlive())
            {
                Console.WriteLine("Hit " + i + "\n");
                ShowStats(player, enemy);
                int rand = random.Next(1, 100);
                if (rand % 2 == 1)
                {
                    UseInventory(player);
                    if (player.MagicUse == true) AskForSpell(player, enemy);
                    if (player.SpellCasted == false) Duel(player, enemy);
                    player.SpellCasted = false;
                }
                else Duel(enemy, player);
                Console.WriteLine();
                i++;
                Thread.Sleep(2000);
                Console.Clear();
            }

            if (player.CanAlive())
            {
                Console.WriteLine(player.Name + " " + player.Class + " win fight!");
                checkStats.UpdateExperience(player, enemy);
            }
            else Console.WriteLine(enemy.Name + " " + enemy.Class + " win fight!");
        }

        public void ShowStats(Character character1, Character character2)
        {
            character1.ShowStats();
            character2.ShowStats();
        }

        public void Duel(Character character1, Character character2)
        {
            character1.Hit(character2);
            Console.WriteLine(character1.Name + " " + " attack for " + character1.HitPower + " using " + character1.Weapon + ".");
            character1.HitPower = 0;
            Console.WriteLine(character2.Name + " " + " have " + character2.Health + " health points.");
        }
        public void AskForSpell(Character character1, Character character2)
        {
            while (true)
            {
                Spells spell = new Spells();
                tools.Texting("Do you want use any spells?\n" + "1 for YES\n2 for NO", 0, ConsoleColor.Yellow);
                string choice = Console.ReadLine();

                if (choice == "1") { spell.UseSpell(character1, character2); break; }
                else if (choice == "2") break;
                else tools.Texting("Wrong choice", 2000, ConsoleColor.Red);
            }
        }

        public void UseInventory(Character character)
        {
            while (true)
            {
                tools.Texting("Do you want to open your inventory?\n1 for YES\n2 for NO", 0, ConsoleColor.Yellow);
                string choice = Console.ReadLine();

                if (choice == "1") { character.SelectItem(character); break; }
                else if (choice == "2") break;
                else tools.Texting("Wrong choice", 2000, ConsoleColor.Red);
            }
        }
    }
}