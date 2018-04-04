using System;
using System.Collections.Generic;

namespace CodingProblems.Array_.MergeSorted
{
    /// <summary>
    /// Implements Merge
    /// </summary>
    public static class ArrayMergeSorted1SimpleComplete
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

            // init refs.
            var element1Curr = 0;
            var element2Curr = 0;

            // Take while available.
            while (element1Curr < input1.Count && element2Curr < input2.Count)
            {
                // Take input1.
                // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
                if (input1[element1Curr] < input2[element2Curr])
                {
                    result.Add(input1[element1Curr++]);
                }
                // Take input2.
                else
                {
                    result.Add(input2[element2Curr++]);
                }
            }

            // Ran out of input1, take remaining input2.
            while (element1Curr == input1.Count && element2Curr < input2.Count)
            {
                result.Add(input2[element2Curr++]);
            }

            // Ran out of input2, take remaining input1.
            while (element2Curr == input2.Count && element1Curr < input1.Count)
            {
                result.Add(input1[element1Curr++]);
            }

            // Return result.
            return result;
        }
    }
}
