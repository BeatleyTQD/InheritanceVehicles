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
    }
}