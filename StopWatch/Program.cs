using System;
using System.Collections.Generic;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();

            for (var i=0; i<2; i++)
            {
                stopWatch.Start();
                Thread.Sleep(10000);
                stopWatch.Stop();

                Console.WriteLine("Duration:  " + stopWatch.GetInterval());
                Console.WriteLine("Press Enter to run it again...");
                Console.ReadLine();
            }
        }
    }
}

