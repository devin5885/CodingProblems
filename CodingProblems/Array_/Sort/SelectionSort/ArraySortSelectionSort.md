# Array Sort - Selection Sort

## Implementation
- Sort the array by finding and 'selecting' the smallest element and
moving it to the left (sorted) side of the list & continuing this process until
all elements are sorted.

## Notes
- The algorithm calls a swap helper method which swaps two elements in an array.
- The algorithm is more efficient than Bubble Sort but still requires allot of swaps.
- The alogrithm is not stable, since matching keys can get swapped.
- The algorithm works in place (i.e.) no additional variable size buffers are required.

## Complexity
Time: O(n<sup>2</sup>) where n is the length of the array.  
Aux Space: O(1)  

## Methods

### Sort

#### Steps
1. Check whether the input array is null, if so throw an exception.

2. Iterate through all elements in the array. Each time this loop compeletes the array
will be sorted by one more element. When this loop is finished the array will
be completely sorted.

3. During each each iteration of the above loop iterate through all unsorted elements
to find the lowest unsorted element. Swap that element with the first position in the unsorted
part of the array, thus increasing the sorted part of the array by one and reducing the unsorted
part by one.

4. The array is now sorted, return.

### Swap
- Helper method that swaps two elements in a list given the list and the
element indexes.
