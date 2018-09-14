using System;

namespace Events
{
    public class Log
    {
        public void Subscribe(Clock clock)
        {
            clock.SecondChanged += LogTime;
        }

        public void LogTime(object o, TimeInfoEventArgs e)
        {
            Console.WriteLine($"Logging {e.Hour} {e.Minute} {e.Second}");
        }
    }
}
