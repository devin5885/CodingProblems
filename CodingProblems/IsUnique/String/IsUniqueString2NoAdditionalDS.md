# Solution 2 - Use no additional data structures

## Requirements
- Additional data structures NOT allowed.
- Don't make any assumptions about the 'char' data type (i.e.) # of chars allowed, size, etc. Consider it a black box.

## Implementation
This solution does not require a additional data structure but does require n^2 time.

### IsUnique

Steps:
1. If string is not null for each char in string, check all additional chars to find match, if match is found return false.
2. End: Return true.

Time Complexity: O(n^2)    
Space Complexity: O(1)  

## Notes
- Advantage: This algorithm would work for any array element type.
