﻿using System;
using System.Collections.Generic;

namespace CodingProblems.Utility.MinMaxHeap.UsingArray
{
    /// <summary>
    /// Base class for min and max heap classes.
    /// </summary>
    /// <typeparam name="T">The type to store.</typeparam>
    public class MinMaxHeapUsingArrayBase<T>
        where T : IComparable<T>
    {
        private readonly bool isMinHeap;
        private readonly List<T> heap;

        /// <summary>
        /// Initializes a new instance of the <see cref="MinMaxHeapUsingArrayBase{T}"/> class.
        /// </summary>
        /// <param name="isMinHeap">Whether this is a min-heap or a max-heap</param>
        public MinMaxHeapUsingArrayBase(bool isMinHeap)
        {
            this.isMinHeap = isMinHeap;
            heap = new List<T>
            {
                default
            };
        }

        /// <summary>
        ///  Inserts an item.
        /// </summary>
        /// <param name="item">The item to insert.</param>
        public void Insert(T item)
        {
            heap.Add(item);
            HeapifyUp(heap.Count - 1);
        }

        /// <summary>
        ///  Extracts the min or max item.
        /// </summary>
        /// <returns>The extracted element.</returns>
        public T Extract()
        {
            // Error check.
            if (heap.Count <= 1)
                throw new InvalidOperationException();

            var temp = heap[1];

            // Remove first element.
            Swap(1, heap.Count - 1);
            heap.RemoveAt(heap.Count - 1);

            // Heapify down.
            HeapifyDown(1);

            return temp;
        }

        /// <summary>
        ///  Extracts the min or max item.
        /// </summary>
        /// <returns>The min or max element w/o extracting.</returns>
        public T Peek()
        {
            // Error check.
            if (heap.Count <= 1)
                throw new InvalidOperationException();

            return heap[1];
        }

        /// <summary>
        ///  Gets the count of items in the heap.
        /// </summary>
        /// <returns>The count.</returns>
        public int Count()
        {
            return heap.Count - 1;
        }

        /// <summary>
        ///  Determine whether the heap is valid.
        /// </summary>
        /// <param name="index">The index to check.</param>
        /// <returns>True if valid, false otherwise.</returns>
        public bool CheckValid(int index = 1)
        {
            if (index > heap.Count)
                return true;

            var leftChildIndex = index * 2;
            var rightChildIndex = (index * 2) + 1;

            // Right Child valid.
            if (rightChildIndex < heap.Count)
            {
                if ((isMinHeap && heap[index].CompareTo(heap[rightChildIndex]) > 0) || // parent > index, right child invalid.
                    (!isMinHeap && heap[index].CompareTo(heap[rightChildIndex]) < 0)) // parent < index, right child invalid.
                    return false;
            }

            // Left Child valid.
            if (leftChildIndex < heap.Count)
            {
                if ((isMinHeap && heap[index].CompareTo(heap[leftChildIndex]) > 0) || // parent > index, right child invalid.
                    (!isMinHeap && heap[index].CompareTo(heap[leftChildIndex]) < 0)) // parent < index, right child invalid.
                    return false;
            }

            return CheckValid(leftChildIndex) && CheckValid(rightChildIndex);
        }

        /// <summary>
        ///  Get the internal heap for debugging and testing.. (Do not modify).
        /// </summary>
        /// <returns>The heap.</returns>
        public List<T> GetHeap()
        {
            return heap;
        }

        private void HeapifyUp(int index)
        {
            var parent = index / 2;
            if (parent <= 0)
                return;

            // ReSharper disable once InvertIf
            if ((isMinHeap && heap[parent].CompareTo(heap[index]) > 0) || // parent > index, swap for min.
                (!isMinHeap && heap[parent].CompareTo(heap[index]) < 0)) // parent < index, swap for max.
            {
                Swap(index, parent);
                // ReSharper disable once TailRecursiveCall
                HeapifyUp(parent);
            }
        }

        private void HeapifyDown(int index)
        {
            // If past end we are done.
            if (index >= heap.Count)
                return;

            var leftChildIndex = index * 2;
            var rightChildIndex = (index * 2) + 1;

            // If no children we are done.
            if (leftChildIndex >= heap.Count && rightChildIndex >= heap.Count)
                return;

            // Determine the child node to compare against.
            var childToCheck = -1;

            if (rightChildIndex < heap.Count)
            {
                childToCheck = ((isMinHeap && heap[rightChildIndex].CompareTo(heap[leftChildIndex]) < 0) ||
                               (!isMinHeap && heap[rightChildIndex].CompareTo(heap[leftChildIndex]) > 0))
                    ? rightChildIndex // r > l
                    : leftChildIndex; // r >= l
            }
            else if (leftChildIndex < heap.Count)
            {
                childToCheck = leftChildIndex;
            }

            if ((isMinHeap && heap[index].CompareTo(heap[childToCheck]) > 0) || // parent > index, swap for min.
                (!isMinHeap && heap[index].CompareTo(heap[childToCheck]) < 0)) // parent < index, swap for max.
            {
                Swap(index, childToCheck);
                HeapifyDown(childToCheck);
            }
        }

        /// <summary>
        /// Helper that swaps firstIndex and secondIndex in the input array.
        /// </summary>
        /// <param name="firstIndex">The first index.</param>
        /// <param name="secondIndex">The second index.</param>
        private void Swap(int firstIndex, int secondIndex)
        {
            var temp = heap[firstIndex];
            heap[firstIndex] = heap[secondIndex];
            heap[secondIndex] = temp;
        }
    }
}
