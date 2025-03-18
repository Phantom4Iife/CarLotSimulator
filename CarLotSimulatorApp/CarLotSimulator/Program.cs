using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot dealership = new CarLot();
            
            Car firstCar = new Car
            {
                Year = 2015,
                Make = "Toyota",
                Model = "Camry",
                EngineNoise = "Vroom",
                HonkNoise = "Beep Beep",
                IsDriveable = true
            };
            
            Car secondCar = new Car(2021, "Ford", "F-150", "Rumble", "Hooonk", true);
            
            Car thirdCar = new Car();
            thirdCar.Year = 2018;
            thirdCar.Make = "Chevrolet";
            thirdCar.Model = "Malibu";
            thirdCar.EngineNoise = "Brrrr";
            thirdCar.HonkNoise = "Toot Toot";
            thirdCar.IsDriveable = true;
            
            dealership.CarInventory.Add(firstCar);
            dealership.CarInventory.Add(secondCar);
            dealership.CarInventory.Add(thirdCar);
            
            Console.WriteLine("Car Engine and Honk Sounds\n");

            firstCar.StartEngine();
            firstCar.HonkHorn();

            secondCar.StartEngine();
            secondCar.HonkHorn();

            thirdCar.StartEngine();
            thirdCar.HonkHorn();

            Console.WriteLine("\nCars in the Dealership\n");
            
            foreach (var car in dealership.CarInventory)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
    
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        
        public Car() { }
        
        public Car(int year, string make, string model, string engineSound, string hornSound, bool driveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineSound;
            HonkNoise = hornSound;
            IsDriveable = driveable;
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
    public class CarLot
    {
        public List<Car> CarInventory { get; set; } = new List<Car>();
    }
}
