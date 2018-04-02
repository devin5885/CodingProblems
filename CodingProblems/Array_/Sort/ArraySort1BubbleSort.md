# Array Sort - Solution 1 - Bubble Sort

## Additional Requirements

---

## Implementation
- Sort the array by 'bubbling' the lowest elements to the left end of the
array by swapping elements via consecutive iterations.

---

### Sort

#### Steps
1. Check whether the input array is null, if so throw an exception.

2. Initialize a 'swapped' flag to true. This flag will be used to stop sorting
early if no swaps occur during a particular iteration.

3. Iterate through all elements in the array (or until no swaps occur).
This outer loop will define the part of the array that is sorted.

4. Reset the swapped flag to false.

5. Starting at the right end of the array iterate through all elements
up (and including) the current element in the outer loop, swapping
adjacent characters if needed. If a swap was needed set the swapped flag
to true. This loop will sort lowest elements to the left end of the array.

6. Continue the outer loop until all elements are processed or no
swaps have occurred on the inner loop.

7. Return the resulting array.

#### Complexity
Time: O(n^2) where n is the length of the array.  
Space: O(1)  

---

### Swap
- Helper method that swaps two elements in a list given the list and the
element indexes.

---

## Notes
- The algorithm is very inefficient because there are allot of swaps that
must occur to sort the list.