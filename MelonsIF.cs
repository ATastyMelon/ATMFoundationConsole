using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using FunnyGame;

namespace ATMFoundationConsole
{
    class MelonsIF
    {
        private string logNum;

        public void PEEPEE(string[] args)
        {
            var logs = new LogManager();

            string log1 = "LOG 1";
            string log1_context = "WARNING, ATM S.T. Ripper is preparing for a test fire, be warned that space-time may be warped for a while";
            string log2 = "LOG 2";
            string log2_context = "We have done it, we have opened a gateway to other universes and timelines with the S.T. Ripper, we are sending an explore team to scout dimension OC2507";
            string log3 = "LOG 3";
            string log3_context = "We have found a planet in dimension OC2507 that consists of mainly squirrel like creatures, and we have decided to do some tests, we are putting around 20 in a small enclosure.\nWe will continue to log and monitor these 'Skwurls' as some are calling them";
            string log4 = "LOG 4";
            string log4_context = "The Skwurls have began to develop a small society, and they have adapted to their new ecosystem very well, we will continue to monitor";
            string log5 = "LOG 5";
            string log5_context = "The ATM Core has ran out of coolant, and it is unsafe for travel until we get more coolant to the core, due to the excess heat, the ice in the TUNDRA may melt, so team, prepare the water sheilds.";

            Console.Clear();
            Console.WriteLine("Welcome to the Melon Interface");
            Console.WriteLine("This is the Admin Interface");
            Thread.Sleep(1500);

            logChoice:

            Console.Clear();
            Console.WriteLine("Please type 'atmlog 1-5' to view its respective log");

            logNum = Console.ReadLine();

            switch(logNum)
            {
                case "atmlog 1":
                    logs.Log(log1, log1_context);
                    goto logChoice;
                case "atmlog 2":
                    logs.Log(log2, log2_context);
                    goto logChoice;
                case "atmlog 3":
                    logs.Log(log3, log3_context);
                    goto logChoice;
                case "atmlog 4":
                    logs.Log(log4, log4_context);
                    goto logChoice;
                case "atmlog 5":
                    logs.Log(log5, log5_context);
                    goto logChoice;

                default:
                    Console.WriteLine("ERROR, CANNOT FIND LOG SPECIFIED");
                    Thread.Sleep(1500);
                    goto logChoice;
            }
        }
    }
}
