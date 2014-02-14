using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FirstTask
{
    class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            GSM testGSM = new GSM("Optimus L5", "LG", 242, "n/a", new Battery("n/a", 900, 10, BatteryType.LiIon), new Display(4, "16M"));
            testGSM.AddCall(new Call("+359898111111", 60));
            testGSM.AddCall(new Call("+359888222222", 150));
            
        }
        
    }
}
