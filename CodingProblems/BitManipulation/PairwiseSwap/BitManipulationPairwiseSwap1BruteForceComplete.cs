using CodingProblems.BitManipulation.GetSetClearBit;

namespace CodingProblems.BitManipulation.PairwiseSwap
{
    /// <summary>
    /// Implements SwapOddEvenBits
    /// </summary>
    public static class BitManipulationPairwiseSwap1BruteForceComplete
    {
        /// <summary>
        /// Swaps the odd and even numbered bits in the specified value and return it.
        /// </summary>
        /// <param name="num">The value to update.</param>
        /// <returns>The updated value.</returns>
        public static int SwapOddEvenBits(int num)
        {
            // Determine the max index.
            var indexmax = (sizeof(int) * 8) - 1;

            // Swap all bits.
            for (int i = 0; i <= indexmax - 1; i += 2)
            {
                // Get current values.
                var setEven = BitManipulationGetSetClearBit1Complete.GetBit(num, i);
                var setOdd = BitManipulationGetSetClearBit1Complete.GetBit(num, i + 1);

                // Update values.
                num = BitManipulationGetSetClearBit1Complete.SetClearBit(num, i + 1, setEven);
                num = BitManipulationGetSetClearBit1Complete.SetClearBit(num, i, setOdd);
            }

            // Return result.
            return num;
        }
    }
}