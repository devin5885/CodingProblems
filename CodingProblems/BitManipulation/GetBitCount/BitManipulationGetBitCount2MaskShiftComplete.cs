namespace CodingProblems.BitManipulation.GetBitCount
{
    /// <summary>
    /// Implements GetBitCount
    /// </summary>
    public static class BitManipulationGetBitCount2MaskShiftComplete
    {
        /// <summary>
        /// Count the # of bits that are set in a given signed integer.
        /// </summary>
        /// <param name="n">The signed integer.</param>
        /// <returns>The count of set bits.</returns>
        public static int GetBitCount(int n)
        {
            // Each time compare the current mask to n. If non-zero we know the bit is set.
            var total = 0;
            for (var i = 0; i < 32; i++)
            {
                var mask = 1 << i;
                if ((n & mask) != 0)
                    total++;
            }
            return total;
        }
    }
}