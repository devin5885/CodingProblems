using System;
using System.Collections.Generic;

namespace CodingProblems.Array_.FindMatchingPairs
{
    /// <summary>
    /// Implements FindMatchingPairs
    /// </summary>
    public static class FindMatchingPairs2SortAndParseComplete
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

            // Build result.
            var result = new List<int>();

            // Sort the lists.
            list1.Sort();
            list2.Sort();

            // Initialize refs.
            int list1IndexCurr = 0;
            int list2IndexCurr = 0;

            // Continue while there are elements to process.
            while (list1IndexCurr < list1.Count && list2IndexCurr < list2.Count)
            {
                // If we found a pair, add to result.
                if (list1[list1IndexCurr] == list2[list2IndexCurr])
                {
                    result.Add(list1[list1IndexCurr]);
                    list1IndexCurr++;
                    list2IndexCurr++;
                }
                // If list1Curr is greater, inc list2Curr.
                else if (list1[list1IndexCurr] > list2[list2IndexCurr])
                    list2IndexCurr++;
                // if list2Curr is greater, inc list1Curr.
                else
                    list1IndexCurr++;
            }

            // Return output.
            return result;
        }
    }
}
