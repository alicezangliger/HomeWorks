using System;
using System.Collections.Generic;
using System.Text;

namespace CW
{
    public class Engine
    {
        public int power { get; set; }
        public double volume { get; set; }
        public string type { get; set; }
        public int serialNumber { get; set; }

        Engine()
        { }

        public Engine(int p, double v, string t, int sN)
        {
            p = power;
            v = volume;
            t = type;
            sN = serialNumber;
        }
       /* public void GetEngineInformation()
        {
            Console.WriteLine($"Power: {power} \n Volume: {volume} \n Type: {type} \n Serial number: {serialNumber}");
        }*/

    }
}
