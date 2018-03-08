# Solution 1 - Standard

## Requirements

## Implementation
- Use bit shifting to create the mask.

### CreateMask

Steps:
1. Do error checking, throw exceptions if appropriate. Check for either index
being too large or negative & that the first index is greater than or equal to
the second index.
2. Create the initial mask with all 1's. Be sure to create an unsigned int so
that zeros are left shifted in.
3. Right shift the appropriate amount of zeros in, the formula is:
Max Index (32 for Int32) - most significant byte index + least significant byte index.
4. Left shift the appropriate amount of zeros in, the formula is:
Least significant by index.
5. Return the mask converted to an int.

Time Complexity: O(1)  
Space Complexity: O(1)  

## Notes
Efficient because only bit shifts are used to build the mask.