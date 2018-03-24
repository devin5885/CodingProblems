# Power Set - Solution 1 - Recursive

## Additional Requirements

---

## Implementation
- To solve this problem we will simply start with the set with 0 items & add
each additional set until we get all the sets needed. To generate the additional
sets we will make recursive calls to the helper method.

---

### GetPowerSet

#### Steps
1. Initialize the result list of lists.

2. Call GetPowerSetHelper with a -1 index to do the calculations.

---

### GetPowerSetHelper
- Takes the array, the current index & the overall result list.

#### Steps
1. If the passed in index is greater than or equal to the number of elements
just return (out of elements to process).

2. If the index is -1, add an empty set element.

3. Otherwise, iterate through the overall result set, for each current result
create a new result with the new element added.

4. Add the new results to the overall result list.

5. Recursively call the method with the current index incremented by one.

---

## Complexity
Time: O(2^n^) where n is the size of the array.  
Space: O(2^n^) where n is the size of the array.

---

## Notes
- The implementation is similar to the CrCI version but is much easier to understand.

- This is not very efficient, however since we must generate all possibilities we
cannot improve this.

- This algorithm could be implemented iteratively as well.