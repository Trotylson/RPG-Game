using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameByMe
{
    class LevelingSystem
    {
        ProgramerTools tools = new ProgramerTools();
        public void UpdateExperience(Character player, Character enemy)
        {
            tools.Texting(enemy.Name + " is dead...\n", 2000, ConsoleColor.Green);
            Thread.Sleep(2000);
            for (int i = 0; i < enemy.ExperienceForMob; i++)
            {
                player.ExperienceOwned++;
            }
            tools.Texting("You reach " + enemy.ExperienceForMob +
                " experience for this creature!", 0, ConsoleColor.Green);
            if (player.ExperienceOwned >= player.ExpToNextLevel)
            {
                while (player.ExperienceOwned >= player.ExpToNextLevel)
                {
                    player.Level++;
                    player.ExpToNextLevel *= 2;

                    tools.Texting("Congratulations! You level up! Level " + player.Level,
                        2000, ConsoleColor.Yellow);
                    tools.Texting("You have " + player.ExperienceOwned + "." +
                        " Next level will be after reach " + player.ExpToNextLevel +
                        " experience.", 5000, ConsoleColor.Green, true);
                }
            }
            else
            {
                tools.Texting("You have " + player.ExperienceOwned + " experience points." +
                    " Next level will be after reach " + player.ExpToNextLevel +
                    " experience points.\n", 5000, ConsoleColor.Green, true);
            }
        }
    }
}
