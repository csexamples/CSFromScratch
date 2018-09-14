using System;

namespace Events
{
    public class DigitalClock
    {
        public void Subscribe(Clock clock)
        {
            clock.SecondChanged += NewTime;
        }

        public void NewTime(object o, TimeInfoEventArgs e)
        {
            Console.WriteLine($"Current time: {e.Hour} {e.Minute} {e.Second}");
        }
    }
}
