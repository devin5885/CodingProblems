# Array Sort - Insertion Sort - Iterative

## Implementation
Consider the first element in the array as already sorted and making up the initial sorted part of the array.
Iterate thru the unsorted portion of the array starting at the second element and continuing until at the end of the passed in array.  
In each iteration reduce the length of the unsorted part of the array by one by moving one element from the unsorted to the sorted part of the array.  
During the iteration move the element being moved (sorted) into a temporary location then shift exising sorted elements to the left one by one until the insertion  
point is found. Then insert the element which has been moved from the temporary location to the appropriate insertion location.  
Continue until the array is sorted.

## Notes
- The algorithm is more efficient than Bubble Sort and Selection Sort.
- The algorithm is not stable.
- The algorithm is in-place.
- The iterative version is slightly more difficult to implement but does
not use additional stack space.

## Complexity
Note: n is the length of the array.  
Average Case Time: O(n<sup>2</sup>)  
Worst Case Time: O(n<sup>2</sup>) (Reverse sorted array)  
Best Case Time:  O(n) (Sorted array)   
Aux Space: O(1)  

## Methods

### Sort

#### Steps
1. Check whether the input array is null, if so throw an exception.

2. Iterate thru the unsorted portion of the array starting at the second position and
continuing until at the right end of the passed in array.  

3. Store the element at index 'length - 1' into a temporary location.

4. Iterate through the sorted part of the array finding the point
where the element being moved should be inserted, while iterating
move elements to the right by one (moving the insertion point to the right
) until the final insertion point is found.

5. Once the insertion point is found, insert the element back from
the temp location.

6. Continue iterating until the entire array is sorted.
