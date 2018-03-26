# Fibonacci - Solution 3 Iterative

## Additional Requirements
- Use Iteration

---

## Implementation

---

### Fibonacci

#### Steps
1. Check that the index > 0, if not throw an exception.

2. For index 0, just return 0.

3. Initialize two integers to store the previous and second previous results.
The second previous result is hard coded to 0 and the previous result is hard
coded to 1.

4. Initialize the final result to 1.

5. Starting with 2, loop until we get the index we are looking for.

6. Calculate the current result, this the previous result plus the second
previous result.

7. Update the second previous result to the current previous result & the
previous result to the current result.

8. Continue until we reach the specified index.

9. Return the current result.

---

## Complexity
Time: O(n) where n is the index.  
Space: O(1)  

---

## Notes
- This is the best option since it does not require recursion or a temporary array
however it is more complex to implement.