# Solution 2 - Use SetClearBit

## Requirements

## Implementation
- Use the SetClearBit helper method to create the mask.

### CreateMask

Steps:
1. Do error checking, throw exceptions if appropriate. Check for either index
being too large or negative & that the first index is greater than or equal to
the second index.
2. Initialize the mask to all zeros.
3. Iterate between the specified indexes setting all the appropriate bits.
4. Return the mask.

Time Complexity: O(1)  
Space Complexity: O(1)  

## Notes
This method is inefficient because we call SetClearBit every time to set individual
bits, each of these calls creates a custom mask to set the bit, but it is simple.