using System;
using System.Collections.Generic;

namespace CodingProblems.Queue.Stacks
{
    /// <summary>
    /// Test class that implements a queue via two stacks.
    /// </summary>
    /// <typeparam name="T">The type of data to be stored in the queue.</typeparam>
    public class QueueViaStacks2OptimizedComplete<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViaStacks2OptimizedComplete{T}"/> class.
        /// </summary>
        public QueueViaStacks2OptimizedComplete()
        {
            StackOldestQueue = new Stack<T>();
            StackNewestQueue = new Stack<T>();
        }

        /// <summary>
        /// Gets the count of items in the queue.
        /// </summary>
        /// <value>The count of elements in the queue.</value>
        public int Count => StackOldestQueue.Count + StackNewestQueue.Count;

        /// <summary>
        /// Gets the internal stack used to store the oldest queued items.
        /// </summary>
        /// <value>The stack used to store oldest queued items.</value>
        private Stack<T> StackOldestQueue { get; }

        /// <summary>
        /// Gets the internal stack used to store the oldest queued items.
        /// </summary>
        /// <value>The stack used to store oldest queued items.</value>
        private Stack<T> StackNewestQueue { get; }

        /// <summary>
        /// Enqueues an item.
        /// </summary>
        /// <param name="item">The item to enqueue.</param>
        public void Enqueue(T item)
        {
            StackNewestQueue.Push(item);
        }

        /// <summary>
        /// Dequeues and returns the first item. If there are no items in the queue, throws an exception.
        /// </summary>
        /// <returns>The item.</returns>
        public T Dequeue()
        {
            // Check for empty queue.
            if (Count == 0)
                throw new InvalidOperationException();

            // Init temporary stack & copy to it.
            MoveStack();

            // Pop for temp stack.
            return StackOldestQueue.Pop();
        }

        /// <summary>
        /// Gets the first item in the queue w/o removing it. If there are no items in the queue, throws an exception.
        /// </summary>
        /// <returns>The item.</returns>
        public T Peek()
        {
            // Check for empty queue.
            if (Count == 0)
                throw new InvalidOperationException();

            // Init temporary stack & copy to it.
            MoveStack();

            // Pop for temp stack.
            return StackOldestQueue.Peek();
        }

        /// <summary>
        /// Internal method to move elements within the two internal stacks.
        /// </summary>
        private void MoveStack()
        {
            // If there are no items in the oldest item stack, move any items
            // from the newest item stack.
            if (StackOldestQueue.Count == 0)
                while (StackNewestQueue.Count != 0)
                    StackOldestQueue.Push(StackNewestQueue.Pop());
        }
    }
}
