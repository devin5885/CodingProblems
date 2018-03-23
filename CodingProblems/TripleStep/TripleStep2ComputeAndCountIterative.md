# Solution 1 - Compute And Count Iterative

## Additional Requirements
- Do not use recursion.

## Implementation
To solve the problem we will simply compute all combinations of hops to get to
the specified # of steps, we will then return the count of combinations.

---

### CountWays

#### Steps
1. Check that the # of steps is greater than 0, if not throw an exception.
2. Initialize the result list, this is a list of lists, each list will be a
set of hops to the nth step (i.e.) if n=3, a possible set of hops would be 1,1,1
3. Initialize the current list, this will be used to iterate over the remaining combinations.
4. Call CheckAndAddHelper 3 times to generate the initial hops combination of a single hop.
5. Continue while the current list has entries to process.
6. Initialize the list for the next iteration.
7. For each combination in the list call CheckAndAddHelper 3 times to add additional hops & generate the next list appropriately.
8. Update the current list reference to the next list & goto step 5.
9. Return the count of the result list.

---

#### CheckAndAddHelper
1. Generate a new list of hops from the current list of hops.
2. Add this hop to the end of the list.
3. Get the sum of the list.
4. If the sum is less than the # of steps add to the next iteration list.
5. If the sum matches the # of steps, add this to the result list & return.
6. If the sum is greater than the # of steps, do nothing.

#### Complexity
Time: O(3^n^) where n is the # of steps.  
Space: O(3^n^) where n is the # of steps.  

## Notes
- This is still somewhat inefficient since we compute the combinations even though
this is more information than we actually need, thus the practical limit for
this method is around 20 steps.
