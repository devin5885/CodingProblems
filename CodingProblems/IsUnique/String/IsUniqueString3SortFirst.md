# Solution 3 - Sort First

## Requirements
- Additional data structures NOT allowed.
- Don't make any assumptions about the 'char' data type (i.e.) # of chars allowed, size, etc. Consider it a black box.

## Implemenation
This solution sorts the string first in order to avoid using n^2 time.

### IsUnique

Steps:
1. Check for null, if the string is null return true.
2. Sort the string.
3. Check the first 2 chars in the string, if they match return false, then check the second char against the next char etc.  
Note: When coding loop be careful to not crash on strings that are shorter than 2 characters or try to compare the last char in the string to nothing.
4. End: Return true.

Time Complexity: O(n) + O(Sort)  
Space Complexity: O(1) + O(Sort)

## Notes
- Determining the efficiency on the sort algorithm relies on knowing the efficiency of the sort algorithm.
- Since the string must always be sorted, the average case's time is probably worse than the no additional data structure case).
- Note: With custom sort, it might be possible to compare while sorting.
