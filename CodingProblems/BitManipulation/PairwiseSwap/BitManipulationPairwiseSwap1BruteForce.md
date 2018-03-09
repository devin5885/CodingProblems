# Solution 1 - Brute Force

## Requirements

## Implementation

### SwapOddEvenBits
We will simply iterate through the bits swapping the bits.

Steps:
1. Determine the max index for int (32).
2. Iterate through each pair of bits, swapping them (using the helper functions
 BitManipulationGetSetClearBit1Complete.GetBit/SetClearBit).

Time Complexity: O(1)  
Space Complexity: O(1)  

## Notes
- This algorithm is not in CtCI.
- This algorithm is not efficient because each bit is read/written individually.