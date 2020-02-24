using System;
using System.Collections.Generic;
using System.Text;

namespace CW
{
    public class Chassis
    {
        public int numberOfWheels { get; set; }
        public int serialNumber { get; set; }
        public int bearingCapacity { get; set; }

        Chassis()
        { }

        public Chassis(int nW, int sN, int bC)
        {
            nW = numberOfWheels;
            sN = serialNumber;
            bC = bearingCapacity;
        }
    }
}
