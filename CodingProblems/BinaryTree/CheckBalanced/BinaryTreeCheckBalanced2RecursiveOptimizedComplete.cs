﻿using System;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.CheckBalanced
{
    /// <summary>
    /// Functionality for checking whether a binary tree is balanced.
    /// </summary>
    public static class BinaryTreeCheckBalanced2RecursiveOptimizedComplete
    {
        /// <summary>
        ///  Checks whether the specified binary tree is balanced.
        /// </summary>
        /// <typeparam name="T">The node type.</typeparam>
        /// <param name="node">The root node for the tree being checked.</param>
        /// <returns>True if the true is balanced, false otherwise.</returns>
        public static bool CheckBalanced2OptimizedComplete<T>(BinaryTreeNode<T> node)
            where T : IComparable
        {
            return CheckHeight(node) != -1;
        }

        /// <summary>
        ///  Checks whether the tree is balanced, if so returns the height, if not returns -1.
        /// </summary>
        /// <typeparam name="T">The node type.</typeparam>
        /// <param name="node">The root node for the tree being checked.</param>
        /// <returns>If the tree is balanced the actual height, -1 otherwise.</returns>
        public static int CheckHeight<T>(BinaryTreeNode<T> node)
            where T : IComparable
        {
            // If no sub-tree, return 0.
            if (node == null)
                return 0;

            // Get height of left sub-tree & return failure if not balanced.
            var leftHeight = CheckHeight(node.Left);
            if (leftHeight == -1)
               return -1;

            // Get height of right sub-tree & return failure if not balanced.
            var rightHeight = CheckHeight(node.Right);
            if (rightHeight == -1)
                return -1;

            // Check if current node is balanced.
            var heightDiff = leftHeight - rightHeight;

            // Failure, return -1.
            if (Math.Abs(heightDiff) > 1)
                return -1;
            // Return height.
            else
                return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
