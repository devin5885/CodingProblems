using System;

namespace CodingProblems.Utility.MinMaxHeap.UsingArray
{
    /// <summary>
    ///  The generic MinHeap class.
    /// </summary>
    /// <typeparam name="T">The type to store.</typeparam>
    public class MinHeapUsingArray<T> : MinMaxHeapUsingArrayBase<T>
        where T : IComparable<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinHeapUsingArray{T}"/> class.
        /// </summary>
        public MinHeapUsingArray()
            : base(true)
        {
        }
    }
}
