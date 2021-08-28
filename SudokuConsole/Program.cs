using System;
using SudokuClass;

namespace SudokuConsole
{
    class Program
    {
        /* Allows the user to interface with the sudoku solver.
         * TODO: Add way for user to input custom board.
         * TODO: Add way to parse board from file.
         * TODO: Add method that creates a random board that is solvable for the user to try.
         * TODO: Replace with winforms.
         */
        static void Main(string[] args)
        {
            char[,] sudoku = new char[,]
            {
                { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            Console.WriteLine("Original Board:");
            PrintBoard.DisplayBoard(sudoku);

            Console.WriteLine();
            SolveSudoku.SolveGame(sudoku);

            Console.WriteLine("Solved Board:");
            PrintBoard.DisplayBoard(sudoku);
            Console.ReadLine();
        }
    }
}
