# Solution 3 - Count Recursive

## Additional Requirements
- Use recursion.
- Don't calculate the combinations, instead just count possible combinations.

## Implementation
For this solution we will work backwards from the # of steps (n) recursively calculating
the # of steps for n-1, n-2, and n-3. (Similar to the Fibonacci sequence). When all
recursive calls have completed we will have the #.

Note that for n less than 0 we will use 0, for n equal to 0, we will use 1, this will start the
sequence appropriately.

---

### CountWays

#### Steps
1. Check that the # of steps is greater than 0, if not throw an exception.
2. Pass-through to CountWaysHelper.

---

### CountWaysHelper

#### Steps
Note: n = # of steps passed in.
1. If n is less than 0, return 0.
2. If n is equal to 0, return 1.
3. Otherwise return the recursive calls for n-1 + n-2 + n-3.

---

#### Complexity
Time: O(3^n^) where n is the # of steps.  
Space: O(3^n^) where n is the # of steps.  

## Notes
- This algorithm is still inefficient, but is better than the previous
solutions because the amount of calculations per recursive call is smaller.