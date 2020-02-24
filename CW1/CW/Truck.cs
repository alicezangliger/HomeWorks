using System;
using System.Collections.Generic;
using System.Text;

namespace CW
{
    public class Truck
    {
        Engine engine;
        Chassis chassis;
        Transmission transmission;
        int maxWeight;

        Truck()
        { }

        public Truck(Engine e, Chassis ch, Transmission t, int mW)
        {
            e = engine;
            ch = chassis;
            t = transmission;
            mW = maxWeight;
        }
    }
}
