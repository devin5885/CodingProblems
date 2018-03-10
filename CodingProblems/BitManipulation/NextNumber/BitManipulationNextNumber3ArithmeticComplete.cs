using System;

namespace CodingProblems.BitManipulation.NextNumber
{
    /// <summary>
    /// Implements GetNext and GetPrev
    /// </summary>
    public static class BitManipulationNextNumber3ArithmeticComplete
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

            // Initialize temp value.
            var current = num;

            // First determine the count of 0's in the right-most bits.
            // Continue while the bit in the 0 position is 0 and there
            // are non-zero bits left.
            var count0 = 0;
            while (((current & 1) == 0) && current != 0)
            {
                count0++;
                // Note: Shift in 0's.
                current = (int)((uint)current >> 1);
            }
            // Note that 'current' is reused in the next loop starting
            // with it's value at the end of this loop.

            // Determine the count of 1's in the right-most bits starting
            // after any 0's (found in the above loop).
            var count1 = 0;
            while ((current & 1) == 1)
            {
                count1++;
                // Note: Shift in 0's.
                current = (int)((uint)current >> 1);
            }

            // Error Check
            //
            // Either:
            // All zeros - count0 + count1 = 0
            //
            // All 1's except the sign bit - count0 + count1 = 31 (Sign bit can't be changed).
            //
            // All 1's in the left-most bits (except the sign bit) (Sign bit can't be changed)
            // , all 0's int the right-most bits.
            // (i.e.)
            // 01..1100..00
            // count0 + count1 = 31
            //
            // Note that count1 + count2 = 32 would only be possible for negative #'s because the
            // sign bit would be 1.
            if ((count0 + count1 == 31) || (count0 + count1 == 0))
                return -1;

            // Flip the posSet bit & clear all bits to the right of p.
            num += (int)Math.Pow(2, count0) - 1;
            num += 1;

            // Set the trailing bits to 1.
            num += (int)Math.Pow(2, count1 - 1) - 1;

            // Note: This could be simplified to:
            // num = num + ((int)Math.Pow(2, count0) - 1) + 1 + (int)Math.Pow(2, count1 - 1) - 1;
            // or
            // num = num + (int)Math.Pow(2, count0) + (int)Math.Pow(2, count1 - 1) - 1;
            // or
            // num = num + (1 << count0) + (1 << (count1 - 1)) - 1;

            // Done.
            return num;
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

            // Initialize temp value.
            var current = num;

            // First determine the count of 1's in the right-most bits.
            var count1 = 0;
            while ((current & 1) == 1)
            {
                count1++;
                // Note: Shift in 0's.
                current = (int)((uint)current >> 1);
            }

            // Determine the count of 0's in the right-most bits starting
            // after any 1's (found in the above loop).
            // Continue while the bit in the 0 position is 1 and there
            // are non-zero bits left.
            var count0 = 0;
            while (((current & 1) == 0) && current != 0)
            {
                count0++;
                // Note: Shift in 0's.
                current = (int)((uint)current >> 1);
            }
            // Note that 'current' is reused in the next loop starting
            // with it's value at the end of this loop.

            // Error Check
            //
            // All 1's in the left-most bits, all 0's in the right most bits. (i.e.)
            // 0..1
            // current == 0;
            if (current == 0)
                return -1;

            // Remove trailing 1's & flip trailing zeros.
            num -= (int)Math.Pow(2, count1) - 1;
            num -= 1;

            // Set the trailing bits to 0.
            num -= (int)Math.Pow(2, count0 - 1) - 1;

            // Note: This could be simplified to:
            // num = num - ((int)Math.Pow(2, count1) - 1) - 1 - ((int)Math.Pow(2, count0 - 1) - 1);
            // or
            // num = num - (int)Math.Pow(2, count1) - (int)Math.Pow(2, count0 - 1) + 1;
            // or
            // num = num - (1 << count1) - (1 << (count0 - 1)) + 1;

            // Done.
            return num;
        }
    }
}