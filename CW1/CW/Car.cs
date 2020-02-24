using System;
using System.Collections.Generic;
using System.Text;

namespace CW
{
    public class Car
    {
        Engine engine;
        Chassis chassis;
        Transmission transmission;
        int numberOfDoors;

        Car()
        { }

        public Car(Engine e, Chassis ch, Transmission t, int nD)
        {
            e = engine;
            ch = chassis;
            t = transmission;
            nD = numberOfDoors;
        }

        /*public void GetCarInformation()
        {
            Console.WriteLine($"Engine: {engine} \n Chassis: {chassis} \n Transmission: {transmission} \n Number of doors: {numberOfDoors}");
        }*/
    }
}
