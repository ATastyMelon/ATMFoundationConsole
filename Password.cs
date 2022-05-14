using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace FunnyGame
{
    class Password
    {

        private string enterPassword;
        private string enterPasswordMelon;
        private string password = "OC_25";
        private string passLow = "oc_25";

        public void MainGame(string[] args)
        {
            var system = new System();

            Console.Title = "ATM Foundation Database";

            Console.Clear();

            Console.WriteLine("Welcome to the ATM Foundation Database");

            Thread.Sleep(1500); 

            Console.WriteLine("Please enter the project you wish to view the logs of");

        enter:

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
                Console.WriteLine("Correct Password, unfortunately, this section is still under construction, please come back soon");
                Thread.Sleep(2500);
                Console.Clear();
                goto enter;
            } else
            {
                Console.WriteLine("INCORRECT PASSWORD, REBOOTING");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }
    }
}
