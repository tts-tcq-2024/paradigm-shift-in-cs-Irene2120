using System;
namespace ParadigmShiftCSharp
{
    class BatteryChecks
    {
        private const float ChargeRateMax = 0.8f;

        public static bool LimitCheck(float input, float minValue, float maxValue, string parameter, bool validate)
        {
            bool isValid = ValidateRange(input, minValue, maxValue, parameter, validate);
            return isValid;
        }

        public static bool ChargeRateCheck(float chargeRate)
        {
            return ValidateChargeRate(chargeRate);
        }

        rivate static bool ValidateRange(float value, float minValue, float maxValue, string parameter, bool validate)
{
    if (value < minValue || value > maxValue)
    {
        Console.WriteLine($"{parameter} is out of range!");
        return false;
    }

    if (validate)
    {
        CheckNearLimits(value, minValue, maxValue, parameter);
    }

    return true;
}

private static void CheckNearLimits(float value, float minValue, float maxValue, string parameter)
{
    if (IsNearMinimum(value, minValue))
    {
        Console.WriteLine($"{parameter} is near the minimum range!");
    }
    else if (IsNearMaximum(value, maxValue))
    {
        Console.WriteLine($"{parameter} is near the maximum range!");
    }
}

private static bool IsNearMinimum(float value, float minValue) =>
    value > minValue && value < minValue + (minValue * 0.05f);

private static bool IsNearMaximum(float value, float maxValue) =>
    value < maxValue && value > (maxValue - (maxValue * 0.05f));

        private static bool ValidateChargeRate(float chargeRate)
        {
            if (chargeRate > ChargeRateMax)
            {
                Console.WriteLine("Charge Rate is out of range!");
                return false;
            }
            if (chargeRate > (ChargeRateMax - (ChargeRateMax * 0.05f)))
            {
                Console.WriteLine("Charge Rate is near the maximum range!");
            }
            return true;
        }
    }
}
