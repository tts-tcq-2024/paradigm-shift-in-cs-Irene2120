using System;

namespace paradigm_shift_csharp
{
class Checker
{
    static bool batteryIsOk(float temp, float soc, float charge_rate) 
    {
        return Temp_ok(temp)&& soc_ok(soc)&& charge_rate_ok(charge_rate);
    }
    static bool Temp_ok(float temp)
    {
     if(temp < 0 || temp > 45) 
      {
        Console.WriteLine("Temperature is out of range!");
        return false;
       } 
        return true;
     }
    
    static bool soc_ok(float soc)
    {  
     if(soc < 20 || soc > 80) 
     {
       Console.WriteLine("State of Charge is out of range!");
       return false;
      } 
       return true;     
      }
    
    static bool charge_rate_ok(float charge_rate)
    {
     if(charge_rate > 0.8) 
      {
        Console.WriteLine("Charge Rate is out of range!");
        return false;
       }
        return true;
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
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() 
    {
        ExpectTrue(batteryIsOk(25, 70, 0.7f));   //values within range
        ExpectFalse(batteryIsOk(50, 85, 0.0f));  //values not within range
        Console.WriteLine("All ok");
        return 0;
    }
    
}
}
