using System;

namespace inheritance
{
    public class Jetski : Vehicle, IGas
    {

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Jetski zips by on the open waters!");
        }
    }
}