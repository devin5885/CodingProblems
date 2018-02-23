using System;

namespace CodingProblems.Stack.UsingArray
{
    /// <summary>
    /// Implements a fixed size stack using an fixed size array.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the stack.</typeparam>
    public class StackUsingArray1FixedSizeComplete<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackUsingArray1FixedSizeComplete{T}"/> class.
        /// </summary>
        /// <param name="capacity">The capacity of the stack.</param>
        public StackUsingArray1FixedSizeComplete(int capacity)
        {
            // Init stack.
            StackPointer = -1;
            Items = new T[capacity];
        }

        /// <summary>
        /// Gets the count of items in the stack.
        /// </summary>
        /// <value>The count of items in the stack.</value>
        public int Count => StackPointer + 1;

        /// <summary>
        /// Gets the items array.
        /// </summary>
        /// <value>The items array.</value>
        private T[] Items { get; }

        /// <summary>
        /// Gets or sets the current stack index (Always points to the top item).
        /// </summary>
        /// <value>An integer indicating the current index in the array that defines the top of the stack.</value>
        private int StackPointer { get; set; }

        /// <summary>
        /// Pushes an item onto the stack. Throws an InvalidOperationException if the stack is full.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Push(T item)
        {
            // Error check.
            if (StackPointer >= Items.Length - 1)
                throw new InvalidOperationException("No room on the stack.");

            // Push item.
            Items[++StackPointer] = item;
        }

        /// <summary>
        /// Pops (Removes and returns) an item from the stack. Throws an InvalidOperationException if the stack is empty.
        /// </summary>
        /// <returns>The item.</returns>
        public T Pop()
        {
            // Error check.
            if (StackPointer < 0)
                throw new InvalidOperationException("Stack empty.");

            // Return current item.
            return Items[StackPointer--];
        }

        /// <summary>
        /// Returns the item at the top of the stack. Throws an InvalidOperationException if the stack is empty.
        /// </summary>
        /// <returns>The item.</returns>
        public T Peek()
        {
            // Error check.
            if (StackPointer < 0)
                throw new InvalidOperationException("Stack empty.");

            // Return current item.
            return Items[StackPointer];
        }
    }
}
