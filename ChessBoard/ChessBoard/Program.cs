using System;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Cell cell1 = Helper.GetCell();
                Console.WriteLine("First cell: {0}{1}",cell1.GetCollumn(),cell1.GetRow());
                Console.WriteLine("Color is black?: {0}", cell1.isBlack());
                Console.WriteLine("Color is white?: {0}", cell1.isWhite());
                Console.WriteLine("********************");
                Cell cell2 = Helper.GetCell();
                Console.WriteLine("Second cell: {0}{1}", cell2.GetCollumn(), cell2.GetRow());
                Console.WriteLine("Color is black?: {0}", cell2.isBlack());
                Console.WriteLine("Color is white?: {0}", cell2.isWhite());
                Console.WriteLine("********************");
                Console.WriteLine("They are vertical?: {0}", cell1.vertically(cell2));
                Console.WriteLine("They are horizontal?: {0}", cell1.horizontally(cell2));
                Console.WriteLine("They are diagonal?: {0}", cell1.diagonally(cell2));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
