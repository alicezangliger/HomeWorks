using System;
using System.Collections.Generic;
using System.Text;

namespace CW
{
    public class Scooter
    {
        Engine engine;
        Chassis chassis;
        Transmission transmission;
        int numberOfHelmets;

        Scooter()
        { }

        public Scooter(Engine e, Chassis ch, Transmission t, int nH)
        {
            e = engine;
            ch = chassis;
            t = transmission;
            nH = numberOfHelmets;
        }
    }
}
