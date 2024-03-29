﻿using System;

namespace CodingProblems.MultipleStacksUsingSingleArray
{
    /// <summary>
    /// Implements a fixed size stack using an fixed size array.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the stack.</typeparam>
    public class MultipleStacksUsingSingleArray1FixedSizeComplete<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleStacksUsingSingleArray1FixedSizeComplete{T}"/> class.
        /// </summary>
        /// <param name="capacityPerStack">The capacity of the individual stacks.</param>
        /// <param name="stackCount">The # of stacks to create.</param>
        public MultipleStacksUsingSingleArray1FixedSizeComplete(int capacityPerStack, int stackCount = 3)
        {
            // Store stack count.
            StackCount = stackCount;

            // Initialize StackPointer array.
            StackPointer = new int[stackCount];
            for (var i = 0; i < StackPointer.Length; i++)
                StackPointer[i] = -1;

            // Initialize StackPointerOffset array.
            StackPointerOffset = new int[stackCount];
            for (var i = 0; i < StackPointerOffset.Length; i++)
                StackPointerOffset[i] = capacityPerStack * i;

            // Initialize stack.
            Items = new T[capacityPerStack * stackCount];
        }

        /// <summary>
        /// Gets the items array.
        /// </summary>
        /// <value>The items array.</value>
        private T[] Items { get; }

        /// <summary>
        /// Gets the count of stacks.
        /// </summary>
        /// <value>The # of stacks.</value>
        private int StackCount { get; }

        /// <summary>
        /// Gets the current stack pointer. (Always points to the top item).
        ///
        /// Note that StackPointer must be adjusted by the StackPointerOffset to be accurate.
        /// </summary>
        /// <value>An integer indicating the current index in the array that defines the top of the stack.</value>
        private int[] StackPointer { get; }

        /// <summary>
        /// Gets the stack pointer offset for that stack.
        /// The offset indicates the starting item for the stack.
        /// </summary>
        /// <value>An integer indicating the starting index for the particular stack.</value>
        private int[] StackPointerOffset { get; }

        /// <summary>
        /// Gets the count of items in the specified stack.
        /// </summary>
        /// <param name="stackNumber">The stack number.</param>
        /// <returns>The count.</returns>
        public int Count(int stackNumber)
        {
            // Error check.
            if (stackNumber < 0 || stackNumber >= StackCount)
                throw new ArgumentException("Invalid Stack Number Specified.");

            return StackPointer[stackNumber] + 1;
        }

        /// <summary>
        /// Pushes an item onto the stack. Throws an InvalidOperationException if the stack is full.
        /// </summary>
        /// <param name="stackNumber">The stack.</param>
        /// <param name="item">The item.</param>
        public void Push(int stackNumber, T item)
        {
            // Error check.
            if (stackNumber < 0 || stackNumber >= StackCount)
                throw new ArgumentException("Invalid Stack Number Specified.");

            // Error check.
            if (StackPointer[stackNumber] >= (Items.Length - 1) / StackCount)
                throw new InvalidOperationException("No room on the stack.");

            // Push item.
            Items[++StackPointer[stackNumber] + StackPointerOffset[stackNumber]] = item;
        }

        /// <summary>
        /// Pops (Removes and returns) an item from the stack. Throws an InvalidOperationException if the stack is empty.
        /// </summary>
        /// <param name="stackNumber">The stack.</param>
        /// <returns>The item.</returns>
        public T Pop(int stackNumber)
        {
            // Error check.
            if (stackNumber < 0 || stackNumber >= StackCount)
                throw new ArgumentException("Invalid Stack Number Specified.");

            // Error check.
            if (StackPointer[stackNumber] < 0)
                throw new InvalidOperationException("Stack empty.");

            // Return current item.
            return Items[(StackPointer[stackNumber]--) + StackPointerOffset[stackNumber]];
        }

        /// <summary>
        /// Returns the item at the top of the stack. Throws an InvalidOperationException if the stack is empty.
        /// </summary>
        /// <param name="stackNumber">The stack.</param>
        /// <returns>The item.</returns>
        public T Peek(int stackNumber)
        {
            // Error check.
            if (stackNumber < 0 || stackNumber >= StackCount)
                throw new ArgumentException("Invalid Stack Number Specified.");

            // Error check.
            if (StackPointer[stackNumber] < 0)
                throw new InvalidOperationException("Stack empty.");

            // Return current item.
            return Items[StackPointer[stackNumber] + StackPointerOffset[stackNumber]];
        }
    }
}
