using CodingProblems.LinkedList.SingleLink.Helpers;

namespace CodingProblems.LinkedList.SingleLink.Partition
{
    /// <summary>
    /// Implements Partition.
    /// </summary>
    public static class LinkedListSingleLinkPartition3NonStableComplete
    {
        /// <summary>
        /// Partitions a list around a specified value in place.
        /// </summary>
        /// <param name="head">The head of the list.</param>
        /// <param name="x">The value to partition around.</param>
        public static void Partition(ref LinkedListSingleLinkNode<int> head, int x)
        {
            // Initialize new list links.
            LinkedListSingleLinkNode<int> headNew = null;
            LinkedListSingleLinkNode<int> tailNew = null;

            var curr = head;
            while (curr != null)
            {
                // Store next & null out to prevent cycles.
                var next = curr.Next;
                curr.Next = null;

                // Update new list initially.
                if (headNew == null)
                {
                    headNew = curr;
                    tailNew = curr;
                }
                else
                {
                    // Add to head.
                    if (curr.Value < x)
                    {
                        curr.Next = headNew;
                        headNew = curr;
                    }
                    // Add to tail.
                    else
                    {
                        tailNew.Next = curr;
                        tailNew = curr;
                    }
                }

                // Go to next.
                curr = next;
            }

            // Update head.
            head = headNew;
        }
    }
}
