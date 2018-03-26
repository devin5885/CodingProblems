using System;

namespace CodingProblems.String_.Fibonacci
{
    /// <summary>
    /// Implements Fibonacci
    /// </summary>
    public static class Fibonacci2RecursiveMemoizationComplete
    {
        /// <summary>
        /// Get a Fibonacci number using recursion with an array added for efficiency.
        /// </summary>
        /// <param name="index">The index of the number to retrieve.</param>
        /// <returns>The appropriate Fibonacci number.</returns>
        public static int Fibonacci(int index)
        {
            // Error checking.
            if (index < 0)
                throw new ArgumentException("Index must positive.");

            // Initialize intermediate values array.
            var results = new int[index + 1];

            // Store first two entries.
            results[0] = 0;

            if (index > 0)
                results[1] = 1;

            // Call helper.
            return FibonacciHelper(results, index);
        }

        /// <summary>
        /// Helper for Fibonacci.
        /// </summary>
        /// <param name="results">The temporary result array.</param>
        /// <param name="index">The index of the number to retrieve.</param>
        /// <returns>The appropriate Fibonacci number.</returns>
        private static int FibonacciHelper(int[] results, int index)
        {
            // Error checking.
            if (index < 0)
                throw new ArgumentException("Index must positive.");

            // Check for already generated.
            if (index < 2 || results[index] != 0)
                return results[index];

            // Calculate and store.
            results[index] = FibonacciHelper(results, index - 2) + FibonacciHelper(results, index - 1);
            return results[index];
        }
    }
}