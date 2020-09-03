using System;

namespace inheritance
{
    public class RV : Vehicle, IGas
    {

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} RV careens past you, hauling all of life's luxuries.");
        }
    }
}