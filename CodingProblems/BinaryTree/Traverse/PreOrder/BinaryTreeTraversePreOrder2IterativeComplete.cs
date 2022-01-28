using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.Traverse.PreOrder
{
    /// <summary>
    /// Implements TraversePreOrder
    /// </summary>
    public static class BinaryTreeTraversePreOrder2IterativeComplete
    {
        /// <summary>
        /// Builds the pre-order list.
        /// </summary>
        /// <param name="binaryTree">The tree.</param>
        /// <returns>The pre-order list of node values.</returns>
        /// <typeparam name="T">Type for node data.</typeparam>
        public static List<T> TraversePreOrder<T>(BinaryTreeNode<T> binaryTree)
            where T : IComparable
        {
            // Initialize result.
            var result = new List<T>();

            // Check for null.
            if (binaryTree == null)
                return result;

            // Create stack & push root.
            var st = new Stack<BinaryTreeNode<T>>();
            st.Push(binaryTree);

            // Continue while we have stacked nodes.
            while (st.Count > 0)
            {
                // Pop & print.
                var temp = st.Pop();
                result.Add(temp.Value);

                // Push left & right.
                if (temp.Right != null)
                    st.Push(temp.Right);

                if (temp.Left != null)
                    st.Push(temp.Left);
            }

            // Return the result.
            return result;
        }
    }
}
