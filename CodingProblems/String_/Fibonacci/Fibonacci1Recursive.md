# Fibonacci - Solution 1 Recursion

## Additional Requirements
- Use Recursion

---

## Implementation

---

### Fibonacci

#### Steps
1. Check that the index > 0, if not throw an exception.

2. For any index (n) <= 1 (i.e.) 0 and 1, return the index.

3. Recursively call the method for n-1 and n-2. Add & return the resulting
values.

---

## Complexity
Time: O(2^n^) where n is the index.  
Space: O(2^n^) (Recursive stack frames).  

---

## Notes
- This is very inefficient because we must recalculate results that have already
been calculated.

