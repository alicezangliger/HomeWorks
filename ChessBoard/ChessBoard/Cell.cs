using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    class Cell
    {
        protected char collumn;
        protected int row;
        public Cell(char collumn, int row)
        {

            if ((collumn < 65 || collumn > 104) || (collumn < 97 && collumn > 72) || (row < 1 || row > 8))
            {
                throw new Exception("Incorrect direction,please try again");
            }
            else
            {
                this.collumn = collumn;
                this.row = row;
            }           

        }
        public char GetCollumn()
        {
            return collumn;
        }
        public int GetRow()
        {
            return row;
        }

        int collumnToInt()
        {
            if(collumn>=65 && collumn<=72)
            {
                return collumn - 64;
            }
            else
            {
                return collumn - 96;
            }
        }

        public bool isBlack()
        {
            int collumnInt = collumnToInt();
            int sum = collumnInt + row;
            if (sum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isWhite()
        {
            return !isBlack();
        }

       public bool vertically(Cell cell)
        {
            int collmnInt = collumnToInt();
            cell.collumnToInt();
            if (collmnInt == cell.collumnToInt())
            {
                return true;
            }
            return false;
        }
        public bool horizontally(Cell cell)
        {            
            if (row == cell.row)
            {
                return true;
            }
            return false;
        }
        public bool diagonally(Cell cell)
        {
            int colInt = collumnToInt();
            if (Math.Abs(colInt - cell.collumnToInt()) == Math.Abs(row - cell.row))
            {
                return true;
            }
            return false;
        }

    }
}
