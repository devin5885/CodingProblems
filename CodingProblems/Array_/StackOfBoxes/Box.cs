using System;

namespace CodingProblems.Array_.StackOfBoxes
{
    /// <summary>
    /// Class that represents a box.
    /// </summary>
    public class Box
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Box"/> class.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public Box(int length, int width, int height)
        {
            // Error checking.
            if (length <= 0 || width <= 0 || height <= 0)
                throw new ArgumentException("Length, width, and height must be positive and greater than 0");

            // Initialize properties.
            Length = length;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>The length.</value>
        public int Length { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>The width.</value>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        public int Height { get; set; }
    }
}