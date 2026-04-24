using System;
using System.Collections.Generic;
using System.Text;

namespace Fawry_Quantum_Internship_Challenge
{
    public interface IEngine
    {
        void Increase();
        void Decrease();
        void OnSpeedChanged(int carSpeed);
        int Speed { get; }
        string EngineType { get; }
    }
}
