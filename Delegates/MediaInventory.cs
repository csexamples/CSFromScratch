using System;

namespace Delegates
{
    public class MediaInventory
    {
        public delegate bool TestMedia();

        public void TestResult(TestMedia mediaDelegate)
        {
            if (mediaDelegate() == true)
            {
                Console.WriteLine("Works. Add to inventory.");
            }
            else
            {
                Console.WriteLine("Media falied. Reject.");
            }
        }
    }
}
