using System;
using CodingProblems.BitManipulation.Helpers;

namespace CodingProblems.BitManipulation.GetMostSignificantBit
{
    /// <summary>
    /// Implements GetMostSignificantBit
    /// </summary>
    public static class BitManipulationGetMostSignificantBit4BinarySearchComplete
    {
        /// <summary>
        /// Given a positive signed integer, find the (1 based) index of the most significant bit.
        /// </summary>
        /// <param name="n">The signed integer to check.</param>
        /// <returns>The index of the most significant bit.</returns>
        public static int GetMostSignificantBit(int n)
        {
            // Error Check.
            if (n < 0)
                throw new ArgumentException("Only positive numbers are supported.");

            // Special case for 0.
            if (n == 0)
                return 0;

            // Initialize initial size.
            var size = 32;

            // Set initial values.
            var left = size;
            var middle = size / 2;
            var right = 0;

            // Get initial mask.
            uint mask = GetMask(left, middle);

            while (true)
            {
                if ((n & mask) == 0)
                // Go right.
                {
                    // Done.
                    if (size == 2)
                        return right + 1;

                    // Update values.
                    size /= 2;
                    left = middle;
                    middle = left - (size / 2);
                }
                else
                // Go left.
                {
                    // Done.
                    if (size == 2)
                        return left;

                    // Update values.
                    size /= 2;
                    right = middle;
                    middle = right + (size / 2);
                }

                // Build new mask.
                mask = GetMask(left, middle);
            }
        }

        /// <summary>
        /// Gets the specified unsigned integer mask, with bits left - 1 to middle set.
        /// </summary>
        /// <param name="left">1 more than the first bit to set.</param>
        /// <param name="middle">The last bit to set.</param>
        /// <returns>The mask.</returns>
        private static uint GetMask(int left, int middle)
        {
            // Build new mask.
            uint mask = 0;
            for (int set = left - 1; set >= middle; set--)
                mask = mask.SetBit(set);
            return mask;
        }
    }
}
