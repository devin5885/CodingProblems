# Fibonacci - Solution 2 Recursive Memoization

## Additional Requirements
- Use Recursion with Memoization

---

## Implementation

---

### Fibonacci

#### Steps
1. Check that the index > 0, if not throw an exception.

2. Initialize the array to store intermediate results.

3. Initialize the first two entries to the corresponding indexes (i.e.) 0 and 1

4. Pass-through to Fibonacci helper to generate the number passing the index
and intermediate value array.

---

## Complexity
Time: O(n) where n is the index.  
Space: O(n) (Array + Recursive stack frames).  

---

## Notes
- This is more efficient because we cache previous results.

