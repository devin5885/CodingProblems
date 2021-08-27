using System;

namespace CodingProblems.Matrix.Rotate
{
    /// <summary>
    /// Implements Matrix.Rotate.
    /// </summary>
    public class MatrixRotate1Complete
    {
        /// <summary>
        /// Rotates the specified matrix clockwise by 90 degrees.
        /// </summary>
        /// <param name="matrix">The matrix to rotate.</param>
        public static void Rotate(ref int[,] matrix)
        {
            // Error check.
            if (matrix == null)
                throw new ArgumentException();

            // Determine the matrix size.
            var n = matrix.GetLength(0);

            // Handle all rings one by one.
            for (var ring = 0; ring < n / 2; ring++)
            {
                // 'startrowcol' is the first col/row index in the ring

                // 'endrowcol' is the last col/row index in the ring.
                var endrowcol = n - 1 - ring;

                // We need to rotate all elements in the start row except the
                // last (i.e.) endrowcol.
                // leftrowcol starts at startrowcol & moves upward until endrowcol.
                // Note that left refers to the starting side of the row in the
                // top row of the ring.
                for (var leftrowcol = ring; leftrowcol < endrowcol; ++leftrowcol)
                {
                    // rightrowcol starts at startrowcol + endrowcol & moves downward.
                    // Note that right refers to the starting side of the row in the
                    // top row of the ring.
                    // 1 for first loop.
                    // 2 for second loop etc.
                    var rightrowcol = endrowcol + ring - leftrowcol;

                    // 0. store top, left value.
                    // R0, C0 to Temp for 2x2 matrix.
                    // R0, C0 to Temp for 3x3 matrix first loop.
                    // R0, C1 to Temp for 3x3 matrix second loop.
                    var topleft = matrix[ring, leftrowcol];

                    // 1. move bottom, left value to top, left.
                    // R1, C0 to R0, C0 for 2x2 matrix.
                    // R2, C0 to R0, C0 for 3x3 matrix first loop.
                    // R1, C0 to R0, C1 for 3x3 matrix second loop.
                    matrix[ring, leftrowcol] = matrix[rightrowcol, ring];

                    // 2. move bottom, right to bottom, left.
                    // R1, C1 to R1, C0 for 2x2 matrix.
                    // R2, C2 to R2, C0 for 3x3 matrix first loop.
                    // R2, C1 to R1, C0 for 3x3 matrix second loop.
                    matrix[rightrowcol, ring] = matrix[endrowcol, rightrowcol];

                    // 3. bottom, right to top, right.
                    // R0, C1 to R1, C1 for 2x2 matrix.
                    // R0, C2 to R2, C2 for 3x3 matrix first loop.
                    // R1, C2 to R2, C1 for 3x3 matrix second loop.
                    matrix[endrowcol, rightrowcol] = matrix[leftrowcol, endrowcol];

                    // 4. top, right to top, left.
                    // Temp to R0, C1 for 2x2 matrix.
                    // Temp to R0, C2 for 2x2 matrix first loop.
                    // Temp to R1, C2 for 2x2 matrix second loop.
                    matrix[leftrowcol, endrowcol] = topleft;
                }
            }
        }
    }
}
