using System.Collections.Generic;
using CodingProblems.LinkedList.SingleLink.Helpers;

namespace CodingProblems.LinkedList.SingleLink.RemoveDuplicates
{
    /// <summary>
    /// Implements RemoveDuplicates.
    /// </summary>
    public static class LinkedListSingleRemoveDuplicates1HashSetComplete
    {
        /// <summary>
        /// Removes duplicate nodes from the list.
        /// </summary>
        /// <param name="head">A ref to the head node in the list.</param>
        public static void RemoveDuplicates(LinkedListSingleLinkNode<int> head)
        {
            // Initialize hash set.
            var values = new HashSet<int>();

            // Initialize initial values.
            LinkedListSingleLinkNode<int> prev = null;
            var curr = head;

            // Check each node.
            while (curr != null)
            {
                // Check if node is already there.
                if (values.Contains(curr.Value))
                {
                    // Delete this node.
                    // Note: previous can't be null for this algorithm
                    // since the first node cannot be a duplicate, but
                    // check to prevent ReSharper warning.
                    if (prev != null)
                        prev.Next = curr.Next;
                }
                else
                {
                    // Add new node.
                    values.Add(curr.Value);

                    // Note: Don't update previous in the delete case.
                    prev = curr;
                }

                // Go to next.
                curr = curr.Next;
            }
        }
    }
}
