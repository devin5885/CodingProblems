using System;
using CodingProblems.LinkedList.SingleLink.Helpers;

namespace CodingProblems.LinkedList.SingleLink.Reverse
{
    /// <summary>
    /// Implements Reverse
    /// </summary>
    public static class LinkedListSingleLinkReverse1Complete
    {
        /// <summary>
        /// Reverse the part of the list specified by startReverse and endReverse.
        /// </summary>
        /// <param name="top">The top of the list.</param>
        /// <param name="startReverse">The starting node to reverse. (Defaults to top)</param>
        /// <param name="endReverse">The end node to reverse. (Defaults to all)</param>
        public static void Reverse(ref LinkedListSingleLinkNode<int> top, LinkedListSingleLinkNode<int> startReverse = null, LinkedListSingleLinkNode<int> endReverse = null)
        {
            // Find start node & end of pre-nodes.
            LinkedListSingleLinkNode<int> preEnd = null;
            if (startReverse == null || startReverse == top)
            {
                startReverse = top;
            }
            else
            {
                // Find preEnd.
                var curr = top;
                LinkedListSingleLinkNode<int> currPre = null;
                while (curr != null && preEnd == null)
                {
                    if (curr == startReverse)
                        preEnd = currPre;

                    currPre = curr;
                    curr = curr.Next;
                }

                if (preEnd == null)
                    throw new ArgumentException("startReverse node not found.");

                // Detach.
                preEnd.Next = null;
            }

            // Find end node & start of post-nodes.
            LinkedListSingleLinkNode<int> postStart = null;
            if (endReverse != null)
            {
                var currEnd = startReverse;
                LinkedListSingleLinkNode<int> currEndPre = null;
                while (currEnd != null && postStart == null)
                {
                    if (currEnd == endReverse)
                        postStart = currEnd.Next;

                    currEndPre = currEnd;
                    currEnd = currEnd.Next;
                }

                // Detach.
                if (currEnd == null)
                    throw new ArgumentException("endReverse node not found.");

                // Back up one node.
                currEnd = currEndPre;

                // Detach.
                if (currEnd != null)
                    currEnd.Next = null;
            }

            // start will be new end.
            var newEndReversed = startReverse;

            // Reverse the appropriate part of the list.
            ReverseHelper(ref startReverse);

            // Reattach startReverse.
            if (preEnd != null)
                preEnd.Next = startReverse;
            // If no start, just update top.
            else
                top = startReverse;

            // Reattach end.
            if (newEndReversed != null)
                newEndReversed.Next = postStart;
        }

        /// <summary>
        /// Reverse the list.
        /// </summary>
        /// <param name="top">The top of the list.</param>
        private static void ReverseHelper(ref LinkedListSingleLinkNode<int> top)
        {
            // Initialize starting vars.
            LinkedListSingleLinkNode<int> prev = null;
            var curr = top;

            // Go through list.
            while (curr != null)
            {
                // Store next.
                var next = curr.Next;

                // Update
                curr.Next = prev;
                prev = curr;

                // Go to next.
                curr = next;

                // Update top.
                top = prev;
            }
        }
    }
}
