using System;
using System.Collections.Generic;

namespace CodingProblems.Array_.MergeSorted
{
    /// <summary>
    /// Implements Merge
    /// </summary>
    public static class ArrayMergeSorted2SingleLoopComplete
    {
        /// <summary>
        /// Merges sorted lists input1 and input2.
        /// </summary>
        /// <param name="input1">The first list to merge.</param>
        /// <param name="input2">The second list to merge.</param>
        /// <returns>The merged list.</returns>
        public static List<int> Merge(List<int> input1, List<int> input2)
        {
            // Error checking.
            if (input1 == null || input2 == null)
                throw new ArgumentException();

            // Initialize result.
            var result = new List<int>();

            // initialize refs.
            var list1Curr = 0;
            var list2Curr = 0;

            // Take while available.
            while (list1Curr < input1.Count || list2Curr < input2.Count)
            {
                int? element1 = null;
                if (list1Curr < input1.Count)
                    element1 = input1[list1Curr];

                int? element2 = null;
                if (list2Curr < input2.Count)
                    element2 = input2[list2Curr];

                // Ran out of input2.
                if (element1 != null && element2 == null)
                {
                    result.Add((int)element1);
                    list1Curr++;
                }
                // Ran out of nums 1.
                else if (element2 != null && element1 == null)
                {
                    result.Add((int)element2);
                    list2Curr++;
                }
                // Compare & take input1.
                else if (element1 < element2)
                {
                    result.Add((int)element1);
                    list1Curr++;
                }
                // Compare & take input2.
                else
                {
                    result.Add((int)element2);
                    list2Curr++;
                }
            }

            return result;
        }
    }
}
