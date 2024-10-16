using System;

namespace paradigm_shift_csharp
{
class Check_StatusoOfBattery 
{
   Public const float Minimum_Soc =20f, Maximum_Soc=80f;
   Public const float Minimum_Temp =0f, Maximum_Temp=45f;
   CheckBattery batterylimit = new CheckBattery();
   public void ExpectTrue(bool expression)
   {
       if(!expression)
       {
           Console.WriteLine("Expected true, but got false");
           Environment.Exit(1);
       }
   }
    public void ExpectFalse(bool expression)
    {
        if(expression)
        {
            Console.WriteLine("Expected false,but got true");
            Environment.Exit(1);
        }
    }
    public static bool BatteryIsOk(float temp,float soc,float chargerate)
    {
        return CheckBattery.CheckLimit(temp,Minimum_Temp,Maximum_Temp,"Temperature",true) &&
            CheckBattery.CheckLimit(soc,Minimum_Soc,Maximum_Soc,"SoC",true) &&
            CheckBattery.CheckLimit(chargerate);
}
}






    
