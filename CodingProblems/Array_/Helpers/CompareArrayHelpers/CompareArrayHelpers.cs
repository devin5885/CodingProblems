using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems.Array_.Helpers.CompareArrayHelpers
{
    /// <summary>
    ///  Helpers to compare arrays.
    /// </summary>
    public static class CompareArrayHelpers
    {
        /// <summary>
        ///  Compares arrays that are composed of sub-arrays to determine if the arrays contain the same sub-arrays
        ///  (in any order). (Sub-arrays can also contain matching elements in any order).
        /// </summary>
        /// <typeparam name="T">The type of objects that the array stores.</typeparam>
        /// <param name="arrayOfArraysExpected">The expected array of arrays.</param>
        /// <param name="arraysOfArrayActual">The actual array of arrays.</param>
        /// <param name="anyOrder">Whether the order of the elements in the array must match.</param>
        /// <returns>True if the arrays match, false otherwise.</returns>
        public static bool CompareArrays<T>(List<List<T>> arrayOfArraysExpected, List<List<T>> arraysOfArrayActual, bool anyOrder = true)
            where T : IComparable
        {
            if (arrayOfArraysExpected.Count != arraysOfArrayActual.Count)
                return false;

            for (var i = 0; i < arrayOfArraysExpected.Count(); i++)
            {
                if (anyOrder)
                {
                    if (!ContainsArray(arrayOfArraysExpected[i], arraysOfArrayActual))
                        return false;
                }
                else
                {
                    if (!CompareArrays(arrayOfArraysExpected[i], arraysOfArrayActual[i], false))
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        ///  Determines if an array of arrays contains an array. (The array's elements can match in any order).
        /// </summary>
        /// <typeparam name="T">The type of objects that the array stores.</typeparam>
        /// <param name="arrayToFind">The array to find.</param>
        /// <param name="arrayOfArraysToSearch">The array of arrays to search.</param>
        /// <returns>True if the array was found, false otherwise.</returns>
        public static bool ContainsArray<T>(List<T> arrayToFind, List<List<T>> arrayOfArraysToSearch)
            where T : IComparable
        {
            foreach (var arrayCurrent in arrayOfArraysToSearch)
            {
                if (CompareArrays(arrayToFind, arrayCurrent))
                    return true;
            }

            // No match.
            return false;
        }

        /// <summary>
        ///  Compares two arrays to determine if they have the same elements (in any order).
        /// </summary>
        /// <typeparam name="T">The type of objects that the array stores.</typeparam>
        /// <param name="array1">The first array.</param>
        /// <param name="array2">The second array.</param>
        /// <param name="anyOrder">Whether the order of the elements in the array must match.</param>
        /// <returns>True if the arrays match, false otherwise.</returns>
        public static bool CompareArrays<T>(List<T> array1, List<T> array2, bool anyOrder = true)
            where T : IComparable
        {
            if (array1.Count != array2.Count)
                return false;

            for (var i = 0; i < array1.Count(); i++)
            {
                if (anyOrder)
                {
                    if (array2.IndexOf(array1[i]) == -1)
                        return false;
                }
                else
                {
                    if (array1[i].CompareTo(array2[i]) != 0)
                        return false;
                }
            }

            return true;
        }
    }
}
