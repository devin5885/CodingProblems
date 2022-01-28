using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.Traverse.InOrder
{
    /// <summary>
    /// Implements TraversePostOrder
    /// </summary>
    public static class BinaryTreeTraverseInOrder1RecursiveComplete
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
            var result = new List<T>();

            if (binaryTree == null)
                return result;

            TraverseInOrderHelper(binaryTree, result);
            return result;
        }

        /// <summary>
        /// Helper for TraverseInOrder.
        /// </summary>
        /// <param name="binaryTree">The binary tree.</param>
        /// <param name="inOrder">The resulting in-order list.</param>
        /// <typeparam name="T">Type for node data.</typeparam>
        private static void TraverseInOrderHelper<T>(BinaryTreeNode<T> binaryTree, List<T> inOrder)
            where T : IComparable
        {
            if (binaryTree == null)
                return;

            // Go left.
            if (binaryTree.Left != null)
                TraverseInOrderHelper(binaryTree.Left, inOrder);

            // Add this node.
            inOrder.Add(binaryTree.Value);

            if (binaryTree.Right != null)
                TraverseInOrderHelper(binaryTree.Right, inOrder);
        }
    }
}
