using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems.Array_.FindMatches
{
    /// <summary>
    /// Implements FindMatches
    /// </summary>
    public static class FindMatches1BruteForceComplete
    {
        /// <summary>
        /// Given two lists of integers return a list of elements that are in both lists.
        /// </summary>
        /// <param name="list1">The first list.</param>
        /// <param name="list2">The second list.</param>
        /// <returns>The resulting list.</returns>
        public static List<int> FindMatches(List<int> list1, List<int> list2)
        {
            // Initialize result.
            var result = new List<int>();

            // Walk the first list, each time through walk the second list. If a match is found record. Ignore matches if already in list.
            foreach (var list1ElementCurr in list1)
            {
                // Update instance count when a match is found.
                var binstancecount = 0;

                foreach (var list2ElementCurr in list2)
                {
                    // Tracker.
                    // i | j | a[i] | a[j] | bInstanceCount | aInstanceCount | Output
                    if (list1ElementCurr == list2ElementCurr)
                    {
                        // See how many previous matches we found, this tells us the instance index we are on in a.
                        var ainstancecount = result.Count(x => x == list1ElementCurr);

                        // Determine if we add this match.
                        // If there are more b-instances than a-instances we need to add.
                        if (binstancecount >= ainstancecount)
                        {
                            result.Add(list1ElementCurr);

                            // Once we add we are done.
                            break;
                        }

                        // Update the b instance count.
                        binstancecount++;
                    }
                }
            }

            // Return output.
            return result;
        }
    }
}
