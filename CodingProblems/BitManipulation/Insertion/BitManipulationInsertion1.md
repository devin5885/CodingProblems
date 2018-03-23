# Solution 1 - Standard

## Requirements

## Implementation

### UpdateBits
We will update the number by anding the two numbers together to get the desired
result. Before doing this we will have to clear the appropriate bits in the first
number & shift the bits in the second number to the appropriate location.

Steps:
1. Call CreateMask to create a mask with the appropriate bits between i & j (inclusive)
cleared.
2. Use the mask to clear the appropriate bits in n.
3. Shift the bits in m to start at i.
4. Or the cleared & shifted values together & return.

Time Complexity: O(1)  
Space Complexity: O(1)  

## Notes
- This algorithm is similar to CtCI, however the creation of the mask is encapsulated
into a helper method and done slightly more efficiently.