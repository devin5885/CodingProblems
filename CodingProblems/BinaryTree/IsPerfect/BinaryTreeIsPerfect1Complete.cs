using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.IsPerfect
{
    /// <summary>
    /// Implements IsPerfect
    /// </summary>
    public static class BinaryTreeIsPerfect1Complete
    {
        /// <summary>
        /// Determine if a binary tree is perfect.
        /// </summary>
        /// <param name="binaryTree">The tree</param>
        /// <returns>True if the tree is perfect, false otherwise.</returns>
        public static bool IsPerfect(BinaryTreeNode<int> binaryTree)
        {
            // Check for null.
            if (binaryTree == null)
                return true;

            // Initialize the nodeList.
            var nodeList = new List<BinaryTreeNode<int>>
            {
                binaryTree
            };

            // Check all levels.
            var level = 1;
            while (nodeList.Count > 0)
            {
                var nodeListChildren = new List<BinaryTreeNode<int>>();

                foreach (var node in nodeList)
                {
                    // Add left child.
                    if (node.Left != null)
                        nodeListChildren.Add(node.Left);

                    // Add right child.
                    if (node.Right != null)
                        nodeListChildren.Add(node.Right);
                }

                // Determine the expected count of nodes.
                var countExpected = (int)Math.Pow(2, level);

                // Check for match, fail if no match.
                if (nodeListChildren.Count != 0 && nodeListChildren.Count != countExpected)
                    return false;

                // Continue to next level.
                nodeList = nodeListChildren;
                level++;
            }

            // Tree is perfect.
            return true;
        }
    }
}
