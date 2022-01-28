using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.IsFull
{
    /// <summary>
    /// Implements IsBinaryTreeFull
    /// </summary>
    public static class BinaryTreeIsFull1Complete
    {
        /// <summary>
        /// Determine if a binary tree is full.
        /// </summary>
        /// <param name="binaryTree">The tree</param>
        /// <returns>True if the tree is full, false otherwise.</returns>
        /// <typeparam name="T">Type for node data.</typeparam>
        public static bool IsFull<T>(BinaryTreeNode<T> binaryTree)
            where T : IComparable
        {
            // Check for null.
            if (binaryTree == null)
                return true;

            // Initialize the nodeQueue.
            var nodeQueue = new Queue<BinaryTreeNode<T>>();
            nodeQueue.Enqueue(binaryTree);

            // Check all levels.
            while (nodeQueue.Count > 0)
            {
                // Get the node.
                var node = nodeQueue.Dequeue();

                // Add left child.
                if (node.Left != null)
                {
                    nodeQueue.Enqueue(node.Left);

                    // If left is non-null, right must be non-null.
                    if (node.Right == null)
                        return false;
                }

                // Add right child.
                if (node.Right != null)
                {
                    nodeQueue.Enqueue(node.Right);

                    // If right is non-null, left must be non-null.
                    if (node.Left == null)
                        return false;
                }
            }

            // Tree is full.
            return true;
        }
    }
}
