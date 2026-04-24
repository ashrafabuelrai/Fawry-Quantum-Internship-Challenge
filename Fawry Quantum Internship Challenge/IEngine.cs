using System;
using System.Collections.Generic;
using System.Text;

namespace Fawry_Quantum_Internship_Challenge
{
    /// <summary>
    /// Engine interface - defines the contract for all engine types.
    /// Each engine tracks its own internal speed and can be advised on current car speed.
    /// </summary>
    public interface IEngine
    {
        void Increase();
        void Decrease();
        void OnSpeedChanged(int carSpeed);
        int Speed { get; }
        string EngineType { get; }
    }
}
