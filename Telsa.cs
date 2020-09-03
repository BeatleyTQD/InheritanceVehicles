using System;

namespace inheritance
{
    public class Tesla : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The silent {MainColor} Tesla sneaks past you...!");
        }
    }
}