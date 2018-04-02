# Array Merge Sorted - Solution 1 - Simple

## Additional Requirements

---

## Implementation
Iterate through the two arrays taking the appropriate element, until
we run out of elements in one of the arrays. Then take the remaining
elements in the other array.

---

### Merge

#### Steps
1. Check whether either input array is null, if so throw an exception.

2. Initialize the result list.

3. Initialize an index reference for each input list to 0.

4. Iterate while there are elements to take from both input arrays.

5. If the current element from array 1 is less than the element from
array 2 take it, otherwise take the element from array 1.

6. Continue while there are elements from both arrays to take.

7. See if there are any remaining elements in array 1, if so take them.

8. See if there are any remaining elements in array 2, if so take them.

9. Return result.

#### Complexity
Time: O(n + m) where n is the count of elements in the first array and n is the count of elements in the second array.  
Space: O(n + m) where n is the count of elements in the first array and n is the count of elements in the second array.  

---

## Notes
- The code for this method is somewhat simpler than the single loop method.
Both have similar time & space complexities.