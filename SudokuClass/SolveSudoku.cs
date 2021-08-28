namespace SudokuClass
{
    public class SolveSudoku
    {
        /* To win sudoku, 3 things must be true:
         * 1. Each of the digits from 1-9 must occur exactly once in each row.
         * 2. Each of the digits from 1-9 must occur exactly once in each column.
         * 3. Each of the digits from 1-9 must occur exactly once in each of the 3x3 boxes in the grid.
         */

        private static bool IsValid(char[,] board, int row, int col, char c)
        {
            for (int i = 0; i < 9; i++)
            {
                // Check row
                if (board[i, col] != '.' && board[i, col] == c)
                {
                    return false;
                }
                // Check column
                if (board[row, i] != '.' && board[row, i] == c)
                {
                    return false;
                }
                // Check 3x3 block
                if (board[(3 * (row / 3) + i / 3), (3 * (col / 3) + i % 3)] != '.' && board[(3 * (row / 3) + i / 3), (3 * (col / 3) + i % 3)] == c)
                {
                    return false;
                }
            }
            return true;
        }
        
        private static bool Solve(char[,] board)
        {
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    if (board[x, y] == '.') // Check for empty square
                    {
                        for (char c = '1'; c <= '9'; c++)
                        {
                            if (IsValid(board, x, y, c))
                            {
                                board[x, y] = c;

                                if (Solve(board))
                                {
                                    return true;
                                }
                                else
                                {
                                    board[x, y] = '.';
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        public static void SolveGame(char[,] board)
        {
            if (board == null || board.Length == 0)
            {
                return;
            }
            Solve(board);
        }
    }
}
