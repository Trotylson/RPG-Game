using System;
using System.Collections.Generic;

namespace GameByMe
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------- it's for tests :) -----------
            Player player = new Player();
            FightSystem fight = new FightSystem();
            player.GetName();
            player.ChoseRace(player);
            player.ChoseClass(player);
            //////////////////////////////////
            Monster monster = new Monster("Kurwinox", 100, 10, 30);
            //////////////////////////////////
            Rat rat1 = new Rat();
            fight.Fight(player, rat1);
            Wolf wolf = new Wolf();
            fight.Fight(player, wolf);
            Bear bear = new Bear();
            fight.Fight(player, bear);
            Goblin goblin = new Goblin();
            fight.Fight(player, goblin);
            //////////////////////////////////
            Monster monster2 = new Monster(player);
            fight.Fight(player, monster2);
            Monster monster3 = new Monster(player);
            fight.Fight(player, monster3);
            Monster monster4 = new Monster(player);
            fight.Fight(player, monster4);
            Monster monster5 = new Monster(player);
            fight.Fight(player, monster5);
            Monster monster6 = new Monster(player);
            fight.Fight(player, monster6);
            Monster monster7 = new Monster(player);
            fight.Fight(player, monster7);
            Monster monster8 = new Monster(player);
            fight.Fight(player, monster8);
            Monster monster9 = new Monster(player);
            fight.Fight(player, monster9);
            Monster monster10 = new Monster(player);
            fight.Fight(player, monster10);
        }
    }
}
