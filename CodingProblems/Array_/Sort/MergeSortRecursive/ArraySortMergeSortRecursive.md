# Array Sort - Merge Sort - Recursive

## Implementation
This algorithm works by first checking whether the passed in sub-array is already sorted because it
has less than two elements.  
If so it returns, if not it splits the passed in sub-array into two smaller sub-arrays
and recursively calls itself on two smaller sub-arrays, when each recursive call returns the returned two sub-arrays
which are now sorted are merged resulting in a larger sorted sub-array.  
When all calls have returned and been merged the array is sorted.

## Notes
- This algorithm is more efficient than the simple n<sup>2</sup> sorts, but does
require an auxillary temporary array of max length n.
- The algorithm is stable.
- The algorithm is not in-place.

## Complexity
Note: n is the length of the array.  
Average/Worst/Best Case Time: O(n log n)  
Aux Space: O(1) + recursive call stack frames.  

## Methods

### Sort

#### Steps
1. Call SortHelper to sort the full array.

### SortHelper

#### Steps
1. Check whether the input array is null, if so throw an exception.

2. If null is specified for the passed in endIndex, update it to the length of the array - 1.

3. Check whether the start index is greater than or equal to end index, if so return since this is an
array with length < 2. (This is the end of recursion case).

3. Determine the length of the right & left halves of the array (if
the array contains an odd number of elements the additional element
is included in the left array).

4. Call the method recursively to sort the sub-arrays.

5. Call the Merge method to merge the two sorted sub-arrays.

6. The array is now sorted, return.
