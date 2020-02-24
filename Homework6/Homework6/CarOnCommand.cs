
namespace Homework6
{
    public class CarOnCommand : ICommand
    {
        Car car;
        public CarOnCommand(Car car)
        {
            this.car = car;
        }        

        public int CountTypes(string[] companies)
        {
            return car.CompaniesCount(companies);
        }
        public int CountAll(int[] number)
        {
            return car.CarsCount(number);
        }
        public int AveragePrice(int[] price)
        {
            return car.CarsPrice(price);
        }
        public double AveragePriceType(string[] model, int[] price)
        {
            return car.ModelsPrice(model, price);
        }
        public void Exit()
        {
            car.Off();
        }
    }
}
