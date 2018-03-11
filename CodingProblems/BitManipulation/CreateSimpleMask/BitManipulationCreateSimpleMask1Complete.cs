using System;

namespace CodingProblems.BitManipulation.CreateSimpleMask
{
    /// <summary>
    /// Implements CreateSimpleMask
    /// </summary>
    public static class BitManipulationCreateSimpleMask1Complete
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

            // Create initial mask of all 1's.
            // Note: Must be unsigned int so that 0's will be shifted in.
            uint mask = 0xFFFF_FFFF;

            // Do the shifts.
            mask >>= indexmax - msbindex + lsbindex;
            mask <<= lsbindex;

            // Return the mask.
            return (int)mask;
        }
    }
}