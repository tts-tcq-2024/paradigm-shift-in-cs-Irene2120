using System;

namespace paradigm_shift_csharp
{
  class BatteryParameterChecker
  {
    private readonly WarningConfigure warning_config;
    public BatteryParameterChecker(WarningConfigure warningConfig)
    {
      warning_config = warningConfig;
    }
    public bool batteryIsOk(float temp,float soc,float chargerate)
    {
      return Temp_Ok(temp) && soc_ok(soc) && chargerate_ok(chargerate);
    }
    private bool Temp_ok(float tremp)
    {
      if(temp <0|| temp>45)
      {
        Console.WriteLine("Temperature is out of range!");
        return false;
      }
      else if(temp>40)
      {
        Console.WriteLine("Warning :Approaching temperature limit!");
      }
      return true;
    }

    private bool soc_ok(float soc)
    {
      if(soc<20 || soc>80)
      {
        Console.WriteLine("State of Charge is out of range!");
        return false;
      }
      else if (soc<24)
      {
        Console.WriteLine("Warning:Appproaching discharge!");
      }
      else if(soc >76)
      {
        Console.WriteLine("Warning:Approaching charge-peak!");
      }
      return true;
    }

private bool chargerate_ok(float chargerate)
{
  if(chargerate > 0.8)
  {
    Console.WriteLine("Charge rate is out of range!");
    return false;
  }
  else if (chargerate > 0.76f)
  {
    Console.WriteLine("Warning:Approaching charge rate limit!");
  }
  return true;
}
}
}

        
