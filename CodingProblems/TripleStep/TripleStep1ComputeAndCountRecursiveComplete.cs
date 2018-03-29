using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems.TripleStep
{
    /// <summary>
    /// Implements TripleStep1ComputeAndCountRecursiveComplete.ComputeWays.
    /// </summary>
    public static class TripleStep1ComputeAndCountRecursiveComplete
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

            // Initialize result.
            var result = new List<List<int>>();

            // Get combinations.
            CountWaysHelper(steps, new List<int>(), result);

            // Return count.
            return result.Count;
        }

        /// <summary>
        /// Helper for CountWays.
        /// </summary>
        /// <param name="steps">The number of steps.</param>
        /// <param name="hopsCurr">The current list of steps.</param>
        /// <param name="resultList">The resulting list.</param>
        private static void CountWaysHelper(int steps, List<int> hopsCurr, List<List<int>> resultList)
        {
            CheckAndAddHelper(1, steps, hopsCurr, resultList);
            CheckAndAddHelper(2, steps, hopsCurr, resultList);
            CheckAndAddHelper(3, steps, hopsCurr, resultList);
        }

        /// <summary>
        /// Helper that takes a list of hops, adds a new hop, then checks what
        /// should be done with the resulting list of hops (i.e.)
        /// either call CountWaysHelper recursively, add to the result list, or
        /// drop.
        /// </summary>
        /// <param name="hops">The number of hops to add.</param>
        /// <param name="steps">The target number of steps.</param>
        /// <param name="hopsCurr">The list of hops.</param>
        /// <param name="resultList">The result list.</param>
        private static void CheckAndAddHelper(int hops, int steps, List<int> hopsCurr, List<List<int>> resultList)
        {
            // Compute new item.
            // ReSharper disable once UseObjectOrCollectionInitializer
            var hopsCurrNew = new List<int>(hopsCurr);

            // Add new hops item.
            hopsCurrNew.Add(hops);

            // Get the sum.
            var sum = hopsCurrNew.Sum();

            // If less we need to keep going.
            if (sum < steps)
                CountWaysHelper(steps, hopsCurrNew, resultList);

            // If match, add to result.
            if (sum == steps)
                resultList.Add(hopsCurrNew);

            // Note: Don't do anything if greater.
        }
    }
}