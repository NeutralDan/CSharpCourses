using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Timer
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        private bool _timerRunning;

        public Timer()
        {
            _timerRunning = false;
        }
        public void Start()
        {
            if (_timerRunning)
            {
                throw new InvalidOperationException("Cannot start timer as it is already running...");
            }
            else
            {
                StartTime = DateTime.Now;
                _timerRunning = true;
                Console.WriteLine("Timer has been started!");
            }

        }

        public void Stop()
        {
            EndTime = DateTime.Now;
            _timerRunning = false;
            Console.WriteLine("Timer has ended! The timer was running for " + EndTime.Subtract(StartTime));
        }
    }
}
