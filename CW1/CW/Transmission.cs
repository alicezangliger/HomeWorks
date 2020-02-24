using System;
using System.Collections.Generic;
using System.Text;

namespace CW
{
    public class Transmission
    {
        public string type { get; set; }
        public int numberOfGears { get; set; }
        public string manufacturer { get; set; }

        Transmission()
        { }

        public Transmission(string t, int nG, string m)
        {
            t = type;
            nG = numberOfGears;
            m = manufacturer;
        }
    }
}
