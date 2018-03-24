using System;

namespace CodingProblems.Matrix.PaintFill
{
    /// <summary>
    /// Implements PaintFill1RecursiveComplete.PaintFill
    /// </summary>
    public static class PaintFill1RecursiveComplete
    {
        /// <summary>
        /// "Fills in" the specified cell and all adjoining cells that have
        /// the same color
        /// as the specified cell with newColor.
        /// </summary>
        /// <param name="image">The image to update.</param>
        /// <param name="rowIndex">The rowIndex index of the cell
        ///  to update.</param>
        /// <param name="columnIndex">The column index of the cell
        ///  to update.</param>
        /// <param name="newColor">The new color.</param>
        /// <returns>True if the cell was updated, false otherwise.</returns>
        public static bool PaintFill(int[,] image, int rowIndex, int columnIndex, int newColor)
        {
            // If the image is already updated to the new color, then nothing to do.
            if (image[rowIndex, columnIndex] == newColor)
                return false;

            return PaintFillHelper(image, rowIndex, columnIndex, image[rowIndex, columnIndex], newColor);
        }

        /// <summary>
        /// Helper for PaintFill that takes the oldColor as well and only
        ///  updates if the cell
        /// initially matches the old color.
        /// </summary>
        /// <param name="image">The image to update.</param>
        /// <param name="rowIndex">The rowIndex index of the cell to
        ///  update.</param>
        /// <param name="columnIndex">The column index of the cell to
        ///  update.</param>
        /// <param name="oldColor">The old color.</param>
        /// <param name="newColor">The new color.</param>
        /// <returns>True if the cell was updated, false otherwise.</returns>
        private static bool PaintFillHelper(int[,] image, int rowIndex, int columnIndex, int oldColor, int newColor)
        {
            // Check for valid rowIndex.
            if (rowIndex < 0 || rowIndex >= image.GetLength(0))
                return false;

            // Check for valid columnIndex.
            if (columnIndex < 0 || columnIndex >= image.GetLength(1))
                return false;

            // Check whether this cell needs to be updated.
            if (image[rowIndex, columnIndex] != oldColor)
                return false;

            // Update this cell.
            image[rowIndex, columnIndex] = newColor;

            // Row above.
            // Note: Ignore return value.
            PaintFillHelper(image, rowIndex - 1, columnIndex - 1, oldColor, newColor);
            PaintFillHelper(image, rowIndex - 1, columnIndex, oldColor, newColor);
            PaintFillHelper(image, rowIndex - 1, columnIndex + 1, oldColor, newColor);

            // Same rowIndex.
            // Note: Ignore return value.
            PaintFillHelper(image, rowIndex, columnIndex - 1, oldColor, newColor);
            PaintFillHelper(image, rowIndex, columnIndex + 1, oldColor, newColor);

            // Row below.
            // Note: Ignore return value.
            PaintFillHelper(image, rowIndex + 1, columnIndex - 1, oldColor, newColor);
            PaintFillHelper(image, rowIndex + 1, columnIndex, oldColor, newColor);
            PaintFillHelper(image, rowIndex + 1, columnIndex + 1, oldColor, newColor);

            // Updated.
            return true;
        }
    }
}