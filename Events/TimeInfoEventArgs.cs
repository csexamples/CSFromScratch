using System;

namespace Events
{
    public class TimeInfoEventArgs
    {
        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
    }
}
