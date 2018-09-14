using System;

namespace Exceptions
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Console.WriteLine("Open file here...");

            try
            {
                Console.WriteLine("Throwing exception...");
                throw new Exception();
            }
            catch
            {
                Console.WriteLine("Handling exception");
            }
            finally
            {
                Console.WriteLine("Closing file...");
            }
        }
    }
}
