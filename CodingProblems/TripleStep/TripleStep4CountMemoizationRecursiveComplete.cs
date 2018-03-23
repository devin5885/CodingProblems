using System;

namespace CodingProblems.TripleStep
{
    /// <summary>
    /// Implements TripleStep4CountMemoizationRecursiveComplete
    /// </summary>
    public static class TripleStep4CountMemoizationRecursiveComplete
    {
        /// <summary>
        /// Returns the count of ways to go up 'steps' number of steps in 1,
        /// 2, or 3 increments.
        /// </summary>
        /// <param name="steps">The number of steps.</param>
        /// <returns>The resulting count.</returns>
        public static int CountWays(int steps)
        {
            // Error checking.
            if (steps <= 0)
                throw new ArgumentException("steps must be greater than 0.");

            // Initialize array.
            int[] memo = new int[steps + 1];
            memo[0] = 1;

            // Call helper.
            return CountWaysHelper(steps, memo);
        }

        /// <summary>
        /// Helper for CountWays
        /// </summary>
        /// <param name="steps">The number of steps.</param>
        /// <param name="memo">The stored results</param>
        /// <returns>The count for steps.</returns>
        public static int CountWaysHelper(int steps, int[] memo)
        {
            // Special case, less than 0 return 0, equal to 0 return 1.
            if (steps < 0)
                return 0;
            // Already computed case.
            else if (memo[steps] != 0)
                return memo[steps];
            // Standard case.
            else
            {
                // Calculate & return.
                memo[steps] = CountWaysHelper(steps - 1, memo) + CountWaysHelper(steps - 2, memo) + CountWaysHelper(steps - 3, memo);
                return memo[steps];
            }
        }
    }
}