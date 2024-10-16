using System;

namespace paradigm_shift_csharp
{
class Checker
{
    static WarningConfigure  warningConfig = new WarningConfig
    {
        TempWarningThreshold = 5,
        SoCWarningThreshold = 4,
        ChargeRateWarningThreshold = 0.04f
        };
    
static void Main()
{
    BtteryParameterChecker checker = new BatteryParameterChecker(warningConfig);
    
    ExpectTrue(batteryIsOk(25,70,0.7f));      //values within range
    ExpectFalse(batteryIsOk(50,85,0.0f)); //values not within range
    Console.WriteLine("All ok");
}
   static void ExpectTrue(bool expression)
   {
       if(!expression)
       {
           Console.WriteLine("Expected true, but got false");
           Environment.Exit(1);
       }
   }
    static void ExpectFalse(bool expression)
    {
        if(expression)
        {
            Console.WriteLine("Expected false,but got true");
            Environment.Exit(1);
        }
    }
}
}






    
