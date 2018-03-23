# Solution 1 - Standard

## Additional Requirements
- None

## Implementation
- Use bit shifting and anding. to create the mask.

### CreatePatternMask

#### Steps
1. Do error checking, throw exceptions if appropriate. Verify that the bit count
 is greater than zero and less than or equal the maximum index (32 for a 32-bit
 integer).

2. Create the initial mask & set to the initial pattern.

3. Check whether the current pattern bit count is less than the maximum index
(32 for a 32-bit integer), if so continue with the loop, if not continue with
step 8.

4. Right shift the pattern the length of the current pattern bit count, shifting
 in zeros as appropriate.

5. And the current mask with the updated pattern, this will update the updated
 part of the mask to the length of the current pattern count.

6. Update the pattern to the current mask.

7. Double the size of the pattern bit count so that the pattern will be doubled
 in the next loop. Go back to Step 3.

8. Return the resulting mask.

#### Complexity
Time: O(log n) where n is the initial pattern bit count.
Space: O(1)  

## Notes
- Efficient because only bit shifts & anding are used to build the mask.