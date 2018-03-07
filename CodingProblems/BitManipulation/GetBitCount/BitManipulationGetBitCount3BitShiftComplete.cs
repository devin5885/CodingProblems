namespace CodingProblems.BitManipulation.GetBitCount
{
    /// <summary>
    /// Implements GetBitCount
    /// </summary>
    public static class BitManipulationGetBitCount3BitShiftComplete
    {
        /// <summary>
        /// Count the # of bits that are set in a given signed integer.
        /// </summary>
        /// <param name="n">The signed integer.</param>
        /// <returns>The count of bits.</returns>
        public static int GetBitCount(int n)
        {
            // Each time compare the current mask to n. If non-zero we know the bit is set.
            var total = 0;
            while (n != 0)
            {
                var mask = 1;
                if ((n & mask) != 0)
                    total++;

                // C# doesn't have a  >>> operator, so we need to use unsigned int.
                n = (int)(((uint)n) >> 1);
            }
            return total;
        }
    }
}