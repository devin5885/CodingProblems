using System;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.Helpers.CompareBinaryTreeHelpers
{
    /// <summary>
    /// Helpers for comparing binary trees.
    /// </summary>
    public static class CompareBinaryTreeHelpers
    {
        /// <summary>
        ///  Compares two binary trees.
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="tree1">First tree.</param>
        /// <param name="tree2">Second tree.</param>
        /// <returns>True if the trees, match false otherwise.</returns>
        public static bool CompareBinaryTrees<T>(BinaryTreeNode<T> tree1, BinaryTreeNode<T> tree2)
            where T : IComparable
        {
            // Check for nulls.
            if (tree1 == null && tree2 != null)
                return false;

            if (tree2 == null && tree1 != null)
                return false;

            // Both null.
            if (tree2 == null)
                return true;

            // Check values.
            if (tree1.Value.CompareTo(tree2.Value) != 0)
                return false;

            // Compare Sub-Trees.
            if (!CompareBinaryTrees(tree1.Left, tree2.Left))
                return false;

            if (!CompareBinaryTrees(tree1.Right, tree2.Right))
                return false;

            // Match.
            return true;
        }
    }
}
