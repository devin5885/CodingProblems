using System;

namespace CodingProblems.Array_.MergeSortedInline
{
    /// <summary>
    /// Implements Merge
    /// </summary>
    public static class ArrayMergeSortedInline1Complete
    {
        /// <summary>
        /// Merges sorted list b into a. a is assumed to have enough space for both arrays.
        /// Note: Use parameter names consistent with CtCI.
        /// </summary>
        /// <param name="a">The first list to merge.</param>
        /// <param name="aCount">The count of elements in a to merge.</param>
        /// <param name="b">The second list to merge.</param>
        public static void Merge(int[] a, int aCount, int[] b)
        {
            // Error checking.
            if (a == null || b == null)
                throw new ArgumentException("Both arrays must be non-null");

            // Error checking.
            if (aCount < 0)
                throw new ArgumentException("Count must be positive.");

            // Initialize references.
            var aSrcCurr = aCount - 1;
            var bSrcCurr = b.Length - 1;
            var aTargetCurr = a.Length - 1;

            // Take while available.
            while (aSrcCurr >= 0 && bSrcCurr >= 0)
            {
                // Take a.
                // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
                if (a[aSrcCurr] > b[bSrcCurr])
                {
                    a[aTargetCurr--] = a[aSrcCurr--];
                }
                // Take b.
                else
                {
                    a[aTargetCurr--] = b[bSrcCurr--];
                }
            }

            // Ran out of a, take remaining b.
            while (aSrcCurr < 0 && bSrcCurr >= 0)
            {
                a[aTargetCurr--] = b[bSrcCurr--];
            }

            // Ran out of b, take remaining a.
            while (bSrcCurr < 0 && aSrcCurr >= 0)
            {
                a[aTargetCurr--] = a[aSrcCurr--];
            }
        }
    }
}
