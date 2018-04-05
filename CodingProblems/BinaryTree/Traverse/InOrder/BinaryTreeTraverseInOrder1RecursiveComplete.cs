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
        public static List<int> TraverseInOrder(BinaryTreeNode<int> binaryTree)
        {
            var result = new List<int>();
            TraverseInOrderHelper(binaryTree, result);
            return result;
        }

        /// <summary>
        /// Helper for TraverseInOrder.
        /// </summary>
        /// <param name="binaryTree">The binary tree.</param>
        /// <param name="inOrder">The resulting in-order list.</param>
        private static void TraverseInOrderHelper(BinaryTreeNode<int> binaryTree, List<int> inOrder)
        {
            if (binaryTree != null)
            {
                // Go left.
                TraverseInOrderHelper(binaryTree.Left, inOrder);

                // Add this node.
                inOrder.Add(binaryTree.Value);

                // Go right.
                TraverseInOrderHelper(binaryTree.Right, inOrder);
            }
        }
    }
}
