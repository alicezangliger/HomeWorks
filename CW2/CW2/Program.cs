

using System;

namespace CW2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.AddHead(6);
            myList.AddHead(3);
            myList.AddHead(10);
            myList.AddTail(1);
            myList.AddTail(7);

            foreach (var element in myList)
            {
                Console.WriteLine(element.ToString());

            }            
            
        }
    }
}
