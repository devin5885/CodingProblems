using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.Traverse.PreOrder
{
    /// <summary>
    /// Implements TraversePreOrder
    /// </summary>
    public static class BinaryTreeTraversePreOrder1RecursiveComplete
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

            TraversePreOrderHelper(binaryTree, result);
            return result;
        }

        /// <summary>
        /// Helper for TraversePreOrder.
        /// </summary>
        /// <param name="binaryTree">The binary tree.</param>
        /// <param name="preOrder">The resulting pre-order list.</param>
        /// <typeparam name="T">Type for node data.</typeparam>
        private static void TraversePreOrderHelper<T>(BinaryTreeNode<T> binaryTree, List<T> preOrder)
            where T : IComparable
        {
            if (binaryTree == null)
                return;

            // Add this node.
            preOrder.Add(binaryTree.Value);

            // Go left.
            if (binaryTree.Left != null)
                TraversePreOrderHelper(binaryTree.Left, preOrder);

            // Go right.
            if (binaryTree.Right != null)
                TraversePreOrderHelper(binaryTree.Right, preOrder);
        }
    }
}
