# Solution 2 - Shift the Mask

## Requirements

## Implementation
Use bit shifting, shift the mask.

### GetBitCount

Steps:
1. Initialize a counter of the # of set bits to 0.
2. Iterate through the bits.
3. Using a mask determine if the bit is 0 or 1. Increment the
counter if 1.
4. Return the count.

Time Complexity: O(1)  
Space Complexity: O(1)  

## Notes
- This algorithm is less efficient than the bit shift algorithm because the loop
 always runs sizeof(int) * 8 (32) times.
