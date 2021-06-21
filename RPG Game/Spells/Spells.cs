using System;
using System.Threading;

namespace GameByMe
{
    class Spells : ISpells
    {
        public string Spell { get; set; }
        public string SpellName { get; set; }
        public int LowerHitTreshold { get; set; }
        public int UpperHitTreshold { get; set; }
        public int ManaUsage { get; set; }
        public int Damage { get; set; }
        public int Healing { get; set; }
        public string KindOfSpell { get; set; }

        ProgramerTools tools = new ProgramerTools();

        public void Cast(Character character1, Character character2)
        {
            if (KindOfSpell == "Damage")
            {
                CastDamageSpell(character1, character2);
            }
            else if (KindOfSpell == "Heal")
            {
                CastHealingSpell(character1, character2);
            }
            else if (KindOfSpell == "Buff")
            {
                //CastBuffSpell(char1, char2);
                //Here we add buff spells soon :)
            }
            else if (KindOfSpell == "Debuff")
            {
                //CastDebuffSpell(char1, char2);
                //Here we add debuff spells soon :)
            }
        }
        int CastDamageSpell(Character character1, Character character2)
        {
            if (character1.Mana >= ManaUsage)
            {
                Random random = new Random();
                CastingBuffor();
                Damage = random.Next(LowerHitTreshold, UpperHitTreshold);
                character2.Health -= Damage;
                character1.Mana -= ManaUsage;
                character1.HitPower = Damage;
                character1.SpellCasted = true;
                ShowEffectDamage(character1, character2);
                return Damage;
            }
            else
            {
                ProgramerTools tools = new ProgramerTools();
                tools.Texting("You don't have to much mana!", 2000,
                    ConsoleColor.Red);
                return 0;
            }
        }
        int CastHealingSpell(Character character1, Character character2)
        {
            if (character1.Mana >= ManaUsage)
            {
                Random random = new Random();
                CastingBuffor();
                Healing = random.Next(LowerHitTreshold, UpperHitTreshold);
                character1.Health += Healing;
                if (character1.Health > character1.BaseHealth) character1.Health = character1.BaseHealth;
                character1.Mana -= ManaUsage;
                character1.SpellCasted = true;
                ShowEffectHealing(character1, character2);
                return Healing;
            }
            else
            {
                ProgramerTools tools = new ProgramerTools();
                tools.Texting("You don't have to much mana!", 2000,
                    ConsoleColor.Red);
                return 0;
            }
        }
        public void UseSpell(Character character1, Character character2)
        {
            while (true)
            {
                AskForSpell();
                if (Spell == "1") 
                { 
                    FireMagic(character1, character2); 
                    break; 
                }
                else if (Spell == "2") 
                {
                   HealingMagic(character1, character2); 
                    break; 
                }
                else if (Spell == "3") 
                    break;
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
        public void CastingBuffor()
        {
            tools.Texting("Casting " + SpellName + "!", 0, ConsoleColor.Yellow);
            string cast = ".";
            for (int i = 0; i < 3; i++) 
            { 
                Console.Write(cast); 
                Thread.Sleep(1000);
            }
        }
        public void ShowEffectDamage(Character character1, Character character2)
        {
            tools.Texting("\n" + character1.Name + " attack for " + Damage + " using " +
                SpellName + ".", 0, ConsoleColor.Yellow);
            tools.Texting(character2.Name + " have " + character2.Health +
                " health points.", 0, ConsoleColor.Yellow);
        }
        public void ShowEffectHealing(Character character1, Character character2)
        {
            tools.Texting("\n" + character1.Name + " healing for " + Healing +
                " using " + SpellName + ".", 1000, ConsoleColor.Blue);
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
