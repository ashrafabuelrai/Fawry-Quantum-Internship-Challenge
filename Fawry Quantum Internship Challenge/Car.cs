using System;
using System.Collections.Generic;
using System.Text;

namespace Fawry_Quantum_Internship_Challenge
{
    using System;

    public class Car
    {
        private IEngine _engine;
        public int Speed { get; private set; }

        private const int MaxSpeed = 200;
        private const int SpeedStep = 20;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void ReplaceEngine(IEngine newEngine)
        {
            Console.WriteLine($"\n[Car] Replacing {_engine.EngineType} engine with {newEngine.EngineType} engine.");
            _engine = newEngine;
        }

        public void Start()
        {
            Speed = 0;
            _engine.OnSpeedChanged(Speed);
            Console.WriteLine("[Car] Engine started at 0 km/h.\n");
        }

        public void Stop()
        {
            if (Speed != 0)
            {
                Console.WriteLine("[Car] Cannot stop: speed must be 0 first. Apply brakes.");
                return;
            }
            Console.WriteLine("[Car] Engine stopped.\n");
        }

        public void Accelerate()
        {
            if (Speed >= MaxSpeed)
            {
                Console.WriteLine($"[Car] Already at max speed ({MaxSpeed} km/h).");
                return;
            }
            Speed = Math.Min(Speed + SpeedStep, MaxSpeed);
            _engine.OnSpeedChanged(Speed);
            Console.WriteLine($"[Car] Accelerated to {Speed} km/h.\n");
        }

        public void Brake()
        {
            if (Speed <= 0)
            {
                Console.WriteLine("[Car] Already at 0 km/h.");
                return;
            }
            Speed = Math.Max(Speed - SpeedStep, 0);
            _engine.OnSpeedChanged(Speed);
            Console.WriteLine($"[Car] Braked to {Speed} km/h.\n");
        }
    }
}
