using System;
using System.Collections.Generic;
using System.Reflection;
using CodingProblems.BinaryTree.Node;

// ReSharper disable InlineTemporaryVariable
namespace CodingProblems.BinaryTree.BSTFromPreOrderTraversal
{
    /// <summary>
    /// Implements FromPreOrderAndInOrderTraversals
    /// </summary>
    /// <typeparam name="T">Type for node data.</typeparam>
    public static class BSTFromPreOrderTraversal1RecursiveComplete<T>
        where T : IComparable
    {
        /// <summary>
        /// Builds the binary search tree from the pre-order traversal.
        /// </summary>
        /// <param name="preOrder">The pre-order traversal.</param>
        /// <returns>The in-order list of node values.</returns>
        public static BinaryTreeNode<T> BSTFromPreOrderTraversal(List<T> preOrder)
        {
            if (preOrder == null)
                return null;

            var fieldInfoMinValue = typeof(T).GetField("MinValue", BindingFlags.Public | BindingFlags.Static);
            var fieldInfoMaxValue = typeof(T).GetField("MaxValue", BindingFlags.Public | BindingFlags.Static);
            var index = 0;
            return BSTFromPreOrderTraversalHelper(preOrder, ref index, (T)fieldInfoMinValue?.GetValue(null), (T)fieldInfoMaxValue?.GetValue(null));
        }

        private static BinaryTreeNode<T> BSTFromPreOrderTraversalHelper(List<T> preOrder, ref int preOrderCurrIndex, T min, T max)
        {
            if (preOrderCurrIndex >= preOrder.Count)
                return null;

            if (preOrder[preOrderCurrIndex].CompareTo(min) < 0 || preOrder[preOrderCurrIndex].CompareTo(max) > 0)
                return null;

            // Create the node (Current node in the pre-order is node to be created).
            var newNode = new BinaryTreeNode<T>(preOrder[preOrderCurrIndex]);

            // Handle child nodes.
            preOrderCurrIndex++;
            newNode.Left = BSTFromPreOrderTraversalHelper(preOrder, ref preOrderCurrIndex, min, newNode.Value);
            newNode.Right = BSTFromPreOrderTraversalHelper(preOrder, ref preOrderCurrIndex, newNode.Value, max);

            // Return the new node.
            return newNode;
        }
    }
}
