using System;

namespace CodingProblems.String_.Fibonacci
{
    /// <summary>
    /// Implements Fibonacci
    /// </summary>
    public static class Fibonacci3IterativeComplete
    {
        /// <summary>
        /// Get a Fibonacci number using recursion using iteration.
        /// </summary>
        /// <param name="index">The index of the number to retrieve.</param>
        /// <returns>The appropriate Fibonacci number.</returns>
        public static int Fibonacci(int index)
        {
            // Error checking.
            if (index < 0)
                throw new ArgumentException("Index must positive.");

            // Hard code 0.
            if (index == 0)
                return index;

            // Initialize defaults (Starting point).
            var resprev2 = 0;
            var resprev = 1;

            // Initialize result variable (Start at 1 for index 1)
            var res = 1;

            // Start at index 2, compute each result one by one (each loop calculates Fib(n)).
            for (var n = 2; n <= index; n++)
            {
                // Get this result.
                res = resprev + resprev2;

                // Inc for next loop.
                resprev2 = resprev;
                resprev = res;
            }

            // Return result.
            return res;
        }
    }
}