using System;
using System.Collections.Generic;
using System.Text;

namespace Fawry_Quantum_Internship_Challenge
{
    using System;

    /// <summary>
    /// Hybrid engine: uses Electric below 50 km/h, Gas at 50+ km/h.
    /// Cost-optimized — never runs both engines simultaneously.
    /// </summary>
    public class MixedHybridEngine : IEngine
    {
        private readonly GasolineEngine _gasolineEngine = new GasolineEngine();
        private readonly ElectronicEngine _electronicEngine = new ElectronicEngine();

        private IEngine ActiveEngine(int speed) =>
            speed < 50 ? (IEngine)_electronicEngine : _gasolineEngine;

        public int Speed { get; private set; }
        public string EngineType => "MixedHybrid";

        public void Increase()
        {
            Speed++;
            ActiveEngine(Speed).Increase();
            Console.WriteLine($"[{EngineType}] Using {ActiveEngine(Speed).EngineType} engine at {Speed} km/h");
        }

        public void Decrease()
        {
            if (Speed > 0) Speed--;
            ActiveEngine(Speed).Decrease();
            Console.WriteLine($"[{EngineType}] Using {ActiveEngine(Speed).EngineType} engine at {Speed} km/h");
        }

        public void OnSpeedChanged(int carSpeed)
        {
            Speed = carSpeed;
            var active = ActiveEngine(carSpeed);
            active.OnSpeedChanged(carSpeed);
            Console.WriteLine($"[{EngineType}] Delegating to {active.EngineType} engine (car speed: {carSpeed} km/h)");
        }
    }
}
