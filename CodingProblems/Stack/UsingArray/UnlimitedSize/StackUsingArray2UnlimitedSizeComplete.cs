using System;

namespace CodingProblems.Stack.UsingArray
{
    /// <summary>
    /// Implements a variable size stack using a fixed size arrays.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the stack.</typeparam>
    public class StackUsingArray2UnlimitedSizeComplete<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackUsingArray2UnlimitedSizeComplete{T}"/> class.
        /// </summary>
        public StackUsingArray2UnlimitedSizeComplete()
        {
            // Initialize stack.
            StackPointer = -1;
            Items = new T[0];
        }

        /// <summary>
        /// Gets the count of items in the stack.
        /// </summary>
        /// <value>The count of items in the stack.</value>
        public int Count => StackPointer + 1;

        /// <summary>
        /// Gets or sets the items array.
        /// </summary>
        /// <value>The items array.</value>
        private T[] Items { get; set; }

        /// <summary>
        /// Gets or sets the current stack index (Always points to the top item).
        /// </summary>
        /// <value>An integer indicating the current index in the array that defines the top of the stack.</value>
        private int StackPointer { get; set; }

        /// <summary>
        /// Pushes an item onto the stack. Allocates a new array if needed.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Push(T item)
        {
            // Error check.
            if (StackPointer >= Items.Length - 1)
            {
                var oldCount = Items.Length;

                // Double the count each time.
                var newCount = Items.Length == 0 ? 2 : Items.Length * 2;

                // Initialize new array.
                var itemsTemp = new T[newCount];
                Array.Copy(Items, itemsTemp, oldCount);
                Items = itemsTemp;
            }

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
