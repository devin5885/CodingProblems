# Array Search Sorted No Size - Solution 2 - Binary Search

## Additional Requirements

---

## Implementation

### Search

#### Steps
1. Check whether the listy object is null, if so throw an exception.

2. Check whether the value to find is less than 0, if so throw an
exception.

3. Find the starting point by starting at index 1 and doubling the index
(i.e.) 1, 2, 4, 8 etc. until either an element greater than the
element we are search for is found or a -1 element is found.

4. Once the starting point is found do a standard binary search between
the starting index and half of the starting index, with the addition of
considering -1 values to be greater than the value. Once the element is
found return the index, if the element cannot be found return -1.


#### Complexity
Time: O(log n) where n is the count of elements in the listy array.  
Space: O(1)

---

## Notes
