using System;
using System.Collections.Generic;

namespace CodingProblems.Stack.IsPalindrome
{
    /// <summary>
    /// Implements IsPalindromeUsingStacks
    /// </summary>
    public static class IsPalindromeUsingStacks1StandardComplete
    {
        /// <summary>
        /// Checks whether the input string is a palindrome.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>True if the input string is a palindrome.</returns>
        public static bool IsPalindromeUsingStacks(string input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException();

            // Build the forward stack.
            var stackForward = new Stack<char>();
            for (var i = 0; i < input.Length; i++)
            {
                stackForward.Push(input[i]);
            }

            // Build the backward stack.
            var stackBackward = new Stack<char>();
            for (var i = input.Length - 1; i >= 0; i--)
            {
                stackBackward.Push(input[i]);
            }

            // See if stacks match.
            while (stackForward.Count > 0)
            {
                var fwd = stackForward.Pop();
                var back = stackBackward.Pop();

                // Stacks don't match.
                if (fwd != back)
                    return false;
            }

            // Return result.
            return true;
        }
    }
}
