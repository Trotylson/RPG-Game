using System;
using System.Collections.Generic;

namespace GameByMe
{
    class Player : Character
    {
        public Player() 
        {
            LowerHitTreshold = 2;
            UpperHitTreshold = 6;
        }

        ProgramerTools tools = new ProgramerTools();

        public void ChoseRace(Character player)
        {
            PlayerRace race = new PlayerRace();
            race.ChoseRace(player);
        }
        public void ChoseClass(Character player)
        {
            PlayerClass choseClass = new PlayerClass();
            choseClass.ChoseClass(player);
        }
        public void GetName()
        {
            while (true)
            {
                tools.Texting("Write your name:\t", 0, ConsoleColor.Yellow);
                Name = Console.ReadLine();
                if (Name != "") break;
                else Console.WriteLine("Free space is not a name!");
            }
        }
    }
}
