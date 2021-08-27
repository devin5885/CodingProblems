using System;

namespace CodingProblems.Array_.MagicIndex
{
    /// <summary>
    /// Implements MagicIndex1BruteForceComplete.FindMagicIndex
    /// </summary>
    public static class MagicIndex1BruteForceComplete
    {
        /// <summary>
        /// Finds and returns the index for which the array contents matches
        /// the index.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The magic index.</returns>
        public static int FindMagicIndex(int[] array)
        {
            // Error checking.
            if (array == null)
                throw new ArgumentException("Invalid array.");

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == i)
                    return i;
            }

            // Not found.
            return -1;
        }
    }
}