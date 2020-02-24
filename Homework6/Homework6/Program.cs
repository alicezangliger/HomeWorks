using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carCompanies = new string[5];
            Console.WriteLine("Input your car companies: ");
            Console.Write("1) "); carCompanies[0] = Convert.ToString(Console.ReadLine());
            Console.Write("2) "); carCompanies[1] = Convert.ToString(Console.ReadLine());
            Console.Write("3) "); carCompanies[2] = Convert.ToString(Console.ReadLine());
            Console.Write("4) "); carCompanies[3] = Convert.ToString(Console.ReadLine());
            Console.Write("5) "); carCompanies[4] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input your cars models: ");
            string[] carModels = new string[5];
            Console.Write("1) "); carModels[0] = Convert.ToString(Console.ReadLine());
            Console.Write("2) "); carModels[1] = Convert.ToString(Console.ReadLine());
            Console.Write("3) "); carModels[2] = Convert.ToString(Console.ReadLine());
            Console.Write("4) "); carModels[3] = Convert.ToString(Console.ReadLine());
            Console.Write("5) "); carModels[4] = Convert.ToString(Console.ReadLine());
            int[] numberOfCars = new int[5];
            Console.WriteLine("Input number of cars : ");
            Console.Write("1) "); numberOfCars[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("2) "); numberOfCars[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("3) "); numberOfCars[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("4) "); numberOfCars[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("5) "); numberOfCars[4] = Convert.ToInt32(Console.ReadLine());
            int[] carCost = new int[5];
            Console.WriteLine("Input cars cost: ");
            Console.Write("1) "); carCost[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("2) "); carCost[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("3) "); carCost[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("4) "); carCost[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("5) "); carCost[4] = Convert.ToInt32(Console.ReadLine());

            User user = new User();
            Car car = new Car();
            user.SetCommand(new CarOnCommand(car));
            int countTypes = user.GetCountTypes(carCompanies);
            Console.WriteLine("Number of car companies: {0}",countTypes);
            int countAll = user.GetCountAll(numberOfCars);
            Console.WriteLine("Number of cars: {0}", countAll);
            int averageAll = user.GetAveragePrice(carCost);
            Console.WriteLine("Average price of all cars: {0}", averageAll);
            double averageTypes = user.GetAveragePriceType(carModels,carCost);
            Console.WriteLine("Average price of cars models: {0}", averageTypes);
            user.Leave();
        }
    }
}
