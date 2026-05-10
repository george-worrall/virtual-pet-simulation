using System.Diagnostics.Metrics;
using System.Threading;
using VirtualPetSimulation.System;


namespace VirtualPetSimulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Simulation sim = new Simulation();
            sim.Start();
        }
    }

}

