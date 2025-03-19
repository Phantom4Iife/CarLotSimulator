using System;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car()
        {
            CarLot.IncrementCarCount();
        }

        public Car(int year, string make, string model, string engineSound, string hornSound, bool driveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineSound;
            HonkNoise = hornSound;
            IsDriveable = driveable;
            CarLot.IncrementCarCount();
        }

        public void StartEngine()
        {
            Console.WriteLine($"{Make} {Model} engine sound: {EngineNoise}");
        }

        public void HonkHorn()
        {
            Console.WriteLine($"{Make} {Model} honks: {HonkNoise}");
        }
    }
}