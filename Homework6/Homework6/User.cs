
namespace Homework6
{
    public class User          //invoker
    {
        ICommand command;
        public User()
        {

        }
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public int GetCountTypes(string[] comp)
        {
            return command.CountTypes(comp);
        }
        public int GetCountAll(int[] num)
        {
            return command.CountAll(num);
        }
        public int GetAveragePrice(int[] pri)
        {
            return command.AveragePrice(pri);
        }
        public double GetAveragePriceType(string[] mod, int[] pri)
        {
            return command.AveragePriceType(mod, pri);
        }
        public void Leave()
        {
            command.Exit();
        }
    }
}
