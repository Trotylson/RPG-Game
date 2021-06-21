using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameByMe
{
    class Monster : Character
    {
        public Monster(string name, int health, int lowerHit, int upperHit) // can write enemy
        {
            Name = name;
            BaseHealth = health;
            LowerHitTreshold = lowerHit;
            UpperHitTreshold = upperHit;
            Health = BaseHealth;
            
        }
        public Monster(Player player) // can randomize enemy selection
        {
            if (player.Level <= 2) RandomMobLvl_0_3();
            else if (player.Level >= 3 && player.Level <= 7) RandomMobLvl_3_7();
        }


        public Random ChoseRandom = new Random();
        public void RandomMobLvl_0_3() // mobs for player from 0 - 3 lvl.
        {
            string[] MobsForLvl0_3Tab = { "Rat", "Wolf" }; //<-- mobs for player from 0-3 lvl.
            Name = MobsForLvl0_3Tab[ChoseRandom.Next(MobsForLvl0_3Tab.Length)];
            if (Name == "Rat") CallRat();
            else if (Name == "Wolf") CallWolf();
        }
        public void RandomMobLvl_3_7() // mobs for player from 3 - 7 lvl.
        {
            string[] MobsForLvl3_7Tab = { "Bear", "Goblin" };//<-- mobs for player from 3-7 lvl.
            Name = MobsForLvl3_7Tab[ChoseRandom.Next(MobsForLvl3_7Tab.Length)];
            if (Name == "Bear") CallBear();
            else if (Name == "Goblin") CallGoblin();
        }
        public void RandomMobLvl_7_15() // mobs for player from 3 - 7 lvl.
        {
            string[] MobsForLvl7_15Tab = {/*new mobs for lvl 7-15*/ "" };
            Name = MobsForLvl7_15Tab[ChoseRandom.Next(MobsForLvl7_15Tab.Length)];
        }
//------------ \/ BESTIARY \/ ---------------------------------------------------------------
        public void CallRat()
        {
            Name = "Rat";
            BaseHealth = 10;
            ExperienceForMob = 50;
            LowerHitTreshold = 2;
            UpperHitTreshold = 5;
            Weapon = "jaw";
            Health = BaseHealth;
        }
        public void CallWolf()
        {
            Name = "Wolf";
            BaseHealth = 25;
            ExperienceForMob = 70;
            LowerHitTreshold = 7;
            UpperHitTreshold = 15;
            Weapon = "jaw";
            Health = BaseHealth;
        }
        public void CallBear()
        {
            Name = "Bear";
            BaseHealth = 75;
            ExperienceForMob = 150;
            LowerHitTreshold = 10;
            UpperHitTreshold = 20;
            Weapon = "claws";
            Health = BaseHealth;
        }
        public void CallGoblin()
        {
            Name = "Goblin";
            BaseHealth = 55;
            ExperienceForMob = 70;
            LowerHitTreshold = 10;
            UpperHitTreshold = 15;
            Weapon = "goblin spear";
            Health = BaseHealth;
        }
    }
}