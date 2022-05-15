using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using ATMFoundationConsole;

namespace FunnyGame
{
    class Password
    {

        private string enterPassword;
        private string enterPasswordMelon;
        private string password = "OC_25";

        public void MainGame(string[] args)
        {
            var system = new System();
            var melonsIF = new MelonsIF();

            Console.Title = "ATM Foundation Database";

            Console.Clear();

        enter:

            Console.WriteLine("Welcome to the ATM Foundation Database");

            Thread.Sleep(1500); 

            Console.WriteLine("Please enter the project you wish to view the logs of");


            enterPassword = Console.ReadLine();

            if (enterPassword == password)
            {
                Console.Clear();
                system.FunkyMan(args);
            }
            else if (enterPassword == "OVERRIDE")
            {
                Console.Clear();
                Console.WriteLine("Hello *MELON*, please enter your password");
                goto melonPass;
            }
            else
            {
                Console.WriteLine("ERROR CANNOT FIND PROJECT SPECIFIED, PLEASE TYPE IN CORRECT PROJECT ID");
                goto enter;
            }

        melonPass:

            enterPasswordMelon = Console.ReadLine();

            if (enterPasswordMelon == "ATM")
            {
                Console.WriteLine("Hello *MELON*, transferring you to your interface");
                Thread.Sleep(1500);
                melonsIF.PEEPEE(args);
            } else
            {
                Console.WriteLine("INCORRECT PASSWORD, REBOOTING");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }
    }
}
