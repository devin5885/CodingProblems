# Magic Index - Solution 1 - Brute Force

## Additional Requirements

---

## Implementation
- To solve this problem we will walk the array from the start until the magic
index is found, then return it. If no magic index if found -1 will be returned.

---

### FindMagicIndex

#### Steps
1. Check whether the array is null, if so throw an exception.

2. Walk the array checking each element until a magic element is found
and when found return it.

3. If no magic element is found return -1.

---

## Complexity
Time: O(n) where n is the size of the array.  
Space: O(0)  

---

## Notes
- This is very inefficient because we need to walk the entire array.
- For this method the values do not have to be distinct.
