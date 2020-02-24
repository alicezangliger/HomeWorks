using System;

namespace CW
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engineC = new Engine(200, 2.5, "A", 3);
            Chassis chassisC = new Chassis(4, 5, 100);
            Transmission transmissionC = new Transmission("B", 6, "Renault");
            Engine engineB = new Engine(300, 5, "K", 2);
            Chassis chassisB = new Chassis(4, 6, 200);
            Transmission transmissionB = new Transmission("A", 6, "Mercedes");
            Engine engineT = new Engine(250, 7, "C", 4);
            Chassis chassisT = new Chassis(4, 4, 150);
            Transmission transmissionT = new Transmission("B", 5, "MAZ");
            Engine engineS = new Engine(100, 1.4, "E", 1);
            Chassis chassisS = new Chassis(2, 1, 70);
            Transmission transmissionS = new Transmission("M", 4, "KIA");
            Car car = new Car(engineC, chassisC, transmissionC, 4);
            Bus bus = new Bus(engineB, chassisB, transmissionB, 50);
            Truck truck = new Truck(engineT, chassisT, transmissionT, 150);
            Scooter scooter = new Scooter(engineS, chassisS, transmissionS, 1);

            //car.GetCarInformation();
             //1
             /* if (engineC.volume > 1.5)
              {
                  Console.WriteLine("Engine: power-{0}, volume-{1}, type-{2}, seria-{3}", engineC, "\n",
                   "Chassis: wheels-{0}, number-{1}, capacity-{2}", chassisC, "\n",
                   "Transmission: type-{0}, gears-{1}, company-{2}", transmissionC);
              }
              if (engineB.volume > 1.5)
              {
                  Console.WriteLine("Engine: power-{0}, volume-{1}, type-{2}, seria-{3}", engineB.power, engineB.volume, engineB.type, engineB.serialNumber, "\n",
                   "Chassis: wheels-{0}, number-{1}, capacity-{2}", chassisB.numberOfWheels, chassisB.serialNumber, chassisB.bearingCapacity, "\n",
                   "Transmission: type-{0}, gears-{1}, company-{2}", transmissionB.type, transmissionB.numberOfGears, transmissionB.manufacturer);
              }
              if (engineT.volume > 1.5)
              {
                  Console.WriteLine("Engine: power-{0}, volume-{1}, type-{2}, seria-{3}", engineT, "\n",
                   "Chassis: wheels-{0}, number-{1}, capacity-{2}", chassisT, "\n",
                   "Transmission: type-{0}, gears-{1}, company-{2}", transmissionT);
              }
              if (engineS.volume > 1.5)
              {
                  Console.WriteLine("Engine: power-{0}, volume-{1}, type-{2}, seria-{3}", engineS, "\n",
                   "Chassis: wheels-{0}, number-{1}, capacity-{2}", chassisS, "\n",
                   "Transmission: type-{0}, gears-{1}, company-{2}", transmissionS);
              }
              */
            //2
           // Console.WriteLine("Full information about buses engine: power-{0}, volume-{1}, type-{2}, seria-{3}", engineB.power, engineB.volume, engineB.type, engineB.serialNumber);
            //Console.WriteLine("Full information about trucks engine: power-{0}, volume-{1}, type-{2}, seria-{3}", engineT.power, engineT.volume, engineT.type, engineT.serialNumber);
        }
    }
}
