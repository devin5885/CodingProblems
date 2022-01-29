using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;
using CodingProblems.BinaryTree.Traverse.Helpers;

namespace CodingProblems.BinaryTree.Traverse.PrePostInOrder
{
    /// <summary>
    /// Implements Traverse
    /// </summary>
    public static class BinaryTreeTraversePrePostInOrder1RecursiveComplete
    {
        /// <summary>
        /// Traverses the tree iteratively and returns the nodes in the specified order.
        /// </summary>
        /// <param name="binaryTree">The tree.</param>
        /// <param name="traversalType">The traversal type.</param>
        /// <returns>The in-order list of node values.</returns>
        /// <typeparam name="T">Type for node data.</typeparam>
        public static List<T> Traverse<T>(BinaryTreeNode<T> binaryTree, TraversalType traversalType)
            where T : IComparable
        {
            var result = new List<T>();
            TraverseHelper(binaryTree, traversalType, result);
            return result;
        }

        /// <summary>
        /// Helper for TraverseInOrder.
        /// </summary>
        /// <param name="binaryTree">The binary tree.</param>
        /// <param name="traversalType">The traversal type.</param>
        /// <param name="result">The resulting list.</param>
        /// <typeparam name="T">Type for node data.</typeparam>
        private static void TraverseHelper<T>(BinaryTreeNode<T> binaryTree, TraversalType traversalType, List<T> result)
            where T : IComparable
        {
            if (binaryTree == null)
                return;

            if (traversalType == TraversalType.PreOrder)
                result.Add(binaryTree.Value);

            if (binaryTree.Left != null)
                TraverseHelper(binaryTree.Left, traversalType, result);

            if (traversalType == TraversalType.InOrder)
                result.Add(binaryTree.Value);

            if (binaryTree.Right != null)
                TraverseHelper(binaryTree.Right, traversalType, result);

            if (traversalType == TraversalType.PostOrder)
                result.Add(binaryTree.Value);
        }
    }
}
