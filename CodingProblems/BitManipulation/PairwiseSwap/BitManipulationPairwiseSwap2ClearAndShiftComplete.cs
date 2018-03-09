using System;

namespace CodingProblems.BitManipulation.PairwiseSwap
{
    /// <summary>
    /// Implements SwapOddEvenBits
    /// </summary>
    public static class BitManipulationPairwiseSwap2ClearAndShiftComplete
    {
        /// <summary>
        /// Swaps the odd and even numbered bits in the specified value and return it.
        /// </summary>
        /// <param name="num">The value to update.</param>
        /// <returns>The updated value.</returns>
        public static int SwapOddEvenBits(int num)
        {
            // Create a mask to 0 all even bits.
            var maskEven = Convert.ToInt32("01010101010101010101010101010101", 2);

            // Zero the even bits.
            var even = num & maskEven;

            // Shift them.
            // Note that we right shift because we kept the 0th bit value and
            // we don't want to shift it away.
            even <<= 1;

            // Create a mask to 0 all odd bits.
            var maskOdd = Convert.ToInt32("10101010101010101010101010101010", 2);

            // zero the odd bits.
            var odd = num & maskOdd;

            // Shift them.
            // Note that we left shift because we kept the 31st bit value and
            // we don't want to shift it away.
            // Note: Use unsigned int because CSharp does not have an >>> operator
            // and we want to always shift in 0.
            odd = (int)(((uint)odd) >> 1);

            // Return result.
            return even | odd;
        }
    }
}