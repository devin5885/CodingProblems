using System;
using System.Linq;

namespace CodingProblems.String_.Palindrome.GetMakePalindromeStepCount
{
    /// <summary>
    /// Implements GetMakePalindromeStepCount
    /// </summary>
    public static class GetMakePalindromeStepCount1StandardComplete
    {
        /// <summary>
        /// Determines the minimum number of steps (edit, delete, add) to get
        /// the palindrome.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The minimum number of steps.</returns>
        public static int GetMakePalindromeStepCount(string input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException();

            // Strategy: Find the minimum edit distance between the string and
            // it's reverse then divide that distance by 2.
            var inputReversed = string.Concat(input.Reverse());
            return GetMinimumEditDistance(input, inputReversed) / 2;
        }

        /// <summary>
        /// Use dynamic programming to get edit distance.
        /// </summary>
        /// <param name="start">The start string.</param>
        /// <param name="end">The end string.</param>
        /// <returns>The minimum number of steps to get from start to
        /// end.</returns>
        private static int GetMinimumEditDistance(string start, string end)
        {
            // Error handling.
            if (start == null || end == null)
                throw new ArgumentException();

            // Initialize matrix.
            var matrix = new int[start.Length + 1, end.Length + 1];

            // Populate first row.
            for (int i = 0; i < end.Length + 1; i++)
                matrix[0, i] = i;

            // Populate first col.
            for (int i = 0; i < start.Length + 1; i++)
                matrix[i, 0] = i;

            // Populate additional columns.
            for (int row = 1; row < end.Length + 1; row++)
                for (int col = 1; col < start.Length + 1; col++)
                {
                    // Determine whether we need to add 1.
                    int matchAdd = end[row - 1] == start[col - 1] ? 0 : 1;

                    // Find lowest.
                    int lowest = Math.Min(matrix[row, col - 1], matrix[row - 1, col - 1]);
                    lowest = Math.Min(lowest, matrix[row - 1, col]);

                    // Update matrix.
                    matrix[row, col] = lowest + matchAdd;
                }

            // Return result.
            return matrix[start.Length, end.Length];
        }
    }
}
