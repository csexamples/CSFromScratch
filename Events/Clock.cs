using System;
using System.Threading;

namespace Events
{
    public class Clock
    {
        public delegate void SecondChangeHandler(object clock, TimeInfoEventArgs timeInfo);

        public event SecondChangeHandler SecondChanged;

        public void Run()
        {
            for (; ; )
            {
                Thread.Sleep(100);
                DateTime now = DateTime.Now;

                TimeInfoEventArgs timeInfoEventArgs = new TimeInfoEventArgs(now.Hour, now.Minute, now.Second);

                if (SecondChanged != null)
                {
                    SecondChanged(this, timeInfoEventArgs);
                }
            }
        }
    }
}
