using System;

namespace CodingProblems.TripleStep
{
    /// <summary>
    /// Implements TripleStep3CountRecursiveComplete
    /// </summary>
    public static class TripleStep3CountRecursiveComplete
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

            // Call helper.
            return CountWaysHelper(steps);
        }

        /// <summary>
        /// Helper for CountWays.
        /// </summary>
        /// <param name="steps">The number of steps.</param>
        /// <returns>The resulting count.</returns>
        public static int CountWaysHelper(int steps)
        {
            // Special case, less than 0 return 0, equal to 0 return 1.
            if (steps < 0)
                return 0;
            else if (steps == 0)
                return 1;
            // Standard case.
            else
                return CountWaysHelper(steps - 1) + CountWaysHelper(steps - 2) + CountWaysHelper(steps - 3);
        }
    }
}