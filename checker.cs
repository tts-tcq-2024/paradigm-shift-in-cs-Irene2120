using System;

namespace ParadigmShiftCSharp
{
    class Program
    {
        static void Main()
        {
            var statusChecker = new BatteryStatusChecker();
            statusChecker.AssertTrue(BatteryStatusChecker.IsBatteryHealthy(25, 70, 0.7f));
            statusChecker.AssertFalse(BatteryStatusChecker.IsBatteryHealthy(50, 85, 0.0f));
            Console.WriteLine("All checks passed!");
        }
    }
}
