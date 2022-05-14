using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace FunnyGame
{
    class System
    {
        public void FunkyMan(string[] args)
        {
            string logNum;

            var logs = new LogManager();

            string log1 = "LOG 1";
            string log1_context = "We have created a device that allows us to travel alternate timelines\nWe have also found a timeline that seems to have a planet the consists only of squirrels, similar to ours" +
                "\nWe have decided to seal about 20 of what we call 'Skwurls' in a small enclosure.";
            string log2 = "LOG 2";
            string log2_context = "We have been studying the Skwurls to see how they will react and adapt to their new ecosystem, and we have created several small research facilites under the main sanctuary\n" +
                "We will continue to monitor the Skwurls";
            string log3 = "LOG 3";
            string log3_context = "We have found out how to merge alternate timelines and universes with ours, we will continue to test the Skwurls and then merge the timeline";
            string log4 = "LOG 4";
            string log4_context = "The Foundation has sent a warning, the ATM Core in project OC_25 has ran out of coolant, the cores temperature is heating up, and until we can get more coolant to the core, the ice in the Tunda may melt";
            string log5 = "LOG 5";
            string log5_context = "WARNING The ice is starting to melt in the Tundra, please prepare the water shields";

            Console.Title = "Project OC_25 'Skwurl Runner' Logs";
            Console.WriteLine("Hello *USER_NAME*, welcome to the Project OC_25 logs");

            Thread.Sleep(2000);

            logList:

            Console.Clear();

            Console.WriteLine($"Please type 'log 1-5', to view its respective Log");

            logNum = Console.ReadLine();

            switch(logNum)
            {
                case "log 1":
                    logs.Log(log1, log1_context);
                    goto logList;

                case "log 2":
                    logs.Log(log2, log2_context);
                    goto logList;

                case "log 3":
                    logs.Log(log3, log3_context);
                    goto logList;

                case "log 4":
                    logs.Log(log4, log4_context);
                    goto logList;

                case "log 5":
                    logs.Log(log5, log5_context);
                    goto logList;

                default:
                    Console.WriteLine("ERROR, PLEASE SPECIFY THE LOG");
                    Thread.Sleep(1000);
                    goto logList;
            }

        }
    }
}
