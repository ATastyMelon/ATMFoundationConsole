using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace FunnyGame
{
    class LogManager
    {
        public void Log(string text, string context)
        {
            Console.Clear();
            Console.WriteLine(text);
            Console.Beep();
            Thread.Sleep(500);
            Console.WriteLine(context);
            Console.Beep();
            Console.WriteLine("Press any key to go back");
            Console.ReadKey();
        }
    }
}
