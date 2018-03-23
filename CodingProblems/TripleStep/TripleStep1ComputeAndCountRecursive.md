# Solution 1 - Compute And Count Recursive

## Additional Requirements
- Use recursion.

## Implementation
To solve the problem we will simply compute all combinations of hops to get to
the specified # of steps, we will then return the count of combinations.

---

### CountWays

#### Steps
1. Check that the # of steps is greater than 0, if not throw an exception.
2. Initialize the result list, this is a list of lists, each list will be a
set of hops to the nth step (i.e.) if n=3, a possible set of hops would be 1,1,1
3. Call the helper method to generate the result list.
4. Return the count.

---

#### CountWaysHelper

##### Steps
1. Call CheckAndAddHelper three times, once for each hop count: 1, 2, 3
2. When all recursive calls have been completed the list of hops will contain all combinations.

---

#### CheckAndAddHelper
1. Generate a new list of hops from the current list of hops.
2. Add this hop to the end of the list.
3. Get the sum of the list.
4. If the sum is less than the # of steps, make a recursive call to the CountWaysHelper.
5. If the sum matches the # of steps, add this to the result list & return.
6. If the sum is greater than the # of steps, do nothing.

#### Complexity
Time: O(3^n^) where n is the # of steps.  
Space: O(3^n^) where n is the # of steps.  

## Notes
- This is somewhat inefficient since we compute the combinations even though
this is more information than we actually need, thus the practical limit for
this method is around 20 steps.
