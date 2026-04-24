using System;
using System.Collections.Generic;
using System.Text;

namespace Fawry_Quantum_Internship_Challenge
{
    using System;

    public class ElectronicEngine : IEngine
    {
        public int Speed { get; private set; }
        public string EngineType => "Electronic";

        public void Increase()
        {
            Speed++;
            Console.WriteLine($"[{EngineType}] Speed increased to {Speed} km/h");
        }

        public void Decrease()
        {
            if (Speed > 0) Speed--;
            Console.WriteLine($"[{EngineType}] Speed decreased to {Speed} km/h");
        }

        public void OnSpeedChanged(int carSpeed)
        {
            Console.WriteLine($"[{EngineType}] Advised of car speed: {carSpeed} km/h");
            Speed = carSpeed;
        }
    }
}
