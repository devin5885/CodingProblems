using System;

namespace CodingProblems.Array_.SearchSortedNoSize
{
    /// <summary>
    /// Custom list class that does not have a Size operator.
    /// </summary>
    public class ListNoSize
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListNoSize"/> class.
        /// </summary>
        /// <param name="arraySource">The source Array.</param>
        public ListNoSize(int[] arraySource)
        {
            Array = new int[arraySource.Length];
            arraySource.CopyTo(Array, 0);
        }

        /// <summary>
        /// Gets the internal array.
        /// </summary>
        /// <value>The internal array.</value>
        private int[] Array { get; }

        /// <summary>
        /// Gets the element indicated by index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>The element at index or -1 if index is past the end of the Array.</returns>
        public int ElementAt(int index)
        {
            try
            {
                return Array[index];
            }
            catch
            {
                return -1;
            }
        }
    }
}
