using System;
using System.Collections.Generic;

namespace CodingProblems.Array_.Sort
{
    /// <summary>
    /// Implements Sort.
    /// </summary>
    public static class ArraySort1BubbleSortComplete
    {
        /// <summary>
        /// Sorts the array using Bubble Sort.
        /// </summary>
        /// <param name="input">The input array.</param>
        public static void Sort(List<int> input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException("Input array must not be null.");

            // Initialize swapped flag
            var swapped = true;

            // Outer loop:
            // Loop through unsorted part of list upwards until all items are sorted.
            // Elements on the left of outer are sorted.
            for (var outerIndex = 0; outerIndex < input.Count - 1 && swapped; outerIndex++)
            {
                // Reset for each new loop.
                swapped = false;

                // Inner loop
                // Loop through unsorted part of list downward, swapping elements as needed.
                //  Start at top of list - 1, end at last unsorted element.
                for (var innerIndex = input.Count - 2; innerIndex >= outerIndex; innerIndex--)
                {
                    // Swap if outer > outer + 1
                    if (input[innerIndex] > input[innerIndex + 1])
                    {
                        // Swap occurred.
                        swapped = true;
                        Swap(input, innerIndex, innerIndex + 1);
                    }
                }
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
