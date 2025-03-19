using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> CarInventory { get; set; } = new List<Car>();
        public static int NumberOfCars { get; private set; } = 0;

        public CarLot()
        {
            Console.WriteLine("Car lot initialized.");
        }

        public static void IncrementCarCount()
        {
            NumberOfCars++;
            Console.WriteLine($"Current number of cars in the lot: {NumberOfCars}");
        }
    }
}