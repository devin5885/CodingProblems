using CodingProblems.LinkedList.SingleLink.Helpers;

namespace CodingProblems.LinkedList.SingleLink.FindIntersection
{
    /// <summary>
    /// Implements FindIntersection
    /// </summary>
    public static class LinkedListSingleLinkFindIntersection1BruteForceComplete
    {
        /// <summary>
        /// Find the first intersecting node between two lists.
        /// </summary>
        /// <param name="list1">The first list.</param>
        /// <param name="list2">The second list.</param>
        /// <returns>The first intersecting node or null if no intersection.</returns>
        public static LinkedListSingleLinkNode<int> FindIntersection(LinkedListSingleLinkNode<int> list1, LinkedListSingleLinkNode<int> list2)
        {
            // Check all nodes in list 1.
            var curr1 = list1;
            while (curr1 != null)
            {
                // Compare all nodes in list 2.
                var curr2 = list2;
                while (curr2 != null)
                {
                    // If they match we are done.
                    if (curr1 == curr2)
                        return curr1;

                    // Advance.
                    curr2 = curr2.Next;
                }

                // Advance.
                curr1 = curr1.Next;
            }

            // No match.
            return null;
        }
    }
}
