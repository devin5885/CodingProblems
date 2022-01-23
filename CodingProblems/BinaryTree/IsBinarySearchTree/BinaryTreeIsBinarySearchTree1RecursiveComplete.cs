using System;
using System.Reflection;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.IsBinarySearchTree
{
    /// <summary>
    /// Implements IsBinarySearchTree
    /// </summary>
    /// <typeparam name="T">Type for node data.</typeparam>
    public static class BinaryTreeIsBinarySearchTree1RecursiveComplete<T>
        where T : IComparable
    {
        /// <summary>
        /// Determine if a binary tree is a binary search tree.
        /// </summary>
        /// <param name="binaryTreeNode">The tree</param>
        /// <returns>True if the tree is a binary search tree, false otherwise.</returns>
        public static bool IsBinarySearchTree(BinaryTreeNode<T> binaryTreeNode)
        {
            var fieldInfoMinValue = typeof(T).GetField("MinValue", BindingFlags.Public | BindingFlags.Static);
            var fieldInfoMaxValue = typeof(T).GetField("MaxValue", BindingFlags.Public | BindingFlags.Static);
            return IsBinarySearchTreeHelper(binaryTreeNode, (T)fieldInfoMinValue?.GetValue(null), (T)fieldInfoMaxValue?.GetValue(null));
        }

        private static bool IsBinarySearchTreeHelper(BinaryTreeNode<T> node, T min, T max)
        {
            // Check for null.
            if (node == null)
                return true;

            if (node.Value.CompareTo(min) < 0 || node.Value.CompareTo(max) > 0)
                return false;

            // Check left children.
            if (node.Left != null)
                if (!IsBinarySearchTreeHelper(node.Left, min, node.Value))
                    return false;

            // Check right children.
            if (node.Right != null)
                if (!IsBinarySearchTreeHelper(node.Right, node.Value, max))
                    return false;

            // Is a BST.
            return true;
        }
    }
}
