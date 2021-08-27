using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems.Array_.StackOfBoxes
{
    /// <summary>
    /// Implements StackOfBoxesComplete.GetMaxHeight
    /// </summary>
    public static class StackOfBoxes1ComputeAndCountComplete
    {
        /// <summary>
        /// Gets the maximum height for the specified set of boxes.
        /// </summary>
        /// <param name="boxes">The array of boxes.</param>
        /// <returns>The maximum height possible.</returns>
        public static int GetMaxHeight(List<Box> boxes)
        {
            // Error checking.
            if (boxes == null)
                throw new ArgumentException("list of boxes must be specified.");

            // Generate the box combinations.

            // Start each stack with a single box.
            var resultStacks = new List<List<Box>>();
            foreach (var box in boxes)
                resultStacks.Add(new List<Box> { box });

            // Consume boxes.
            foreach (var box in boxes)
            {
                // Initialize the list of new stacks.
                var stacksCurr = new List<List<Box>>();

                // Build each new stack from an existing stack.
                foreach (var stack in resultStacks)
                {
                    // Initialize new stack.
                    var stackNew = new List<Box>(stack);

                    // Add this box.
                    // Note: Can't add the same box twice and can only add smaller box.
                    if (stackNew.IndexOf(box) == -1 && CanAdd(box, stackNew[stackNew.Count - 1]))
                    {
                        // Add this box.
                        stackNew.Add(box);

                        // Add the new stack to current list of stacks.
                        stacksCurr.Add(stackNew);
                    }
                }

                // Add these stacks to overall list of stacks.
                resultStacks.AddRange(stacksCurr);
            }

            // Return the maximum height.
            if (resultStacks.Count > 0)
                return resultStacks.Max(stack => stack.Sum(box => box.Height));
            else
                return 0;
        }

        private static bool CanAdd(Box box, Box boxPrev)
        {
            return box.Height < boxPrev.Height && box.Length < boxPrev.Length && box.Width < boxPrev.Width;
        }
    }
}