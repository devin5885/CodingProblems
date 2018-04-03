# Array Sort - Solution 2 - Selection Sort

## Additional Requirements

---

## Implementation
- Sort the array by finding and 'selecting' the smallest element and
moving it to the left side of the list & continuing this process until
the list is sorted.

---

### Sort

#### Steps
1. Check whether the input array is null, if so throw an exception.

2. Iterate through all elements in the array. Elements processed by
this loop will be sorted. When this loop is finished the array will
be sorted.

3. Iterate through all unsorted elements to find the lowest unsorted
element. If this element is not already in the first unsorted
position to the right swap it with that element. This element is
now sorted.

4. Continue until all elements are sorted.

5. The array is now sorted, return.

#### Complexity
Time: O(n^2) where n is the length of the array.  
Space: O(1)  

---

### Swap
- Helper method that swaps two elements in a list given the list and the
element indexes.

---

## Notes
- The algorithm is more efficient than Bubble Sort but still requires
allot of swaps.