using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems.Array_.FindMatches
{
    public static class FindMatches1BruteForceComplete
    {
        // Given two lists of integers a, b, return a list of "greedy" matches (i.e.) for each pair of elements matching in a, b, return the element.
        // For this case, generate w/o using a second data structure.
        public static List<int> FindMatches2(List<int> a, List<int> b)
        {
            // Initialize output.
            var output = new List<int>();

            // Walk the first list, each time through walk the second list. If a match is found record. Ignore matches if already in list.
            foreach (var acurr in a)
            {
                // Update instance count when a match is found.
                var binstancecount = 0;

                foreach (var bcurr in b)
                {
                    // Tracker.
                    // i | j | a[i] | a[j] | bInstanceCount | aInstanceCount | Output
                    if (acurr == bcurr)
                    {
                        // See how many previous matches we found, this tells us the instance index we are on in a.
                        var ainstancecount = output.Count(x => x == acurr);

                        // Determine if we add this match.
                        // If there are more b-instances than a-instances we need to add.
                        if (binstancecount >= ainstancecount)
                        {
                            output.Add(acurr);

                            // Once we add we are done.
                            break;
                        }

                        // Update the b instance count.
                        binstancecount++;
                    }
                }
            }

            // Return output.
            return output;
        }
    }
}
