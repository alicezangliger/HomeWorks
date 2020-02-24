using System;
using System.Collections.Generic;
using System.Text;

namespace CW
{
    public class Bus
    {
        Engine engine;
        Chassis chassis;
        Transmission transmission;
        int numberOfPassengers;

        Bus()
        { }

        public Bus(Engine e, Chassis ch, Transmission t, int nP)
        {
            e = engine;
            ch = chassis;
            t = transmission;
            nP = numberOfPassengers;
        }
    }
}
