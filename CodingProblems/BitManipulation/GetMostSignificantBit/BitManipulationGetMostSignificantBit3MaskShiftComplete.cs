using System;

namespace CodingProblems.BitManipulation.GetMostSignificantBit
{
    /// <summary>
    /// Implements GetMostSignificantBit
    /// </summary>
    public static class BitManipulationGetMostSignificantBit3MaskShiftComplete
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

            // Check all bits, return the first set bit.
            for (var i = (sizeof(int) * 8) - 1; i >= 0; i--)
            {
                // Build the mask.
                uint mask = (uint)1 << i;

                // If bit is set return index + 1.
                if ((n & mask) != 0)
                    return i + 1;
            }

            // Return the last set bit.
            return 0;
        }
    }
}
