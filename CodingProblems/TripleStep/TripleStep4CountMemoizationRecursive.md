# Solution 3 - Count Recursive with Memoization

## Additional Requirements
- Use recursion.
- Don't calculate the combinations, instead just count possible combinations.
- Use Memoization to cache recursive call results.

## Implementation
Same as Solution #3 except that for this solution we will use an array to
keep track of previous results to minimize the amount of recalculation &
recursion.

---

### CountWays

#### Steps
1. Check that the # of steps is greater than 0, if not throw an exception.
2. Initialize an array to keep track of previous results (auto-initialized to 0)
3. Initialize the first element to 1.
4. Pass-through to CountWaysHelper.

---

### CountWaysHelper

#### Steps
Note: n = # of steps passed in.
1. If n is less than 0, return 0.
2. If the nth element in the array is not 0, return it. (This includes the 1 case).
3. Otherwise set the nth array element to the recursive calls for n-1 + n-2 + n-3.
4. Return the nth array element.

---

#### Complexity
Time: O(3^n^) where n is the # of steps.  
Space: O(3^n^) where n is the # of steps.  

## Notes
- This algorithm is much more efficient than the previous algorithms because the
number of recursive calls is minimized.
- This algorithm could also be done iteratively.