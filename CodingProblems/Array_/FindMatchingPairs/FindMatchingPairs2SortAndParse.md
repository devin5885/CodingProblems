# Find Matching Pairs - Solution 2 - Sort And Parse

## Additional Requirements
- Don't use additional data structures.
- Assume that the lists are mutable.

---

## Implementation

---

### FindMatchingPairs

#### Steps
1. Check whether either list is null, if so throw an exception.

2. Sort both lists.

3. Define indexes for each list initially set to 0.

4. Iterate through both lists simultaneously continuing while both indexes are
pointing to members of the respective list. (If either is past the end of the list
there are no more matches so we are done).

5. Compare the elements pointed two by the two indexes, if the elements match, add
an instance of the element to the result list & increment both indexes, otherwise:

6. If the element in list 1 is greater than the element in list 2 increment only the
list 2 index, otherwise:

7. Assume that the list 2 element is grater then the list 1 element and increment
only the list 1 index.

8. Continue as described above until out of elements.

9. Return resulting list.

---

## Complexity
Time: O(n + m) where n is the count of the first list and m is the count of the second list. (Assumes that the lists can be sorted in n or m or less time).  
Space: O(1)

---

## Notes
- This is simple but does require both lists to be sorted.