using System;
using System.Collections.Generic;

namespace CodingProblems.Array_.PowerSet
{
    /// <summary>
    /// Implements PowerSet2CombinatoricsComplete.GetPowerSet
    /// </summary>
    public static class PowerSet2CombinatoricsComplete
    {
        /// <summary>
        /// Gets the power set of the set specified via the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The power set.</returns>
        public static List<List<int>> GetPowerSet(int[] array)
        {
            // Initialize result.
            var result = new List<List<int>>();

            // Determine the maximum value.
            var dvaluemax = Math.Pow(2, array.Length);

            // Check for overflow.
            if (dvaluemax > int.MaxValue)
                throw new OverflowException();

            // Get the maximum value.
            var valuemax = Convert.ToInt32(dvaluemax);

            // Compute and add sets, one set for each value.
            for (var i = 0; i < valuemax; i++)
            {
                result.Add(GetPowerSetForValue(array, i));
            }

            // Return result.
            return result;
        }

        /// <summary>
        /// Helper for GetPowerSet which give a value and an array, computes
        /// the set of values corresponding to the bits in the number.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="value">The value.</param>
        /// <returns>The resulting set.</returns>
        private static List<int> GetPowerSetForValue(int[] array, int value)
        {
            // Initialize current result.
            var result = new List<int>();

            // Loop through the bits of the value via right shift,
            // checking each, if the bit is set, add the array value to the set.
            for (int curr = value, index = 0; curr > 0; curr >>= 1, index++)
            {
                if ((curr & 1) != 0)
                    result.Add(array[index]);
            }

            // Return the resulting set.
            return result;
        }
    }
}