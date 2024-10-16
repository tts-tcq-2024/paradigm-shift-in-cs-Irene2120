using System;

namespace paradigm_shift_csharp
{
  class CheckeBatteryParmeters
  {
    static void Main()
    {
      Check_StatusoOfBattery BatteryParameters = new Check_StatusoOfBattery();
      BatteryParmeters.ExpectTrue(Check_StatusoOfBattery.BatteryIsOk(25,70,0.7f));
      BatteryParmeters.ExpectFalse(Check_StatusoOfBattery.BatteryIsOk(50,85,0.0f));
      Console.WriteLine("AllChecks passed!");
    }
  }
}
