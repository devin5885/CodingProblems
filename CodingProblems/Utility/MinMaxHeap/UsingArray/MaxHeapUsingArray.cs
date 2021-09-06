using System;

namespace CodingProblems.Utility.MinMaxHeap.UsingArray
{
    /// <summary>
    ///  The generic MaxHeap class.
    /// </summary>
    /// <typeparam name="T">The type to store.</typeparam>
    public class MaxHeapUsingArray<T> : MinMaxHeapUsingArrayBase<T>
        where T : IComparable<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaxHeapUsingArray{T}"/> class.
        /// </summary>
        public MaxHeapUsingArray()
            : base(false)
        {
        }
    }
}
