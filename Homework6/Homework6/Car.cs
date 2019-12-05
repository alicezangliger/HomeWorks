using System;

namespace Homework6
{
    public class Car                   //receiver
    {
        public int CompaniesCount(string[] companies)
        {
            int count = 1;
            for (int i = 0; i < companies.Length-1; i++)
            {
                if (companies[i] != companies[i+1])
                {
                    count++;
                }
            }
            return count;
        }

        public int CarsCount(int[] number)
        {
            int sum = 0;
            for (int i=0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum;
        }
        
        public int CarsPrice(int[] price)
        {
            int sum = 0;
            for (int i= 0; i < price.Length; i++)
            {
                    sum += price[i];
            }
            return sum / (price.Length);

        }

        public double ModelsPrice(string[] model, int[] price)
        {
            int sum = 0;
            for (int j = 0; j < model.Length-1; j++)
            {
                if (model[j] == model[j+1])
                {
                    for (int i = 0; i < price.Length; i++)
                    {
                            sum += price[i];                         
                    }
                }
            }
            return sum/(price.Length);
        }
        public void Off()
        {
            Environment.Exit(0);
        }
    }
}
