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

    static bool batteryIsOk(float temp, float soc, float chargerate)
    {
        bool isTempOk = Temp_ok(temp);
        bool isSocOk = soc_ok(soc);
        bool isChargeRateOk= chargerate_ok(chargerate);

        return isTempOk && isSocOk && isChargeRateOk;
    }

    static bool Temp_ok(float temp)
    {
        if(temp<0 || temp>45)
        {
            Console.Writeline("Temperature is out of range!");
            return false;
        }
        else if (temp>40)
        {
            Console.Writeline("Warning: Approaching temperature limit!");
        }
        return true;
    }
    static bool soc_ok(float soc)
    {
        if(soc<20 || soc>80)
        {
            Console.Writeline("State of Charge is out of range!");
            return false;
        }
        else if (soc<24)
        {
            Console.Writeline("Warning: Approaching charge-peak!");
        }
        return true;
    }


    static bool chargerate_ok(float chargerate)
    {
        if(chargerate>0.8)
        {
            Console.Writeline("Charge Rate is out of range!");
            return false;
        }
        else if (chargerate>0076f)
        {
            Console.Writeline("Warning: Approaching Charge rate limit!");
        }
        return true;
    }

    static void ExpectFalse(bool expression)
    {
        if(expression)
        {
            Console.Writeline("Expected false,but got true");
            Environment.Exit(1);
        }
    }
static void ExpectTrue(bool expression)
    {
        if(expression)
        {
            Console.Writeline("Expected true,but got false");
            Environment.Exit(1);
        }
    }

static int Main()
{
    ExpectTrue(batteryIsOk(25,70,0.7f));
    ExpectFalse(batteryIsOk(50,85,0.0f));
    Console.Writeline("All ok");
    return 0;
}
    class WarningConfig
    {

        public float TempWarningThreshold{get;set;}
        public float SoCWarningThreshold{get;set;}
        public float ChargeRateWarningThreshold{get;set;}
    }

}
}






    
