using System;

namespace inheritance
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram roars past you like a total asshole! rrrrrrRRRR!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram stops after 5000 meters.");
        }
    }
}