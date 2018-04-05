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
        public static List<int> TraversePreOrder(BinaryTreeNode<int> binaryTree)
        {
            var result = new List<int>();
            TraversePreOrderHelper(binaryTree, result);
            return result;
        }

        /// <summary>
        /// Helper for TraversePreOrder.
        /// </summary>
        /// <param name="binaryTree">The binary tree.</param>
        /// <param name="preOrder">The resulting pre-order list.</param>
        public static void TraversePreOrderHelper(BinaryTreeNode<int> binaryTree, List<int> preOrder)
        {
            if (binaryTree != null)
            {
                // Add this node.
                preOrder.Add(binaryTree.Value);

                // Go left.
                TraversePreOrderHelper(binaryTree.Left, preOrder);

                // Go right.
                TraversePreOrderHelper(binaryTree.Right, preOrder);
            }
        }
    }
}
