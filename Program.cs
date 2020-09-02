using System;

namespace inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {

            Cessna plane = new Cessna()
            {
                MainColor = "purple",
                MaximumOccupancy = "20",
                FuelCapacity = 20.5
            };

            Ram truck = new Ram()
            {
                MainColor = "black",
                MaximumOccupancy = "6",
                FuelCapacity = 10.5
            };

            Zero bike = new Zero()
            {
                MainColor = "white",
                MaximumOccupancy = "2",
                BatteryKWh = 2.5
            };

            Tesla car = new Tesla()
            {
                MainColor = "red",
                MaximumOccupancy = "5",
                BatteryKWh = 52.5
            };
        }
    }
}