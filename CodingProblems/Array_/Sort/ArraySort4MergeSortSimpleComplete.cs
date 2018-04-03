using System;
using System.Collections.Generic;
using System.Linq;
using CodingProblems.Array_.Merge;

namespace CodingProblems.Array_.Sort
{
    /// <summary>
    /// Implements Sort.
    /// </summary>
    public static class ArraySort4MergeSortSimpleComplete
    {
        /// <summary>
        /// Sorts the array using simple Merge Sort.
        /// </summary>
        /// <param name="input">The input array.</param>
        public static void Sort(List<int> input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException("Input array must not be null.");

            // Stop recursion.
            if (input.Count == 1 || input.Count == 0)
                return;

            // Figure out lengths.
            var lengthl = (input.Count / 2) + (input.Count % 2);
            var lengthr = input.Count / 2;

            // Sort left half (Copy to helper array & sort).
            var inputLeft = new List<int>();
            inputLeft.AddRange(input.Take(lengthl));
            Sort(inputLeft);

            // Sort right half (Copy to helper array & sort).
            var inputRight = new List<int>();
            inputRight.AddRange(input.Skip(lengthl).Take(lengthr));
            Sort(inputRight);

            // Now merge the lists.
            var result = ArrayMergeSorted1SimpleComplete.Merge(inputLeft, inputRight);

            // Copy back to input.
            input.Clear();
            input.AddRange(result);
        }
    }
}
