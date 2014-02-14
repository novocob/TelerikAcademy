using System;

namespace _01.FirstTask
{
    class GSMTest
    {
        static void Main()
        {
            GSM[] gsmArray = new GSM[3];
            gsmArray[0] = new GSM("Xperia Acro S", "Sony", 589, "n/a", new Battery("n/a", 290, 6.40, BatteryType.LiIon), new Display(4.3, "16M"));
            gsmArray[1] = new GSM("Galaxy Ace", "Samsung", 237, "n/a", new Battery("n/a", 640, 11, BatteryType.LiIon), new Display(3.5, "256K"));
            gsmArray[2] = GSM.iPhone4S;

            for (int i = 0; i < gsmArray.Length; i++)
            {
                Console.WriteLine(gsmArray[i].ToString());
                Console.WriteLine();
            }

            GSMCallHistoryTest.CallHistoryTest();
        }
    }
}
