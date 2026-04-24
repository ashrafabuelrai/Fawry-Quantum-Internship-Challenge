using System;
using System.Collections.Generic;
using System.Text;

namespace Fawry_Quantum_Internship_Challenge
{
    public enum EngineType
    {
        Gasoline,
        Electronic,
        Hybrid
    }

    public class CarFactory
    {
        private static IEngine CreateEngine(EngineType type) => type switch
        {
            EngineType.Gasoline => new GasolineEngine(),
            EngineType.Electronic => new ElectronicEngine(),
            EngineType.Hybrid => new MixedHybridEngine(),
            _ => throw new ArgumentException($"Unknown engine type: {type}")
        };

        public Car CreateCar(EngineType engineType)
        {
            var engine = CreateEngine(engineType);
            return new Car(engine);
        }

        public void ReplaceEngine(Car car, EngineType newEngineType)
        {
            var engine = CreateEngine(newEngineType);
            car.ReplaceEngine(engine);
        }
    }
}
