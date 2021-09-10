using System;
using System.Diagnostics;
using System.Threading;

namespace stopwatch_prblm.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
           
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Time starting");
            stopwatch.Start();

            Thread.Sleep(1000);
            stopwatch.Stop();
            Console.WriteLine("End stopwatch");
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("time elapsed " + elapsedTime);


        }
    }
}

