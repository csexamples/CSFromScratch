using System;

namespace Events
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Clock clock = new Clock();
            DigitalClock digitalClock = new DigitalClock();
            digitalClock.Subscribe(clock);
            Log log = new Log();
            log.Subscribe(clock);
            clock.Run();
        }
    }
}
