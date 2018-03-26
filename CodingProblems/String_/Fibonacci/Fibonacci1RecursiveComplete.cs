using System;

namespace CodingProblems.String_.Fibonacci
{
    /// <summary>
    /// Implements Fibonacci
    /// </summary>
    public static class Fibonacci1RecursiveComplete
    {
        /// <summary>
        /// Calculate Fibonacci numbers using simple recursion.
        /// </summary>
        /// <param name="index">The index of the number to retrieve.</param>
        /// <returns>The appropriate Fibonacci number.</returns>
        public static int Fibonacci(int index)
        {
            // Error checking.
            if (index < 0)
                throw new ArgumentException("Index must positive.");

            // Hard code first two entries.
            if (index <= 1)
                return index;

            // Handle additional entries.
            return Fibonacci(index - 2) + Fibonacci(index - 1);
        }
    }
}