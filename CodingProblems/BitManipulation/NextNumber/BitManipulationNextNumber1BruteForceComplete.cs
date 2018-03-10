using System;
using CodingProblems.BitManipulation.GetBitCount;

namespace CodingProblems.BitManipulation.NextNumber
{
    /// <summary>
    /// Implements GetNext and GetPrev
    /// </summary>
    public static class BitManipulationNextNumber1BruteForceComplete
    {
        /// <summary>
        /// Gets and returns the next highest number that matches the bit count
        /// of the passed in value.
        /// </summary>
        /// <param name="num">The value.</param>
        /// <returns>The next highest number or -1 if no matching number.</returns>
        public static int GetNext(int num)
        {
            // Error check.
            if (num < 0)
                throw new ArgumentException("A positive number must be specified.");

            // Get the count.
            var count = BitManipulationGetBitCount3BitShiftComplete.GetBitCount(num);

            // For efficiency just return -1 for these cases.
            if (count == 31 || count == 0)
                return -1;

            // Find the next number that matches.
            // Note that if an overflow occurs next will be equal to 0.
            for (int next = num + 1; next > 0; next++)
            {
                // Once a match is found, return it.
                if (BitManipulationGetBitCount3BitShiftComplete.GetBitCount(next) == count)
                    return next;
            }

            // No match found.
            return -1;
        }

        /// <summary>
        /// Gets and returns the next lowest number that matches the bit count
        /// of the passed in value.
        /// </summary>
        /// <param name="num">The value.</param>
        /// <returns>The next lowest number or -1 if no matching number.</returns>
        public static int GetPrev(int num)
        {
            // Error check.
            if (num < 0)
                throw new ArgumentException("A positive number must be specified.");

            // Get the count.
            var count = BitManipulationGetBitCount3BitShiftComplete.GetBitCount(num);

            // For efficiency just return -1 for these cases.
            if (count == 31 || count == 0)
                return -1;

            // Find the next number that matches.
            for (int next = num - 1; next > 0; next--)
            {
                // Once a match is found, return it.
                if (BitManipulationGetBitCount3BitShiftComplete.GetBitCount(next) == count)
                    return next;
            }

            // No match found.
            return -1;
        }
    }
}