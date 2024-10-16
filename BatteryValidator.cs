using System;
namespace ParadigmShiftCSharp
{
    class BatteryValidator
    {
        private const float MaxChargeRate = 0.8f;
        public static bool ValidateRange(float value, float min, float max, string param, bool warn)
        {
            if (value < min || value > max)
            {
                Console.WriteLine($"{param} is out of range!");
                return false;
            }
            return CheckProximity(value, min, max, param, warn);
        }

        public static bool ValidateChargeRate(float chargeRate) =>
            chargeRate <= MaxChargeRate || ReportOutOfRange("Charge Rate");

        private static bool CheckProximity(float value, float min, float max, string param, bool warn)
        {
            if (warn)
            {
                WarnIfNearLimits(value, min, max, param);
            }
            return true;
        }

        private static void WarnIfNearLimits(float value, float min, float max, string param)
        {
            if (value > max * 0.95f)
                Console.WriteLine($"{param} is near the maximum limit!");
            if (value < min * 1.05f)
                Console.WriteLine($"{param} is near the minimum limit!");
        }

        private static bool ReportOutOfRange(string param)
        {
            Console.WriteLine($"{param} is out of range!");
            return false;
        }
    }
}
