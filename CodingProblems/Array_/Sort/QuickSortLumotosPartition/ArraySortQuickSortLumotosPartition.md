# Array Sort - Quick Sort - Lomuto's Partition

## Implementation
- Sort the array via QuickSort (i.e.) First check whether the method is being called for an array
of length >= 1, if so, there is no sorting to be done so return. Then call Partition method to partiion
 the array. The partition method will select the pivot element from
the remaining elements at random. It will then partition the array into two sub-arrays with all elements with
a lower value than the pivot elements in the left sub-array and all the elements with a higher value
 on the right sub-array, then reinsert the pivot element back into it's final position betwen the two
sub-arrays. It will then return the index of the pivot method. The method will then call the itself recursively
 for the right and left sub-arrays. When the original call returns then array will be sorted.

## Notes
- This algorithm is more efficient than the n^2^ sorts, but does require recursive calls.
- The algorithm is not stable.
- The algorithm is in-place.
- Lomuto's Partition is in-place and works in O(n) time.

#### Complexity
Note: n is the length of the array.  
Average Case Time: O(n log n)  
Worst Case Time: O(n<sup>2</sup>)
Best Case Time:  O(n log n)  
Space: O(1) + Recursive call stack frames.

## Methods

### Sort

#### Steps

1. Check whether the input array is null, if so throw an exception.

2. If null is specified for the passed in endIndex, update it to the length of the array - 1.

3. Check whether the start index is greater than or equal to end index, if so return since this is an
array with length < 2. 

4. Call the Parition method to partition the array into right and left sub-arrays and get the new parition index.

5. Recursively call the method for the right and left sub-arrays.

### Partition (Lomuto's)

#### Steps

1. Ignore the first element in the sub-array, this is the pivot element.

2. Create two pointers set to at the second element in the sub-array. Refer to these pointer as the green and orange pointers.  
The green pointer will create the array section to the right, composed of elements less than or equal to the pivot.  
The orange pointer will create the array section to the left, composed of elements more than the pivot.  
The pointers will be moved from left to right to left independently, creating the the green and orange sub-arrays.
At end of method orange pointer will point to the last element of the orange (left) section and green will be at the last element of the green (right) section and the last element in the array.

3. Green pointer moves one cell to the right. The element being pointed to is checked to determine if it is a green or orange element.

4. If it is a green element, then there is nothing to do, go back to Step 3 and continue mnoving.

5. If it is an orange element, the orange pointer is moved one cell to the right and the elements under the pointers are swapped.
Thus the orange pointer is pointing to the last orange element, the green pointer is pointing to the last green element.

6. Continue until the green pointer is past the end of the array.

7. Finally swap the first (pivot) element with the element pointed to by the orange pointer. (This is its final position).
