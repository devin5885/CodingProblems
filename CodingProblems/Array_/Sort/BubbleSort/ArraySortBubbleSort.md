# Array Sort - Bubble Sort

## Implementation
- Sort the array by 'bubbling' the smallest element to the left end of the
array by swapping adjacent elements as needed, repeating the process until all elements are sorted.

## Notes
- The algorithm calls a swap helper method which swaps two elements in an array.
- The algorithm is very inefficient because there are allot of swaps that
must occur to sort the list.
- The alogrithm is stable, matching keys will not be swapped.
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

3. During each each iteration of the above loop starting at the right end of the array iterate through all the
remaining unsorted elements, swapping the current element with the next adjacent element to the left 
(if it is smaller than the adjacent element).
This process will result in the smallest remaining element being placed at the left most
position in the unsorted part of the array which will then become the last element in the sorted
part of the array.

4. The array is now sorted, return.

### Swap
- Helper method that swaps two elements in a list given the list and the
element indexes.
