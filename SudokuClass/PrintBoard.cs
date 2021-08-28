using System;

namespace SudokuClass
{
    public class PrintBoard
    {
        /* Prints the sudoku board into a console applications.
         * TODO: See if this can be used with winforms to print the array to a window.
         */
        public static void DisplayBoard(char[,] board)
        {
            int arrayIndex = 0;
            string lineSeparator = "";
            string[] printRowArray = new string[board.GetLength(1) + (board.GetLength(1) / 3) + 1];

            for (int i = 0; i < ((board.GetLength(0) * 2) + (board.GetLength(0) / 3)); i++)
            {
                lineSeparator += "+";
            }

            for (int x = 0; x < board.GetLength(0); x++)
            {
                string printRow = "";
                
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    if (y % 3 == 0)
                    {
                        printRow += "|" + board[x, y].ToString() + " ";
                    }
                    else if (y == board.GetLength(1) - 1)
                    {
                        printRow += board[x, y].ToString() + "|" + " ";
                    }
                    else
                    {
                        printRow += board[x, y].ToString() + " ";
                    }
                }

                //string lineSeparator = SetSeparatorLength(printRow);

                if (x % 3 == 0)
                {
                    printRowArray[arrayIndex] = lineSeparator;
                    arrayIndex++;
                }

                printRowArray[arrayIndex] = printRow;
                arrayIndex++;

                if (arrayIndex > board.GetLength(0))
                {
                    printRowArray[arrayIndex] = lineSeparator;
                }
            }

            for (int i = 0; i < printRowArray.Length; i++)
            {
                Console.WriteLine(printRowArray[i]);
            }
        }
    }
}
