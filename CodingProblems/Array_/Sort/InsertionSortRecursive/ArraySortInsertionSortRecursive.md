# Array Sort - Insertion Sort - Recursive

## Implementation
Sort the array recursively calling the sort method with the length - 1.
Thus, there will be 'length' recursive calls. The array will be
sorted via sorting of sub-arrays as the recursive calls unwind.

As the recursive calls unwind the sub-array for that recursive call
 is sorted by first moving the element to be sorted into a temporary location
then shifting exising sorted elements to the left one by one until the insertion
point is found, then inserting back the element being sorted.

## Notes
- The algorithm is more efficient than Bubble Sort and Selection Sort.
- The algorithm is not stable.
- The algorithm is in-place.
- Since this is a recursive algorithm it requirees 'length - 1' stack
frames will be created while the method runs.

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

2. Check whether the length passed in is <= 1, in this case there
is nothing to sort, so return.

3. Make a recursive call to the method, specifying length - 1 for the length.

4. Store the element at index 'length - 1' into a temporary location.

5. Iterate through the sorted part of the array finding the point
where the element being moved should be inserted, while iterating
move elements to the right by one (moving the insertion point to the right
) until the final insertion point is found.

6. Once the insertion point is found, insert the element back from
the temp location.

7. Continue iterating until the entire array is sorted.
