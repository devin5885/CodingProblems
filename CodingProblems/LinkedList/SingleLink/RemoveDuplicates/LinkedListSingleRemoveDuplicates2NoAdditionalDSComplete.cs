using CodingProblems.LinkedList.SingleLink.Helpers;

namespace CodingProblems.LinkedList.SingleLink.RemoveDuplicates
{
    /// <summary>
    /// Implements RemoveDuplicates.
    /// </summary>
    public static class LinkedListSingleRemoveDuplicates2NoAdditionalDSComplete
    {
        /// <summary>
        /// Removes duplicate nodes from the list.
        /// </summary>
        /// <param name="head">A ref to the head node in the list.</param>
        public static void RemoveDuplicates(LinkedListSingleLinkNode<int> head)
        {
            // Initialize ref to node being checked.
            var currToCheck = head;

            // Check all nodes.
            while (currToCheck != null)
            {
                // Initialize refs to nodes being
                // checked against current node.
                // Skip the node we are checking.
                var prev = currToCheck;
                var curr = currToCheck.Next;

                // If there is a node to check, check it.
                while (curr != null)
                {
                    // If the nodes values match, remove the
                    // node.
                    if (curr.Value == currToCheck.Value)
                        prev.Next = curr.Next;
                    // Otherwise just go to next.
                    else
                        prev = curr;

                    // Go to next.
                    curr = curr.Next;
                }

                // Go to next node to check.
                currToCheck = currToCheck.Next;
            }
        }
    }
}
