# Array Sort - Solution 3 - Insertion Sort

## Additional Requirements

---

## Implementation
Sort the array by taking the first unsorted element to on the
right side of the array, moving it to a temp location, then
moving sorted elements to the right until the insertion point
is found. Then inserting the element. Continue until all
elements are sorted.

---

### Sort

#### Steps
1. Check whether the input array is null, if so throw an exception.

2. Iterate through all characters in the array starting from the
right.

3. Store the element being moved in a temporary location, this the
current element in the above loop.

4. Iterate through the sorted part of the array finding the point
where the element being moved should be inserted, while iterating
move elements to the left by one (overwriting the element being
moved in the array which is stored in a temporary location) until
the insertion point is found.

5. Once the insertion point is found, insert the element from
the temp location.

6. Continue with outer loop until all elements are sorted.

7. Return the resulting array.

#### Complexity
Time: O(n^2) where n is the length of the array.  
Space: O(1)  

---

## Notes
- The algorithm is more efficient than Bubble Sort and Selection Sort.