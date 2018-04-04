using System;
using CodingProblems.LinkedList.SingleLink.Helpers;

namespace CodingProblems.LinkedList.SingleLink.Split
{
    /// <summary>
    /// Implements Split
    /// </summary>
    public static class LinkedListSingleLinkSplit1BruteForceComplete
    {
        /// <summary>
        /// Split 'toSplit' the lists using the fast-pointer slow pointer method.
        /// If the list has an uneven number of elements remove the 'middle'
        /// element and return it in dropped.
        /// </summary>
        /// <param name="toSplit">The list to split.</param>
        /// <param name="resultA">The first half of the list.</param>
        /// <param name="resultB">The second half of the list.</param>
        /// <param name="dropped">The 'middle' element (null for even number of elements).</param>
        public static void Split(LinkedListSingleLinkNode<int> toSplit, out LinkedListSingleLinkNode<int> resultA, out LinkedListSingleLinkNode<int> resultB, out LinkedListSingleLinkNode<int> dropped)
        {
            // Start at toSplit.
            resultA = toSplit;
            resultB = toSplit;

            // dropped is null by default.
            dropped = null;

            // Set previous.
            LinkedListSingleLinkNode<int> prev = null;
            LinkedListSingleLinkNode<int> prev2 = null;

            // First get the count.
            int count = 0;
            var currCount = toSplit;
            while (currCount != null)
            {
                currCount = currCount.Next;
                count++;
            }

            // Get half count.
            var half = (count / 2) + (count % 2);

            // Advance to the appropriate location.
            for (int i = 0; i < half; i++)
            {
                prev2 = prev;
                prev = resultB;
                resultB = resultB.Next;
            }

            // Update dropped.
            if (count % 2 != 0)
                dropped = prev;

            // At this point resultA, resultB and dropped are set correctly
            // so we just need to do some additional cleanup.

            // For odd case, null prev2.
            if (dropped != null)
            {
                // Isolate the dropped element.
                dropped.Next = null;

                // For odd count prev2 points to the end of the first half of
                // the list so we need to null the next pointer.
                if (prev2 != null)
                    prev2.Next = null;
                // If no prev2 is null we have a single element list so just null resultA.
                else
                    resultA = null;
            }
            // For even case, null previous.
            else
            {
                // For even count prev points to the end of the first half of
                // the list so we need to null the next pointer.
                // Note: prev is null for empty list.
                if (prev != null)
                    prev.Next = null;
            }
        }
    }
}
