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
        public static List<int> TraversePostOrder(BinaryTreeNode<int> binaryTree)
        {
            var result = new List<int>();
            TraversePostOrderHelper(binaryTree, result);
            return result;
        }

        /// <summary>
        /// Helper for TraversePostOrder.
        /// </summary>
        /// <param name="binaryTree">The binary tree.</param>
        /// <param name="postOrder">The resulting post-order list.</param>
        public static void TraversePostOrderHelper(BinaryTreeNode<int> binaryTree, List<int> postOrder)
        {
            if (binaryTree != null)
            {
                // Go left.
                TraversePostOrderHelper(binaryTree.Left, postOrder);

                // Go right.
                TraversePostOrderHelper(binaryTree.Right, postOrder);

                // Add this node.
                postOrder.Add(binaryTree.Value);
            }
        }
    }
}
