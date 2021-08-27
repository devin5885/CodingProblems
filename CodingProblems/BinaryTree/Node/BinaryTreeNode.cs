namespace CodingProblems.BinaryTree.Node
{
    /// <summary>
    /// Class that represents a node in a binary tree.
    /// </summary>
    /// <typeparam name="T">The type for the node data.</typeparam>
    public class BinaryTreeNode<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryTreeNode{T}"/> class
        /// with the specified data.
        /// </summary>
        /// <param name="value">The value for the node.</param>
        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryTreeNode{T}"/> class
        /// with null data.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public BinaryTreeNode()
        {
        }

        /// <summary>
        /// Gets or sets gets the value stored by the node.
        /// </summary>
        /// <value>The value stored by the node.</value>
        public T Value { get; set; }

        /// <summary>
        /// Gets or sets gets the left child node of the node.
        /// </summary>
        /// <value>The left child node of the node.</value>
        public BinaryTreeNode<T> Left { get; set; }

        /// <summary>
        /// Gets or sets gets the right child node of the node.
        /// </summary>
        /// <value>The right child node of the node.</value>
        public BinaryTreeNode<T> Right { get; set; }
    }
}
