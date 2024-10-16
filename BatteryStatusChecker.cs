using System;
namespace ParadigmShiftCSharp
{
    class BatteryStatusChecker
    {
        private const float MinSoC = 20f;
        private const float MaxSoC = 80f;
        private const float MinTemp = 0f;
        private const float MaxTemp = 45f;

        public void AssertTrue(bool condition)
        {
            if (!condition) ReportFailure("true");
        }

        public void AssertFalse(bool condition)
        {
            if (condition) ReportFailure("false");
        }

        public static bool IsBatteryHealthy(float temperature, float soc, float chargeRate) =>
            BatteryValidator.ValidateRange(temperature, MinTemp, MaxTemp, "Temperature", true) &&
            BatteryValidator.ValidateRange(soc, MinSoC, MaxSoC, "SoC", true) &&
            BatteryValidator.ValidateChargeRate(chargeRate);

        private void ReportFailure(string expected)
        {
            Console.WriteLine($"Expected {expected}, but validation failed");
            Environment.Exit(1);
        }
    }
}
