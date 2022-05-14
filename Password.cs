using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace FunnyGame
{
    class Password
    {

        private string enterPassword;
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
            }
            else
            {
                Console.WriteLine("ERROR CANNOT FIND PROJECT SPECIFIED, PLEASE TYPE IN CORRECT PROJECT ID");
                goto enter;
            }
        }
    }
}
