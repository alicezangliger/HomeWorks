
namespace Homework6
{
    public interface ICommand
    {
        int CountTypes(string[] comp);                  //method that counts the number of car companies
        int CountAll(int[] n);                          //method that counts the number of cars
        int AveragePrice(int[] k);                      //method that counts average price of all cars
        double AveragePriceType(string[] t, int[] l);   //method that counts average price of specific car model
        void Exit();                                    //exit method 
    }
}
