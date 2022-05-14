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

            Console.WriteLine("Welcome to the ATM Foundation Database");

            Thread.Sleep(1500); 

            enter:

            Console.WriteLine("Please enter the password");

            enterPassword = Console.ReadLine();

            if (enterPassword == password || enterPassword == passLow)
            {
                Console.Clear();
                system.FunkyMan(args);
            } else
            {
                goto enter;
            }
        }
    }
}
