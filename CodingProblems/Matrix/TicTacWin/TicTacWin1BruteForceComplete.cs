using System;

namespace CodingProblems.Matrix.TicTacWin
{
    /// <summary>
    /// Implements HasWon
    /// </summary>
    public static class TicTacWin1BruteForceComplete
    {
        /// <summary>
        /// Determines whether anyone has won the game indicated by board.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns>1 if X has won, -1 if O has won, 0 if no one has won.</returns>
        public static int HasWon(int[,] board)
        {
            // Error checking.

            // Null board.
            if (board == null)
                throw new ArgumentException("Board must be specified.");

            // Non-square board.
            if (board.GetLength(0) != board.GetLength(1))
                throw new ArgumentException("Board must be square.");

            // Board too small.
            if (board.GetLength(0) < 2)
                throw new ArgumentException("Board must have a least 2 rows and 2 columns.");

            // Check rows.
            for (int row = 0; row < board.GetLength(0); row++)
            {
                var res = CheckSum(board, GetRowSum(board, row));
                if (res != 0)
                    return res;
            }

            // Check cols.
            for (int col = 0; col < board.GetLength(1); col++)
            {
                var res = CheckSum(board, GetColSum(board, col));
                if (res != 0)
                    return res;
            }

            // Check first diagonal.
            {
                var res = CheckSum(board, GetDiagonalSum(board, true));
                if (res != 0)
                    return res;
            }

            // Check second diagonal.
            {
                var res = CheckSum(board, GetDiagonalSum(board, false));
                if (res != 0)
                    return res;
            }

            // No winner.
            return 0;
        }

        /// <summary>
        /// Gets the sum for the specified row.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="rowIndex">The row index.</param>
        /// <returns>The sum of the cells in the row.</returns>
        public static int GetRowSum(int[,] board, int rowIndex)
        {
            var sum = 0;
            for (int colIndex = 0; colIndex < board.GetLength(1); colIndex++)
                sum += board[rowIndex, colIndex];
            return sum;
        }

        /// <summary>
        /// Gets the sum for the specified column.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="colIndex">The column index.</param>
        /// <returns>The sum of the cells in the column.</returns>
        public static int GetColSum(int[,] board, int colIndex)
        {
            var sum = 0;
            for (int rowIndex = 0; rowIndex < board.GetLength(0); rowIndex++)
                sum += board[rowIndex, colIndex];
            return sum;
        }

        /// <summary>
        /// Gets the sum for the specified diagonal.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="down">Whether to check the "down" column (L->R) or the "up" (L->R) column</param>
        /// <returns>The sum of the cells in the diagonal.</returns>
        public static int GetDiagonalSum(int[,] board, bool down)
        {
            var sum = 0;
            for (int rowcol = 0; rowcol < board.GetLength(0); rowcol++)
            {
                if (down)
                    sum += board[rowcol, rowcol];
                else
                    sum += board[rowcol, board.GetLength(0) - 1 - rowcol];
            }
            return sum;
        }

        /// <summary>
        /// Checks whether the sum is a winning sum.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="sum">The sum.</param>
        /// <returns>1 if X has won, -1 if O has won.</returns>
        public static int CheckSum(int[,] board, int sum)
        {
            // See if X won.
            if (sum == board.GetLength(0))
                return 1;

            // See if O won.
            if (sum == -board.GetLength(0))
                return -1;

            // No winner.
            return 0;
        }
    }
}
