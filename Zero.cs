using System;

namespace inheritance
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero sneaks past you but not as sexily as the Telsa...");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Sorry but the Zero cannot turn {direction}");
        }
    }
}