using Fawry_Quantum_Internship_Challenge;
using System;

class Program
{
    static void Main(string[] args)
    {
        var factory = new CarFactory();

        
        // 1. Gasoline Car
        Console.WriteLine("========== GASOLINE CAR ==========");
        Car gasCar = factory.CreateCar(EngineType.Gasoline);
        gasCar.Start();
        gasCar.Accelerate();
        gasCar.Accelerate();
        gasCar.Brake();
        gasCar.Brake();
        gasCar.Stop();

        
        // 2. Electric Car
       
        Console.WriteLine("\n========== ELECTRONIC CAR ==========");
        Car electricCar = factory.CreateCar(EngineType.Electronic);
        electricCar.Start();
        electricCar.Accelerate();
        electricCar.Accelerate();
        electricCar.Accelerate();
        electricCar.Brake();
        electricCar.Brake();
        electricCar.Brake();
        electricCar.Stop();

        
        // 3. Hybrid Car (shows engine switching)
       
        Console.WriteLine("\n========== HYBRID CAR ==========");
        Car hybridCar = factory.CreateCar(EngineType.Hybrid);
        hybridCar.Start();
        // Should use Electronic engine (speed < 50)
        hybridCar.Accelerate(); // 20
        hybridCar.Accelerate(); // 40
        hybridCar.Accelerate(); // 60  → switches to Gasoline
        hybridCar.Accelerate(); // 80
        // Brake back below 50 → switches back to Electronic
        hybridCar.Brake();      // 60
        hybridCar.Brake();      // 40
        hybridCar.Brake();      // 20
        hybridCar.Brake();      // 0
        hybridCar.Stop();

       
        // 4. Engine Replacement Demo
       
        Console.WriteLine("\n========== ENGINE REPLACEMENT ==========");
        Car car = factory.CreateCar(EngineType.Gasoline);
        car.Start();
        car.Accelerate(); // 20
        Console.WriteLine("\n>> Replacing Gasoline engine with Hybrid engine...");
        factory.ReplaceEngine(car, EngineType.Hybrid);
        car.Accelerate(); // 40
        car.Accelerate(); // 60 → Hybrid switches to Gas internally
        car.Brake();
        car.Brake();
        car.Brake();
        car.Stop();

        
        // 5. Edge cases
        
        Console.WriteLine("\n========== EDGE CASES ==========");
        Car edgeCar = factory.CreateCar(EngineType.Electronic);
        edgeCar.Start();
        edgeCar.Brake();          // Already at 0
        edgeCar.Stop();           // OK — speed is 0
        edgeCar.Start();
        edgeCar.Accelerate();
        edgeCar.Stop();           // Should warn: speed not 0
    }
}