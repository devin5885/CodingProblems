# Array Search Sorted No Size - Solution 1 - Brute Force

## Additional Requirements

---

## Implementation
Iterate through the array to find the value, return when the value is
found or a -1 (end of array) element is found.

### Search

#### Steps
1. Check whether the listy object is null, if so throw an exception.

2. Check whether the value to find is less than 0, if so throw an
exception.

3. Iterate through the array until the element is found that is greater
than the element being searched for or a -1 element is found. If a -1
 elements is found return -1, otherwise return the found element's index.

#### Complexity
Time: O(n) where n is the count of elements in the listy array.  
Space: O(1)

---

## Notes
