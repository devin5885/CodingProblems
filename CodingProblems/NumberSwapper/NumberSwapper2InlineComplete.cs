using System;

namespace CodingProblems.NumberSwapper
{
    /// <summary>
    /// Implements Swap
    /// </summary>
    public static class NumberSwapper2InlineComplete
    {
        /// <summary>
        /// Swaps x and y.
        /// </summary>
        /// <param name="x">The first number to swap.</param>
        /// <param name="y">The second number to swap.</param>
        public static void Swap(ref int x, ref int y)
        {
            // Method fails if x and y are the same variable, in this case
            // they will have the same value, so just check for this.
            if (x != y)
            {
                x = x ^ y;
                y = x ^ y;
                x = x ^ y;
            }
        }
    }
}
