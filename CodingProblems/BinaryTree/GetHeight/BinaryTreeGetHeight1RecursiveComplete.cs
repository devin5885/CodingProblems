using System;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.GetHeight
{
    /// <summary>
    /// Functionality for checking whether a binary tree is balanced.
    /// </summary>
    public static class BinaryTreeGetHeight1RecursiveComplete
    {
        /// <summary>
        /// Get the height of the tree.
        /// </summary>
        /// <typeparam name="T">The node type.</typeparam>
        /// <param name="node">The top node of the tree</param>
        /// <returns>The height as an int.</returns>
        public static int GetHeight1RecursiveComplete<T>(BinaryTreeNode<T> node)
        {
            if (node == null)
                return 0;

            // Get the longer of the heights & add one for this level.
            return Math.Max(GetHeight1RecursiveComplete(node.Left), GetHeight1RecursiveComplete(node.Right)) + 1;
        }
    }
}
