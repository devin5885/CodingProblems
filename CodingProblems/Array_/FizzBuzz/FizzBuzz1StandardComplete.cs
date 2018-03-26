using System;

namespace CodingProblems.Array_.FizzBuzz
{
    /// <summary>
    /// Implements FizzBuzz.
    /// </summary>
    public static class FizzBuzz1StandardComplete
    {
        /// <summary>
        /// Implement FizzBuzz.
        /// </summary>
        /// <param name="count">The end index.</param>
        /// <returns>The resulting string array.</returns>
        public static string[] FizzBuzz(int count)
        {
            // Error Checking.
            if (count < 0)
                throw new ArgumentException("Ending index must be a positive number.");

            // Initialize result.
            var result = new string[count];

            // Populate result.
            for (var i = 0; i < count; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result[i] = "FizzBuzz";
                else if (i % 3 == 0)
                    result[i] = "Fizz";
                else if (i % 5 == 0)
                    result[i] = "Buzz";
                else
                    result[i] = i.ToString();
            }

            // Return result.
            return result;
        }
    }
}
