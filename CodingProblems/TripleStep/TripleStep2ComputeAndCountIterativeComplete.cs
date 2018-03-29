using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems.TripleStep
{
    /// <summary>
    /// Implements TripleStep2ComputeAndCountIterativeComplete.ComputeWays.
    /// </summary>
    public static class TripleStep2ComputeAndCountIterativeComplete
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

            // Initialize result list.
            var resultList = new List<List<int>>();

            // Initialize current list.
            var currList = new List<List<int>>();
            CheckAndAddHelper(1, steps, new List<int>(), currList, resultList);
            CheckAndAddHelper(2, steps, new List<int>(), currList, resultList);
            CheckAndAddHelper(3, steps, new List<int>(), currList, resultList);

            // Continue while we have items to process.
            while (currList.Count > 0)
            {
                // Initialize list for next iteration.
                var currListNext = new List<List<int>>();

                // Process each item.
                foreach (var hopsCurr in currList)
                {
                    CheckAndAddHelper(1, steps, hopsCurr, currListNext, resultList);
                    CheckAndAddHelper(2, steps, hopsCurr, currListNext, resultList);
                    CheckAndAddHelper(3, steps, hopsCurr, currListNext, resultList);
                }

                // Use updated list.
                currList = currListNext;
            }

            // Return count.
            return resultList.Count;
        }

        /// <summary>
        /// Helper that takes a list of hops, adds a new hop, then checks what
        /// should be done with the resulting list of hops (i.e.)
        /// either add to the resultList, add to the next list, or drop.
        /// </summary>
        /// <param name="hops">The number of hops to add.</param>
        /// <param name="steps">The target number of steps.</param>
        /// <param name="hopsCurr">The list of hops.</param>
        /// <param name="currListNext">The list of lists to process in the next
        /// iteration.</param>
        /// <param name="resultList">The result list.</param>
        private static void CheckAndAddHelper(int hops, int steps, List<int> hopsCurr, List<List<int>> currListNext, List<List<int>> resultList)
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
                currListNext.Add(hopsCurrNew);

            // If match, add to result.
            if (sum == steps)
                resultList.Add(hopsCurrNew);

            // Note: Don't do anything if greater.
        }
    }
}