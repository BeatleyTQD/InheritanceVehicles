using System;

namespace inheritance
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna soars over head, zoooooom!");
        }
    }
}