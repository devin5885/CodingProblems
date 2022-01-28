using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;

// ReSharper disable InlineTemporaryVariable
namespace CodingProblems.BinaryTree.BinaryTreeFromPreOrderAndInOrderTraversals
{
    /// <summary>
    /// Implements FromPreOrderAndInOrderTraversals
    /// </summary>
    /// <typeparam name="T">Type for node data.</typeparam>
    public static class BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<T>
        where T : IComparable
    {
        /// <summary>
        /// Builds the binary tree from the pre-order and in-order traversals.
        /// </summary>
        /// <param name="preOrder">The pre-order traversal.</param>
        /// <param name="inOrder">The in-order traversal.</param>
        /// <returns>The in-order list of node values.</returns>
        public static BinaryTreeNode<T> FromPreOrderAndInOrderTraversals(List<T> preOrder, List<T> inOrder)
        {
            if (preOrder == null || inOrder == null || preOrder.Count == 0 || inOrder.Count == 0)
                return null;

            return FromPreOrderAndInOrderTraversalsHelper(inOrder, 0, inOrder.Count - 1, preOrder, 0, preOrder.Count - 1);
        }

        private static BinaryTreeNode<T> FromPreOrderAndInOrderTraversalsHelper(List<T> inOrder, int inOrderStartIndex, int inOrderEndIndex, List<T> preOrder, int preOrderStartIndex, int preOrderEndIndex)
        {
            // Create the node (Current node in the pre-order is node to be created).
            var newNode = new BinaryTreeNode<T>(preOrder[preOrderStartIndex]);

            // Find the corresponding node in the InOrder sequence.
            var inOrderIndexNext = inOrder.IndexOf(preOrder[preOrderStartIndex]);

            // Determine the indexes of the elements to the left of the current node in the InOrder sequence.
            var newInOrderStartLeft = inOrderStartIndex;
            var newInOrderEndLeft = inOrderIndexNext - 1;
            var newLeftSize = newInOrderEndLeft - newInOrderStartLeft + 1;

            // Determine the indexes of the elements to the right of the current node in the InOrder sequence.
            var newInOrderStartRight = inOrderIndexNext + 1;
            var newInOrderEndRight = inOrderEndIndex;
            var newRightSize = newInOrderEndRight - newInOrderStartRight + 1;

            // Determine the corresponding indexes in the preOrder sequence on the right.
            var newPreOrderStartLeft = preOrderStartIndex + 1;
            var newPreOrderEndLeft = preOrderStartIndex + newLeftSize;

            // Determine the corresponding indexes in the preOrder sequence on the left.
            var newPreOrderStartRight = newPreOrderEndLeft + 1;
            var newPreOrderEndRight = preOrderEndIndex;

            // Handle child nodes.
            if (newLeftSize > 0)
                newNode.Left = FromPreOrderAndInOrderTraversalsHelper(inOrder, newInOrderStartLeft, newInOrderEndLeft, preOrder, newPreOrderStartLeft, newPreOrderEndLeft);

            if (newRightSize > 0)
                newNode.Right = FromPreOrderAndInOrderTraversalsHelper(inOrder, newInOrderStartRight, newInOrderEndRight, preOrder, newPreOrderStartRight, newPreOrderEndRight);

            // Return the new node.
            return newNode;
        }
    }
}
