using CodingProblems.LinkedList.SingleLink.Helpers;

namespace CodingProblems.LinkedList.SingleLink.Partition
{
    /// <summary>
    /// Implements Partition.
    /// </summary>
    public static class LinkedListSingleLinkPartition2StableUseDummyNodesComplete
    {
        /// <summary>
        /// Partitions a list around a specified value in place.
        /// </summary>
        /// <param name="head">The head of the list.</param>
        /// <param name="x">The value to partition around.</param>
        public static void Partition(ref LinkedListSingleLinkNode<int> head, int x)
        {
            // Use dummy nodes to simply code.

            var beforeTop = new LinkedListSingleLinkNode<int>(-1);
            var beforeBottom = beforeTop;
            var afterTop = new LinkedListSingleLinkNode<int>(-1);
            var afterBottom = afterTop;

            var curr = head;
            while (curr != null)
            {
                // Store next & null out to prevent cycles.
                var next = curr.Next;
                curr.Next = null;

                // Add to appropriate list.
                if (curr.Value < x)
                {
                    // Update next pointer & bottom.
                    beforeBottom.Next = curr;
                    beforeBottom = curr;
                }
                else
                {
                    // Update next pointer & bottom.
                    afterBottom.Next = curr;
                    afterBottom = curr;
                }

                // Go to next.
                curr = next;
            }

            // Special case, if no before list, just use after list.
            // (Use .Next due to dummy node).
            if (beforeTop.Next == null)
            {
                head = afterTop.Next;
                return;
            }

            // Update head & attach the after list to the before list.
            // (Use .Next due to dummy node).
            head = beforeTop.Next;
            beforeBottom.Next = afterTop.Next;
        }
    }
}
