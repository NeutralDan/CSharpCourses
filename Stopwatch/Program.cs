using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var Timer = new Timer();
            Timer.Start();
            Timer.Start();
            Timer.Stop();
        }
    }
}
