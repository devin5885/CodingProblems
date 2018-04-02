# Array Merge Sorted - Solution 2 - Single Loop

## Additional Requirements

---

## Implementation
Iterate through the two arrays taking the appropriate element, continue
while there are elements in either array.

---

### Merge

#### Steps
1. Check whether either input array is null, if so throw an exception.

2. Initialize the result list.

3. Initialize an index reference for each input list to 0.

4. Iterate while there are elements to take from either input arrays.

5. If there are elements still available for array 1 get the element.

6. If there are elements still available for array 2 get the element.

7. If we got an element from array 1 but not array 2 take the element
from array 1.

8. If we got an element from array 2 but not array 1 take the element
from array 2.

9. If the current element from array 1 is less than the element from
array 2 take it, otherwise take the element from array 1.

10. Continue while there are elements from either array to take.

11. Return result.

#### Complexity
Time: O(n + m) where n is the count of elements in the first array and n is the count of elements in the second array.  
Space: O(n + m) where n is the count of elements in the first array and n is the count of elements in the second array.  

---

## Notes
- The code for this method is somewhat more complex than the simple method. 
Both have similar time & space complexities.
