using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;
using CodingProblems.BinaryTree.Traverse.Helpers;

namespace CodingProblems.BinaryTree.Traverse.PrePostInOrder
{
    /// <summary>
    /// Implements Traverse
    /// </summary>
    public static class BinaryTreeTraversePrePostInOrder2IterativeComplete
    {
        /// <summary>
        /// Traverses the tree iteratively and returns the nodes in the specified order.
        /// </summary>
        /// <param name="binaryTree">The tree.</param>
        /// <param name="traversalType">The traversal type.</param>
        /// <returns>The list of binaryTree values.</returns>
        /// <typeparam name="T">Type for binaryTree data.</typeparam>
        public static List<T> Traverse<T>(BinaryTreeNode<T> binaryTree, TraversalType traversalType)
            where T : IComparable
        {
            var result = new List<T>();
            TraverseHelper(binaryTree, traversalType, result);
            return result;
        }

        private static void TraverseHelper<T>(BinaryTreeNode<T> binaryTree, TraversalType traversalType, List<T> result)
            where T : IComparable
        {
            if (binaryTree == null)
                return;

            var stack = new Stack<TraversalNodeData<T>>();
            stack.Push(new TraversalNodeData<T>(binaryTree, TraversalNodeState.PreOrderPending));

            while(stack.Count > 0)
            {
                var curr = stack.Pop();

                switch(curr.NodeState)
                {
                    case TraversalNodeState.PreOrderPending:

                        if (traversalType == TraversalType.PreOrder)
                        {
                            result.Add(curr.Node.Value);
                        }
                        stack.Push(new TraversalNodeData<T>(curr.Node, TraversalNodeState.InOrderPending));

                        if (curr.Node.Left != null)
                            stack.Push(new TraversalNodeData<T>(curr.Node.Left, TraversalNodeState.PreOrderPending));

                        break;

                    case TraversalNodeState.InOrderPending:
                        if (traversalType == TraversalType.InOrder)
                        {
                            result.Add(curr.Node.Value);
                        }
                        stack.Push(new TraversalNodeData<T>(curr.Node, TraversalNodeState.PostOrderPending));

                        if (curr.Node.Right != null)
                            stack.Push(new TraversalNodeData<T>(curr.Node.Right, TraversalNodeState.PreOrderPending));

                        break;

                    case TraversalNodeState.PostOrderPending:
                        if (traversalType == TraversalType.PostOrder)
                        {
                            result.Add(curr.Node.Value);
                        }

                        break;

                    default:
                        throw new InvalidOperationException();
                }
            }
        }
    }
}
