using System;

namespace ChessBoard
{
    class Helper
    {
        public static Cell GetCell()
        {
            Console.WriteLine("Input cell letter");
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input cell number");
            int b = Convert.ToInt32(Console.ReadLine());
            return new Cell(a, b);            
        }
    }
}
