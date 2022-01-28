using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.Traverse.InOrder
{
    /// <summary>
    /// Implements TraverseInOrder
    /// </summary>
    public static class BinaryTreeTraverseInOrder2IterativeComplete
    {
        /// <summary>
        /// Builds the in-order list.
        /// </summary>
        /// <param name="binaryTree">The tree.</param>
        /// <returns>The in-order list of node values.</returns>
        /// <typeparam name="T">Type for node data.</typeparam>
        public static List<T> TraverseInOrder<T>(BinaryTreeNode<T> binaryTree)
            where T : IComparable
        {
            // Initialize result.
            var result = new List<T>();

            // Check for null.
            if (binaryTree == null)
                return result;

            // Create stack.
            var st = new Stack<BinaryTreeNode<T>>();

            // Initialize current to binaryTree.
            var curr = binaryTree;

            // Continue while we have a current node or stacked nodes.
            while (curr != null || st.Count > 0)
            {
                // Stack & go left until out of left nodes.
                while (curr != null)
                {
                    st.Push(curr);
                    curr = curr.Left;
                }

                // Pop, visit & go right until out of right nodes.
                if (st.Count > 0)
                {
                    var temp = st.Pop();
                    result.Add(temp.Value);
                    curr = temp.Right;
                }
            }

            // Return the result.
            return result;
        }
    }
}
