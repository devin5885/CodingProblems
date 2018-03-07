using System;
using System.Linq;

namespace CodingProblems.BitManipulation.GetBitCount
{
    /// <summary>
    /// Implements GetBitCount
    /// </summary>
    public static class BitManipulationGetBitCount1ConvertToStringComplete
    {
        /// <summary>
        /// Count the # of bits that are set in a given signed integer.
        /// </summary>
        /// <param name="n">The signed integer.</param>
        /// <returns>The count of set bits.</returns>
        public static int GetBitCount(int n)
        {
            var str = Convert.ToString(n, 2);
            return str.ToCharArray().Count(x => x == '1');
        }
    }
}