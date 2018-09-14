using System;

namespace Delegates
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            MediaInventory mediaInventory = new MediaInventory();
            RecordPlayer recordPlayer = new RecordPlayer();
            CassettePlayer cassettePlayer = new CassettePlayer();

            MediaInventory.TestMedia testRecordDelegate = new MediaInventory.TestMedia(recordPlayer.PlayRecord);
            MediaInventory.TestMedia testCassetteDelegate = new MediaInventory.TestMedia(cassettePlayer.TestCassette);

            mediaInventory.TestResult(testRecordDelegate);
            mediaInventory.TestResult(testCassetteDelegate);
        }
    }
}
