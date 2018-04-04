# Split - Solution 1 - Brute Force

## Additional Requirements

---

## Implementation
We will use the simple method of counting the elements in the
list, then finding and updating the appropriate elements.

---

### Split

#### Steps
1. Create two result list references 'resultA' and 'resultB',
and initialize both the input list. ('resultA' points to the
input list and will not be update further). 'resultB' will
be the 'current' node reference.

2. Create a 'dropped' reference and initialize to null.

3. Initialize two 'previous' references to null. These
will point to the previous element and previous of
previous element.

4. Get the count of elements in the list.

5. Determine the half way point in the list.

6. Iterate appropriately to set prev, prev2, and resultB
appropriately based on the half way point in the list.

7. For an odd number of elements update dropped if appropriate
to prev.

Note that the steps below are the same for both solutions.

8. If we found an element to drop (odd number of elements) first null the
dropped elements next pointer. Since the 'previous of previous' reference
now points to the last element in the first half of the list null this
elements next reference. If the 'previous of previous' element is
null this indicates a single element list, so instead null 'resultA'.

9. If we did not find an element to drop (even number of elements) since
the 'previous' reference now points to the last element in the first half
 of the list null this elements next reference. If the 'previous' element is
null this indicates an empty list, so nothing further to do.

10. At this point 'resultA' points to the first element in the list
, 'resultB' points to the first element in the second half of the list
and 'dropped' points to the element that was dropped and all 'next'
references have been updated appropriately.

#### Complexity
Time: O(n) where n is the number of elements in the list.  
Space: O(1)  

---

## Notes
- This algorithm is less efficient than the two pointer method, though both
have comparable run-times.