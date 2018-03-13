using System;

namespace CodingProblems.BitManipulation.CreatePatternMask
{
    /// <summary>
    /// Implements CreatePatternMask
    /// </summary>
    public static class BitManipulationCreatePatternMask1Complete
    {
        /// <summary>
        /// Creates a pattern mask.
        /// </summary>
        /// <param name="pattern">The initial pattern to repeat.</param>
        /// <param name="patternbitcount">The number of bits in the pattern to repeat (including leading zeros)</param>
        /// <returns>The resulting mask.</returns>
        public static int CreatePatternMask(int pattern, int patternbitcount)
        {
            // Determine the max index.
            var indexmax = sizeof(int) * 8;

            // Error checking.
            if (patternbitcount <= 0 || patternbitcount > indexmax)
                throw new ArgumentException($"Pattern bit count must less than indexmax. patternbitcount: {patternbitcount} indexmax: {indexmax}");

            // Start with pattern.
            var mask = pattern;

            // Continue while updating bits.
            while (patternbitcount < indexmax)
            {
                // Increment.
                pattern <<= patternbitcount;

                // Update mask.
                mask |= pattern;

                // Update pattern.
                pattern = mask;

                // Update pattern count.
                patternbitcount *= 2;
            }

            // Return resulting mask.
            return mask;
        }
    }
}