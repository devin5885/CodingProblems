# Solution 1 - Use Hash Set

## Requirements
- Additional data structures allowed.
- Don't make any assumptions about the 'char' data type (i.e.) # of chars allowed, size, etc. Consider it a black box.

## Implemenation
This solution uses a hash set for quick lookup of already seen characters.

### IsUnique

Steps:
1. Create secondary data structure (DS) (hash set) 
2. If string is not null, walk all chars.
3. For each char check that char is not in DS, if it is return false, if not add it.
4. End: Return true.

Time Complexity: O(n)  
Space Complexity: O(n)

## Notes
- Advantage: The # of unique chars in the string is probably small compared to the size of the string.
- Advantage: This algorithm could be generalized for any type of array. As long the template parameter to the HashSet matches the array element type.