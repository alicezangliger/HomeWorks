using System;

namespace Homework2
{
    public class Program
    {
        static void Main(string[] args)
        
        {
                string line;
                Console.WriteLine("Input your line: ");
                line = Convert.ToString(Console.ReadLine());    //input line for further processing
                int maxElem = SymbolString.DifferentElem(line);        //max number of different elements
                int maxNumb = SymbolString.EqualNumbers(line);         //max number of repeating numbers
                int maxLat = SymbolString.EqualLatin(line);            //max number of repeating latin letters
                Console.WriteLine("Max number of different symbols are: {0}",maxElem);
                Console.WriteLine("Max number of repeating numbers are: {0}",maxNumb);
                Console.WriteLine("Max number of repeating latin letters are: {0}", maxLat);

        }
        
    }
}
