using System;
using CodingProblems.BitManipulation.CreateSimpleMask;

namespace CodingProblems.BitManipulation.Insertion
{
    /// <summary>
    /// Implements UpdateBits
    /// </summary>
    public static class BitManipulationInsertion1Complete
    {
        /// <summary>
        /// Merges two 32-bit signed numbers.
        /// </summary>
        /// <param name="n">The value to update.</param>
        /// <param name="m">The value containing the bits to 'merge' into n.</param>
        /// <param name="i">The least significant bit in n to 'merge' m into.</param>
        /// <param name="j">The most significant bit in n to 'merge' m into.</param>
        /// <returns>The updated signed integer.</returns>
        public static int UpdateBits(int n, int m, int i, int j)
        {
            // Determine the max index.
            var indexmax = (sizeof(int) * 8) - 1;

            // Error checking.
            if (i < 0 || i > indexmax)
                throw new ArgumentException($"Invalid i: {i}");

            if (j < 0 || j > indexmax)
                throw new ArgumentException($"Invalid j: {j}");

            if (i > j)
                throw new ArgumentException($"i cannot be greater than j. i: {i}, j: {j}");

            // Build a mask to clear the appropriate bits in n.
            int mask = ~BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(j, i);

            // Clear the appropriate bits in n.
            var cleared = n & mask;

            // Shift the bits to line up the values.
            var shifted = m << i;

            // Return result.
            return cleared | shifted;
        }
    }
}