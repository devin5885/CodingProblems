using System;
using System.Collections.Generic;

namespace CodingProblems.Array_.Sort
{
    /// <summary>
    /// Implements Sort.
    /// </summary>
    public static class ArraySort2SelectionSortComplete
    {
        /// <summary>
        /// Sorts the array using Selection Sort.
        /// </summary>
        /// <param name="input">The input array.</param>
        public static void Sort(List<int> input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException("Input array must not be null.");

            // Outer loop, loop through list n - 1 times upwards. outer
            // (inclusive) will be the unsorted part of list at start of the
            // loop.
            // Note that we can skip the last swap (thus n - 1) since there is
            // nothing to swap.
            for (var outerIndex = 0; outerIndex < input.Count - 1; outerIndex++)
            {
                // Inner loop, find the lowest element.
                var lowestIndex = outerIndex;
                for (var innerIndex = input.Count - 1; innerIndex > outerIndex; innerIndex--)
                {
                    if (input[innerIndex] < input[lowestIndex])
                        lowestIndex = innerIndex;
                }

                // Swap
                if (outerIndex != lowestIndex)
                    Swap(input, lowestIndex, outerIndex);
            }
        }

        /// <summary>
        /// Helper that swaps firstIndex and secondIndex in the input array.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <param name="firstIndex">The first index.</param>
        /// <param name="secondIndex">The second index.</param>
        public static void Swap(List<int> input, int firstIndex, int secondIndex)
        {
            var temp = input[firstIndex];
            input[firstIndex] = input[secondIndex];
            input[secondIndex] = temp;
        }
    }
}
