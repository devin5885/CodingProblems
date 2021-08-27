using System;
using CodingProblems.LinkedList.SingleLink.Helpers;

namespace CodingProblems.LinkedList.SingleLink.FindIntersection
{
    /// <summary>
    /// Implements FindIntersection
    /// </summary>
    public static class LinkedListSingleLinkFindIntersection2OptimizedComplete
    {
        /// <summary>
        /// Find the first intersecting node between two lists.
        /// </summary>
        /// <param name="list1">The first list.</param>
        /// <param name="list2">The second list.</param>
        /// <returns>The first intersecting node or null if no intersection.</returns>
        public static LinkedListSingleLinkNode<int> FindIntersection(LinkedListSingleLinkNode<int> list1, LinkedListSingleLinkNode<int> list2)
        {
            // Error checks.
            if (list1 == null || list2 == null)
                return null;

            // Get the count of the first list.
            var count1 = 0;
            var last1 = list1;
            LinkedListSingleLinkNode<int> prev1 = null;
            while (last1 != null)
            {
                prev1 = last1;
                last1 = last1.Next;
                count1++;
            }

            // Get the count of the second list.
            var count2 = 0;
            var last2 = list2;
            LinkedListSingleLinkNode<int> prev2 = null;
            while (last2 != null)
            {
                prev2 = last2;
                last2 = last2.Next;
                count2++;
            }

            // See if the lists intersect.
            if (prev1 != prev2)
                return null;

            // Find intersection.
            var start1 = list1;
            var start2 = list2;

            // Adjust for non-matching counts.
            if (count1 != count2)
            {
                // Get difference.
                var countToMove = Math.Abs(count1 - count2);

                // Increment.
                if (count1 > count2)
                    for (var i = 0; i < countToMove; i++, start1 = start1.Next)
                    {
                    }
                else
                    for (var i = 0; i < countToMove; i++, start2 = start2.Next)
                    {
                    }
            }

            // Find intersection.
            while (start1 != start2)
            {
                start1 = start1.Next;
                start2 = start2.Next;
            }

            // Return intersection.
            return start1;
        }
    }
}
