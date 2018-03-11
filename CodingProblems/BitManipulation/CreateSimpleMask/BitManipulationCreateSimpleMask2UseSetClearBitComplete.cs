using System;
using CodingProblems.BitManipulation.GetSetClearBit;

namespace CodingProblems.BitManipulation.CreateSimpleMask
{
    /// <summary>
    /// Tests BitManipulationCreateSimpleMaskComplete in various scenarios.
    /// </summary>
    public static class BitManipulationCreateSimpleMask2UseSetClearBitComplete
    {
        /// <summary>
        /// Creates a mask.
        /// </summary>
        /// <param name="msbindex">The index (0-based) of most significant bit
        ///  to set. Must be between 0 and the max index of an int (31)</param>
        /// <param name="lsbindex">The index (0-based) of the least significant
        ///  bit to set. Must be between 0 and the max index of an int (31) and
        ///  less than or equal to the most significant bit index.</param>
        /// <returns>The resulting mask.</returns>
        public static int CreateSimpleMask(int msbindex, int lsbindex)
        {
            // Determine the max index.
            var indexmax = (sizeof(int) * 8) - 1;

            // Error checking.
            if (msbindex < 0 || msbindex > indexmax)
                throw new ArgumentException($"Invalid most significant byte index: {msbindex}");

            if (lsbindex < 0 || lsbindex > indexmax)
                throw new ArgumentException($"Invalid least significant byte index: {lsbindex}");

            if (lsbindex > msbindex)
                throw new ArgumentException($"Least significant byte index must be less than or equal to the most significant byte index: {msbindex}, {lsbindex}");

            // Create initial mask of all 0's.
            int mask = 0;

            // Set the bits.
            for (int n = lsbindex; n <= msbindex; n++)
                mask = BitManipulationGetSetClearBit1Complete.SetClearBit(mask, n);

            // Return the mask.
            return mask;
        }
    }
}