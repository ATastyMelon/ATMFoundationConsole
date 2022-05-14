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
            string log1_context = "TEST LOG CONTEXT";
            string log2 = "LOG 2 TEST";
            string log2_context = "TEST LOG CONTEXT";
            string log3 = "LOG 3 TEST";
            string log3_context = "TEST LOG CONTEXT";
            string log4 = "LOG 4 TEST";
            string log4_context = "TEST LOG CONTEXT";
            string log5 = "LOG 5 TEST";
            string log5_context = "TEST LOG CONTEXT";

            Console.Title = "Project OC_25 'Skwurl Runner' Logs";
            Console.WriteLine("Hello *USER_NAME*, welcome to the Project OC_25 logs");

            Thread.Sleep(1000);

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
