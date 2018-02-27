using System;
using System.Collections.Generic;

namespace CodingProblems.Queue.Stacks
{
    /// <summary>
    /// Test class that implements a queue via two stacks.
    /// </summary>
    /// <typeparam name="T">The type of data to be stored in the queue.</typeparam>
    public class QueueViaStacks1SimpleComplete<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViaStacks1SimpleComplete{T}"/> class.
        /// </summary>
        public QueueViaStacks1SimpleComplete()
        {
            StackQueue = new Stack<T>();
        }

        /// <summary>
        /// Gets the count of items in the queue.
        /// </summary>
        /// <value>The count of elements in the queue.</value>
        public int Count => StackQueue.Count;

        /// <summary>
        /// Gets the internal stack used to store queued items.
        /// </summary>
        /// <value>The stack used to store queued items.</value>
        private Stack<T> StackQueue { get; }

        /// <summary>
        /// Enqueues an item.
        /// </summary>
        /// <param name="item">The item to enqueue.</param>
        public void Enqueue(T item)
        {
            StackQueue.Push(item);
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

            // Initialize temporary stack & copy to it.
            var stTemp = new Stack<T>();
            MoveStack(StackQueue, stTemp);

            // Pop for temp stack.
            T temp = stTemp.Pop();

            // Copy back to main stack.
            MoveStack(stTemp, StackQueue);

            // Return result.
            return temp;
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
            var stTemp = new Stack<T>();
            MoveStack(StackQueue, stTemp);

            // Pop for temp stack.
            T temp = stTemp.Peek();

            // Copy back to main stack.
            MoveStack(stTemp, StackQueue);

            // Return result.
            return temp;
        }

        /// <summary>
        /// Internal method to move elements from one stack to another. Pops
        /// the elements from the source stack and pushes them to the target.
        /// stack.
        /// </summary>
        /// <param name="stSource">The source stack.</param>
        /// <param name="stTarget">The target stack.</param>
        private void MoveStack(Stack<T> stSource, Stack<T> stTarget)
        {
            while (stSource.Count != 0)
                stTarget.Push(stSource.Pop());
        }
    }
}
