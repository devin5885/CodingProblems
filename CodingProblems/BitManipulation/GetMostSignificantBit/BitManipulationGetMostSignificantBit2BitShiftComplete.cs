using System;

namespace CodingProblems.BitManipulation.GetMostSignificantBit
{
    /// <summary>
    /// Implements GetMostSignificantBit
    /// </summary>
    public static class BitManipulationGetMostSignificantBit2BitShiftComplete
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

            // Check all bits, record the last set bit.
            int last1 = 0;
            for (var i = 0; i < (sizeof(int) * 8); i++)
            {
                // And with 1 to clear all bits but 0th.
                // It set, store index.
                if ((n & 1) == 1)
                    last1 = i;

                // Shift so that we can do the same compare each time.
                // C# doesn't have a  >>> operator, so we need to use unsigned int.
                n = (int)(((uint)n) >> 1);
            }

            // Return the last set bit.
            return last1 + 1;
        }
    }
}
