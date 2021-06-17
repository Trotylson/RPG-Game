using System;
using System.Collections.Generic;

namespace GameByMe
{
    class Character : Inventory
    {
        ProgramerTools tools = new ProgramerTools();
        Random random = new Random();
        //-------- STATISTIC ----
        public string Name { get; set; } = "Being";
        public string LifeSignatureType { get; set; } = "Unknown signature";
        public string Race { get; set; } = "Unknown race";
        public string Class { get; set; } = "Unknown class";
        public int BaseHealth { get; set; }
        public int Health { get; set; } = 0;
        public int BaseMana { get; set; }
        public int Mana { get; set; } = 0;
        public int Level { get; set; } = 1;
        public int ExperienceOwned;
        public int ExpToNextLevel { get; set; } = 100;
        //--------- EQUIPMENT ----
        public int Armor { get; set; } = 0;
        public string Weapon { get; set; } = "fists";
        //--------- POTIONS ----
        public int HealthPotion { get; set; } = 4;
        public int ManaPotion { get; set; } = 4;
        //--------- ITEMS ----
        //--------- ATTACK ----
        public int BaseHitPower { get; set; }
        public int HitPower { get; set; } //any additional damage code look -> HitPower += 'additional damage';
        public int LowerHitTreshold;  
        public int UpperHitTreshold;
        //--------- SKILLS ----
        public bool SpellCasted = false;
        public bool MagicUse = false;
        public bool FireMagicUse = false;
        public bool WaterMagicUse = false;
        public bool HealingMagicUse = false;
        //--------- MONSTER ADDITIONAL STATISTICS ----
        public int ExperienceForMob;

        public int RollHit()
        {
            return HitPower = random.Next(LowerHitTreshold,UpperHitTreshold);
        }
        public void Hit(Character enemy)
        {
            RollHit();
            HitPower += BaseHitPower;
            enemy.Health -= HitPower;
        }
        public void ShowStats()
        {
            tools.Texting(Name + "||" + Race + " " + Class +
                "\nHealth: " + Health + "/" + BaseHealth +
                "\nMana: " + Mana + "/" + BaseMana +
                "\nIn hands: " + Weapon +
                "\n", 0, ConsoleColor.Gray);
        }
        public bool CanAlive()
        {
            if (Health <= 0) return false;
            return true;
        }
        public void OpenInventory(Character character)
        {
            SelectItem(character);
        }
    }
}
