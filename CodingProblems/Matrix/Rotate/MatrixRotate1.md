# Solution 1 - Standard

## Requirements

## Implementation
Note: n is the # of rows & columns for the matrix.

Split matrix into rings. A ring is the union of elements from two separate 
rows and two separate columns (or in the case of a matrix with an odd #
of columns/rows a single element in the middle of the matrix). A ring
 forms a 'square' of 1, 4, 8, 12 etc. columns. Thus, a ring has a start
& end column.

For a even # of rows/cols, there are n/2 rings that contain more than one
 element & thus need to be rotated. For an odd # of columns there
are n/2 + 1 layers, however since the inner-most layer contains a single element it
does not need to be rotated. Thus, we always need to process n/2 rings.

Process in each ring, in each ring process 4 elements at a time, moving the
 elements appropriately.

Move each group of four elements starting with storing the upper left value in
 a temp variable & moving the lower-left element into to old location of the
upper left value then continuing counter clockwise so that the element being
 moved replaces the previously moved element. Finally replace the upper right
element with the element in the temp variable. (See below)

### Rotate

Steps:
1. Check whether the passed in matrix is null, if so throw an appropriate exception.
2. Process each ring starting with the outermost ring (0) to the n/2 ring.
3. Store the start row/col index for the layer, this is the same as the layer #.
4. Store the end row/col index for the layer, this is n - 1 - the layer #.
5. Iterate over a right row/col variable which starts as start row/col, increases
by 1 per loop & ends at end row/col (not including end row/col).
6. Calculate a left row/col variable which is end row/col + start row/col
- right row/col, thus this variable decreases as left row/col increases. Note
that to calculate this variable we need to add start row/col + end row/col, this
is because right row/col starts on start/row col & we want to start on end row/col
 so we need to consider start row/col (not just subtract from end row/col) to 
get the correct starting col.
7. Use start row/col, end row/col, left row/col, and right row/col to move
the 4 elements during the loop:
First: Row: start row/col, Column: left row/col to temp.
Second: Row: right row/col, Column: start row/col to First.
Third: Row: left row/col, Column: end row/col to Second.
Fourth: Row: left row/col, Column: end row/col to Third.
Fifth: temp to Fourth.

Time Complexity: O(n^2^)  
Space Complexity: O(1)

## Notes
- How to determine the row/col's variables for each move:
1. Draw a 4x4 matrix with 1..16 values in the cells
2. Diagram the movement of the 0th ring, 1st (0-based) element. (So that the four
references will not be identical).
3. Label the rows/cols as:
start row/col (SRC), left row/col (LRC), right row/col (RRC), end row/col (ERC).
4. Circle the 2, 8, 9, & 15 elements.
5. Label each element in the order it will be moved 2=1, 9=2, 15=3, 8=4.
6. Draw arrows from the elements to each other to indicate the moves
(i.e.) 2->Temp, 9->2, 15->9, 8->15,Temp->8
7. Now using each element to be moved & the row/col labels determine the row/col
for each move.