using System;
using CodingProblems.LinkedList.SingleLink.Helpers;

namespace CodingProblems.LinkedList.SingleLink.Split
{
    /// <summary>
    /// Implements Split
    /// </summary>
    public static class LinkedListSingleLinkSplit2FastSlowComplete
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

            // End is fast pointer.
            var end = toSplit;

            // Set previous.
            LinkedListSingleLinkNode<int> prev = null;
            LinkedListSingleLinkNode<int> prev2 = null;

            // Strategy:  End is fast pointer, move to end.
            while (end != null)
            {
                // Move to next.
                prev2 = prev;
                prev = resultB;
                resultB = resultB.Next;
                end = end.Next;

                // Double move 'End'.
                if (end != null)
                {
                    end = end.Next;
                }
                // End of uneven list case.
                else
                {
                    dropped = prev;
                }
            }

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
