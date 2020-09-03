using System;

namespace inheritance
{
    public class Ram : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
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