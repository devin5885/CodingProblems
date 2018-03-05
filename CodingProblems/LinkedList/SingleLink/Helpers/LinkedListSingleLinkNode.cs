using System.Text;

namespace CodingProblems.LinkedList.SingleLink.Helpers
{
    /// <summary>
    /// Definition for singly-linked list.
    ///  Note: Helper methods should only be used to create test data not for coding problems.
    /// </summary>
    /// <typeparam name="T">The type to store in the node.</typeparam>
    public class LinkedListSingleLinkNode<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListSingleLinkNode{T}"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="next">A ref to the next node in the list.</param>
        public LinkedListSingleLinkNode(T value = default(T), LinkedListSingleLinkNode<T> next = null)
        {
            Value = value;
            Next = next;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public T Value { get; set; }

        /// <summary>
        /// Gets or sets the ref to the next node.
        /// </summary>
        /// <value>A ref to the next node.</value>
        public LinkedListSingleLinkNode<T> Next { get; set; }

        /// <summary>
        /// Creates a list of nodes from a list of type-T objects and returns the node at
        /// the head of the list.
        /// </summary>
        /// <param name="list">The list of type-T objects.</param>
        /// <returns>The first node in the resulting list.</returns>
        public static LinkedListSingleLinkNode<T> CreateFromData(params T[] list)
        {
            // Error handling.
            if (list == null)
                return null;

            // Create references.
            LinkedListSingleLinkNode<T> top = null;
            LinkedListSingleLinkNode<T> prev = null;

            // Add all nodes.
            foreach (var item in list)
            {
                // Initialize new node.
                var toAdd = new LinkedListSingleLinkNode<T>(item);

                // If no top yet, set toAdd to top.
                if (top == null)
                    top = toAdd;

                // Link new node to previous node.
                if (prev != null)
                    prev.Next = toAdd;

                // Update previous to point to newly added node.
                prev = toAdd;
            }

            // Return the top node.
            return top;
        }

        /// <summary>
        /// Compares two lists to determine if they have the same contents.
        ///
        /// When comparing each node in the first list will be compared to
        /// the corresponding node in the second list. The nodes will be
        /// considered matching if the value of both nodes match. (Value
        /// equals comparison).
        /// </summary>
        /// <param name="list1">The first list to compare.</param>
        /// <param name="list2">The second list to compare.</param>
        /// <returns>True if the lists match, false otherwise.</returns>
        public static bool Compare(LinkedListSingleLinkNode<T> list1, LinkedListSingleLinkNode<T> list2)
        {
            // Initialize references.
            var curr1 = list1;
            var curr2 = list2;

            // Walk lists.
            while (curr1 != null)
            {
                // Make sure curr2 is still valid.
                if (curr2 == null)
                    return false;

                // Compare elements.
                if (!Equals(curr1.Value, curr2.Value))
                    return false;

                // Advance.
                curr1 = curr1.Next;
                curr2 = curr2.Next;
            }

            // Check for List 2 having more elements.
            if (curr2 != null)
                return false;

            // Match.
            return true;
        }

        /// <summary>
        /// ToString override that displays the list of nodes.
        /// </summary>
        /// <returns>The string</returns>
        public override string ToString()
        {
            var res = new StringBuilder();
            var curr = this;
            while (curr != null)
            {
                if (res.Length != 0)
                    res.Append(", ");

                res.Append(curr.Value);
                curr = curr.Next;
            }

            return res.ToString();
        }
    }
}
