using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.Traverse.PostOrder
{
    /// <summary>
    /// Implements TraversePostOrder
    /// </summary>
    public static class BinaryTreeTraversePostOrder1RecursiveComplete
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

            TraversePostOrderHelper(binaryTree, result);
            return result;
        }

        /// <summary>
        /// Helper for TraversePostOrder.
        /// </summary>
        /// <param name="binaryTree">The binary tree.</param>
        /// <param name="postOrder">The resulting post-order list.</param>
        /// <typeparam name="T">Type for node data.</typeparam>
        private static void TraversePostOrderHelper<T>(BinaryTreeNode<T> binaryTree, List<T> postOrder)
            where T : IComparable
        {
            if (binaryTree == null)
                return;

            // Go left.
            if (binaryTree.Left != null)
                TraversePostOrderHelper(binaryTree.Left, postOrder);

            // Go right.
            if (binaryTree.Right != null)
                TraversePostOrderHelper(binaryTree.Right, postOrder);

            // Add this node.
            postOrder.Add(binaryTree.Value);
        }
    }
}
