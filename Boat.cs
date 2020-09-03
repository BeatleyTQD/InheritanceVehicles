using System;

namespace inheritance
{
    public class Boat : Vehicle, IGas
    {
        public int CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Boat glides across the water!");
        }
    }
}