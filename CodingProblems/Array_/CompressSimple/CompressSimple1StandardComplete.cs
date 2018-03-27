using System;
using System.Collections.Generic;

namespace CodingProblems.Array_.CompressSimple
{
    /// <summary>
    /// Implements CompressSimple
    /// </summary>
    public static class CompressSimple1StandardComplete
    {
        /// <summary>
        /// Performs simple compression on a list by parsing the list and
        /// converting it to a list of each element and the count of
        /// consecutive matching elements followed by the element itself.
        /// (i.e.) 10, 10, 10, 10, 20, 20, 30, 15, 15, 15
        /// would return 4, 10, 2, 20, 1, 30, 3, 15.
        /// </summary>
        /// <param name="input">The input list.</param>
        /// <returns>The resulting list.</returns>
        public static List<int> CompressSimple(List<int> input)
        {
            if (input == null)
                throw new ArgumentException("A non-null list must be specified.");

            // Initialize output.
            var output = new List<int>();

            // Start countCurr at 1 count since there is at least one of this element.
            for (int nCurr = 0, countCurr = 1; nCurr < input.Count; nCurr++)
            {
                // Get current.
                var intCurr = input[nCurr];

                // Get next (Use nullable since we may be at end of list).
                int? intNext = null;
                if (nCurr != input.Count - 1)
                    intNext = input[nCurr + 1];

                // If at end of list, just add, otherwise do compare.
                if (intNext != null && intCurr == (int)intNext)
                    countCurr++;
                else
                {
                    // Output
                    output.Add(countCurr);
                    output.Add(input[nCurr]);

                    // Reset count.
                    countCurr = 1;
                }
            }

            // Return result.
            return output;
        }
    }
}
