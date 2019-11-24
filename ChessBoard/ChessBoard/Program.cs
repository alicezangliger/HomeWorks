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
                Console.WriteLine("First cell: {0}{1}",cell1.column,cell1.row);
                Console.WriteLine("Color is black?: {0}", cell1.IsBlack());
                Console.WriteLine("Color is white?: {0}", cell1.IsWhite());
                Console.WriteLine("********************");
                Cell cell2 = Helper.GetCell();
                Console.WriteLine("Second cell: {0}{1}", cell2.column, cell2.row);
                Console.WriteLine("Color is black?: {0}", cell2.IsBlack());
                Console.WriteLine("Color is white?: {0}", cell2.IsWhite());
                Console.WriteLine("********************");
                Console.WriteLine("They are vertical?: {0}", cell1.Vertically(cell2));
                Console.WriteLine("They are horizontal?: {0}", cell1.Horizontally(cell2));
                Console.WriteLine("They are diagonal?: {0}", cell1.Diagonally(cell2));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
