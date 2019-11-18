using System;

namespace ChessBoard
{
    class Cell
    {
        public char column { get; set; }
        public int row { get; set; }
        public Cell(char column, int row)
        {

            if ((column < 65 || column > 104) || (column < 97 && column > 72) || (row < 1 || row > 8))
            {
                throw new Exception("Incorrect direction,please try again");
            }
            else
            {
                this.column = column;
                this.row = row;
            }           

        } 

        int columnToInt()
        {
            if(column>=65 && column<=72)
            {
                return column - 64;
            }
            else
            {
                return column - 96;
            }
        }

        public bool IsBlack()
        {
            int columnInt = columnToInt();
            int sum = columnInt + row;
            return sum % 2 == 0;
        }

        public bool IsWhite()
        {
            return !IsBlack();
        }

       public bool Vertically(Cell cell)
        {
            int colmnInt = columnToInt();
            cell.columnToInt();
            return colmnInt == cell.columnToInt();
        }
        public bool Horizontally(Cell cell)
        {
            return row == cell.row;
        }
        public bool Diagonally(Cell cell)
        {
            int colInt = columnToInt();
            return Math.Abs(colInt - cell.columnToInt()) == Math.Abs(row - cell.row);
        }

    }
}
