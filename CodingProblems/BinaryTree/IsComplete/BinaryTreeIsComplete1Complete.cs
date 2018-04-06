using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.IsComplete
{
    /// <summary>
    /// Implements IsBinaryTreeComplete
    /// </summary>
    public static class BinaryTreeIsComplete1Complete
    {
        /// <summary>
        /// Determine if a binary tree is Complete.
        /// </summary>
        /// <param name="binaryTree">The tree</param>
        /// <returns>True if the tree is complete, false otherwise.</returns>
        public static bool IsBinaryTreeComplete(BinaryTreeNode<int> binaryTree)
        {
            // Check for null.
            if (binaryTree == null)
                return true;

            // Initialize the nodeQueue.
            var nodeQueue = new Queue<BinaryTreeNode<int>>();
            nodeQueue.Enqueue(binaryTree);

            // Initialize flag for indicating that a non-full node was found.
            // Note that this is not reset when ending a level, this ensures
            // that non-full levels that are not the last level return false.
            var nonFullFound = false;

            // Check all levels.
            while (nodeQueue.Count > 0)
            {
                // Get the node.
                var node = nodeQueue.Dequeue();

                // Add left child.
                if (node.Left != null)
                {
                    // If we found a non-full node fail.
                    if (nonFullFound)
                        return false;

                    nodeQueue.Enqueue(node.Left);
                }
                // Non-full node fount.
                else
                {
                    nonFullFound = true;
                }

                // Add right child.
                if (node.Right != null)
                {
                    // If we found a non-full node fail.
                    if (nonFullFound)
                        return false;

                    nodeQueue.Enqueue(node.Right);
                }
                // Non-full node fount.
                else
                {
                    nonFullFound = true;
                }
            }

            // Tree is complete.
            return true;
        }
    }
}
