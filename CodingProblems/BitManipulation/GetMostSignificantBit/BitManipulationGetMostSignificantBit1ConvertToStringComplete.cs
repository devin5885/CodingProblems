using System;

namespace CodingProblems.BitManipulation.GetMostSignificantBit
{
    /// <summary>
    /// Implements GetMostSignificantBit
    /// </summary>
    public static class BitManipulationGetMostSignificantBit1ConvertToStringComplete
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

            // Most simple, convert.
            var str = Convert.ToString(n, 2);
            return str.Length;
        }
    }
}
