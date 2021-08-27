using System;
using System.Collections.Generic;

namespace CodingProblems.Array_.FindMatchingPairs
{
    /// <summary>
    /// Implements FindMatchingPairs
    /// </summary>
    public static class FindMatchingPairs1CharCountMapsComplete
    {
        /// <summary>
        /// Given two lists, return a list containing one element for each pair of matching
        /// elements.
        /// </summary>
        /// <param name="list1">The first list.</param>
        /// <param name="list2">The second list.</param>
        /// <returns>The resulting list.</returns>
        public static List<int> FindMatchingPairs(List<int> list1, List<int> list2)
        {
            // Error checking.
            if (list1 == null || list2 == null)
                throw new ArgumentException("Both lists must be non-null");

            // Create dictionaries.
            var dictionary1 = BuildElementCountDictionary(list1);
            var dictionary2 = BuildElementCountDictionary(list2);

            // Build result.
            var result = new List<int>();

            // Check each element in first dictionary.
            foreach (var kvp in dictionary1)
            {
                // Check for element in second dictionary.
                if (dictionary2.TryGetValue(kvp.Key, out var count))
                {
                    // Determine count to add to add.
                    var toAdd = Math.Min(kvp.Value, count);

                    // Add to result.
                    for (var k = 0; k < toAdd; k++)
                        result.Add(kvp.Key);
                }
            }

            // Return output.
            return result;
        }

        /// <summary>
        /// Builds a dictionary of elements and their counts.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns>The resulting dictionary.</returns>
        private static Dictionary<int, int> BuildElementCountDictionary(List<int> list)
        {
            // Error checking.
            if (list == null)
                throw new ArgumentException();

            // Build result.
            var result = new Dictionary<int, int>();

            // Handle entire list.
            foreach (var element in list)
            {
                // Check if already in list, if so increment count.
                if (result.TryGetValue(element, out var count))
                {
                    result[element] = ++count;
                }
                // Otherwise add to the list.
                else
                    result.Add(element, 1);
            }

            // Return result.
            return result;
        }
    }
}
