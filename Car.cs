using System;

namespace inheritance
{
    public class Car : Vehicle, IGas
    {

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Car drives past you in the most unassuming way possible.");
        }
    }
}