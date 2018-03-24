using System;
using System.Collections.Generic;

namespace CodingProblems.Array_.PowerSet
{
    /// <summary>
    /// Implements PowerSet1RecursiveComplete.GetPowerSet
    /// </summary>
    public static class PowerSet1RecursiveComplete
    {
        /// <summary>
        /// Gets the power set of the set specified via the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The power set.</returns>
        public static List<List<int>> GetPowerSet(int[] array)
        {
            var result = new List<List<int>>();
            GetPowerSetHelper(array, -1, result);
            return result;
        }

        /// <summary>
        /// Helper for GetPowerSet
        /// </summary>
        /// <param name="array">The set represented as a array.</param>
        /// <param name="indexCurr">The current index.</param>
        /// <param name="result">The resulting power set.</param>
        private static void GetPowerSetHelper(int[] array, int indexCurr, List<List<int>> result)
        {
            // Done.
            if (indexCurr >= array.Length)
                return;

            // Add empty set.
            if (indexCurr == -1)
            {
                result.Add(new List<int>());
            }
            // Add additional sets.
            else
            {
                // Build new lists.
                var newResult = new List<List<int>>();
                foreach (var list in result)
                {
                    var listNew = new List<int>(list);
                    listNew.Add(array[indexCurr]);
                    newResult.Add(listNew);
                }

                // Now add the new entries.
                result.AddRange(newResult);
            }

            // Continue.
            GetPowerSetHelper(array, ++indexCurr, result);
        }
    }
}