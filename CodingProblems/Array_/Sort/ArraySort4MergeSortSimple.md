# Array Sort - Solution 4 - Merge Sort - Simple

## Additional Requirements

---

## Implementation
This algorithm works recursively by splitting the array in half
and calling the method recursively for each half. Once the method
gets down to arrays of a single elements it merges the arrays
together as the recursive calls unwind, thus sorting the array.

---

### Sort

#### Steps
1. Check whether the input array is null, if so throw an exception.

2. Check whether the count of the input array is 0 or 1, if so return.
(This is the end of recursion case).

3. Determine the length of the right & left halves of the array (if
the array contains an odd number of elements the additional element
is included in the left array).

4. Create two helper arrays (right and left) and copy the appropriate
elements from the current array to the appropriate helper array.

5. Call the method recursively to sort the helper arrays.

6. Merge the sorted arrays into a temporary result array.

7. Copy the temporary result array into the input array.

8. The array is now sorted, return.

#### Complexity
Time: O(n log n) where n is the number of elements in the array.  
Space: O(n) where n is the number of elements in the array.  

---

## Notes
- This algorithm is considerably more efficient than the n^2^ sorts, but does
require considerable copying of array elements between arrays.