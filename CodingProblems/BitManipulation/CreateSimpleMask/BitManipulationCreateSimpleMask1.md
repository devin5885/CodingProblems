# Solution 1 - Standard

## Additional Requirements
- None

## Implementation
- Use bit shifting to create the mask.

### CreateMask

#### Steps
1. Do error checking, throw exceptions if appropriate. Check for either index
 being too large or negative & that the first index is greater than or equal to
 the second index.

2. Create the initial mask with all 1's. Be sure to create an unsigned integer so
 that zeros are left shifted in.

3. Right shift the appropriate amount of zeros in, the formula is: Total number
 of bits (32 for integer) - (most significant byte index - least significant
 byte index).

4. Left shift the appropriate amount of zeros in, the formula is: Least 
 significant byte index.

5. Return the mask converted to a signed integer.

#### Complexity
Time: O(1)  
Space: O(1)  

## Notes
- Efficient because only bit shifts are used to build the mask.