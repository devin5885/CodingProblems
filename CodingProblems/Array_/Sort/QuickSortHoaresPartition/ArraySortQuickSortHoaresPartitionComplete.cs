using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace CodingProblems.Array_.Sort
{
    /// <summary>
    /// Implements Sort.
    /// </summary>
    public static class ArraySortQuickSortHoaresPartitionComplete
    {
        /// <summary>
        /// Sorts the array using merge sort.
        /// </summary>
        /// <param name="input">The input array.</param>
        public static void Sort(List<int> input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException("Input array must not be null.");

            SortHelper(input, 0, input.Count - 1);
        }

        /// <summary>
        /// Sorts the array using quick sort.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <param name="startIndex">The start index of the input array.</param>
        /// <param name="endIndex">The end index of the input array.</param>
        public static void SortHelper(List<int> input, int startIndex = 0, int? endIndex = null)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException("Input array must not be null.");

            // Default case.
            if (endIndex == null)
                endIndex = input.Count - 1;

            // Done.
            if (startIndex >= endIndex)
                return;

            // Divide Section
            var pivotIndex = Partition(ref input, startIndex, (int)endIndex);

            // Sort the sub-arrays.
            SortHelper(input, startIndex, pivotIndex - 1);
            SortHelper(input, pivotIndex + 1, endIndex);
        }

        /// <summary>
        /// Sorts the array using quick sort.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <param name="startIndex">The start index of the input array.</param>
        /// <param name="endIndex">The end index of the input array.</param>
        /// <returns>the partition index</returns>
        private static int Partition(ref List<int> input, int startIndex, int endIndex)
        {
            // First get a random index.
            var randomIndex = new Random().Next(startIndex, endIndex);

            // Put the pivot at first index.
            Swap(input, startIndex, randomIndex);

            // Init pointers.
            // ReSharper disable once InlineTemporaryVariable
            var pivotIndex = startIndex;
            var orangeIndex = startIndex + 1;
            var greenIndex = endIndex;

            // Keep going until pointers cross.
            while (greenIndex >= orangeIndex)
            {
                while (greenIndex >= orangeIndex && input[orangeIndex] <= input[pivotIndex])
                    orangeIndex++;

                while (greenIndex >= orangeIndex && input[greenIndex] > input[pivotIndex])
                    greenIndex--;

                if (greenIndex >= orangeIndex)
                {
                    Swap(input, greenIndex, orangeIndex);
                    greenIndex++;
                    orangeIndex--;
                }
            }

            // Put the pivot back.
            Swap(input, pivotIndex, greenIndex);

            // Return the location of the pivot element.
            return greenIndex;
        }

        /// <summary>
        /// Helper that swaps firstIndex and secondIndex in the input array.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <param name="firstIndex">The first index.</param>
        /// <param name="secondIndex">The second index.</param>
        private static void Swap(List<int> input, int firstIndex, int secondIndex)
        {
            var temp = input[firstIndex];
            input[firstIndex] = input[secondIndex];
            input[secondIndex] = temp;
        }
    }
}
