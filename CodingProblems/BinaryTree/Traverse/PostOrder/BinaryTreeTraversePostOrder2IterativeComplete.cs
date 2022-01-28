using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.Traverse.PostOrder
{
    /// <summary>
    /// Implements TraversePreOrder
    /// </summary>
    public static class BinaryTreeTraversePostOrder2IterativeComplete
    {
        /// <summary>
        /// Builds the post-order list.
        /// </summary>
        /// <param name="binaryTree">The tree.</param>
        /// <returns>The post-order list of node values.</returns>
        /// <typeparam name="T">Type for node data.</typeparam>
        public static List<T> TraversePostOrder<T>(BinaryTreeNode<T> binaryTree)
            where T : IComparable
        {
            // Initialize result.
            var result = new List<T>();

            // Check for null.
            if (binaryTree == null)
                return result;

            // Create stack & push root.
            var st1 = new Stack<BinaryTreeNode<T>>();
            st1.Push(binaryTree);

            // Initialize second stack.
            var st2 = new Stack<BinaryTreeNode<T>>();

            // Continue while we have stacked nodes.
            while (st1.Count > 0)
            {
                // Pop & stack.
                var temp = st1.Pop();
                st2.Push(temp);

                // Push left & right.
                if (temp.Left != null)
                    st1.Push(temp.Left);

                if (temp.Right != null)
                    st1.Push(temp.Right);
            }

            // Use 2nd stack.
            while (st2.Count > 0)
                result.Add(st2.Pop().Value);

            // Return the result.
            return result;
        }
    }
}
