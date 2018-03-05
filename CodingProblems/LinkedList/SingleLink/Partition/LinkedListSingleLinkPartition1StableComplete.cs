using CodingProblems.LinkedList.SingleLink.Helpers;

namespace CodingProblems.LinkedList.SingleLink.Partition
{
    /// <summary>
    /// Implements Partition.
    /// </summary>
    public static class LinkedListSingleLinkPartition1StableComplete
    {
        /// <summary>
        /// Partitions a list around a specified value in place.
        /// </summary>
        /// <param name="head">The head of the list.</param>
        /// <param name="x">The value to partition around.</param>
        public static void Partition(ref LinkedListSingleLinkNode<int> head, int x)
        {
            LinkedListSingleLinkNode<int> beforeTop = null;
            LinkedListSingleLinkNode<int> beforeBottom = null;
            LinkedListSingleLinkNode<int> afterTop = null;
            LinkedListSingleLinkNode<int> afterBottom = null;

            var curr = head;
            while (curr != null)
            {
                // Store next & null out to prevent cycles.
                var next = curr.Next;
                curr.Next = null;

                // Add to appropriate list.
                if (curr.Value < x)
                {
                    // If at top of list, just assign current to top.
                    if (beforeTop == null)
                        beforeTop = curr;
                    // If not at beginning of list, need to update next pointer.
                    else
                        beforeBottom.Next = curr;

                    // Always update bottom.
                    beforeBottom = curr;
                }
                else
                {
                    // If at top of list, just assign current to top.
                    if (afterTop == null)
                        afterTop = curr;
                    // If not at beginning of list, need to update next pointer.
                    else
                        afterBottom.Next = curr;

                    // Always update bottom.
                    afterBottom = curr;
                }

                // Go to next.
                curr = next;
            }

            // Special case, if no before list, just use after list.
            if (beforeTop == null)
            {
                head = afterTop;
                return;
            }

            // Update head & attach the after list to the before list.
            head = beforeTop;
            beforeBottom.Next = afterTop;
        }
    }
}
