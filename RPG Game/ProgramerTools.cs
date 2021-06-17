using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameByMe
{
    class ProgramerTools
    {
        public void Texting(string text, int consolSleep,
            ConsoleColor textColor, bool consoleClear = false)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(text);
            Thread.Sleep(consolSleep);
            if (consoleClear == true)
            {
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
