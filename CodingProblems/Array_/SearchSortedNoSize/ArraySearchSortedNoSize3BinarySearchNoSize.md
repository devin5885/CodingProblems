# Array Search Sorted No Size - Solution 3 - Binary Search No Size

## Additional Requirements

---

## Implementation

### Search

#### Steps
1. Check whether the listy object is null, if so throw an exception.

2. Check whether the value to find is less than 0, if so throw an
exception.

3. Initialize two indexes, and index and a previous index to 0.
 
4. Initialize a last index variable to null (this variable will not
have a value till after the first iteration).

4. (Outer loop) Iterate while the last index variable is valid and the
previous index is less than the last index - 1.

5. Initialize an index increment value to 1.

6. Get the element at index.

7. (Inner loop) Start at index 1 and double the index
(i.e.) 1, 2, 4, 8 etc. until either an element greater than the
element we are search for is found or a -1 element is found.

8. If the end element of the inner loop is the value we are looking
for return the index.

9. Store the final index in the last index variable.

10. Reset the index to the previous index so that the inner loop
will start at the appropriate point.

11. Continue with the outer loop (Goto step #4)

12. Return -1 since the element was not found.

#### Complexity
Time: O(log n) where n is the count of elements in the listy array.  
Space: O(1)

---

## Notes
