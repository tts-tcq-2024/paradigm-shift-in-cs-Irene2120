using System;

namespace paradigm_shift_csharp
{
class Checker
{
    static WarningConfig warningConfig = new WarningConfig
    {
        TempWarningThreshold = 5,
        SoCWarningThreshold = 4,
        ChargeRateWarningThreshold = 0.04f
        };
    
static void Main()
{
    BtteryParameterChecker checker = new BatteryParameterChecker(warningConfig);
    
    ExpectTrue(batteryIsOk(25,70,0.7f));
    ExpectFalse(batteryIsOk(50,85,0.0f));
    Console.WriteLine("All ok");
}
   static void ExpectTrue(bool expression)
   {
       if(!expression)
       {
           Console.WriteLine("Expected true, but got false");
           Environment,Exit(1);
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






    
