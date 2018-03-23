# Solution 4 - Binary Search

## Requirements

## Implementation
Start by splitting the bits of the integer in half, using a mask with all 1's
on the left half & all 0's on the right. Then check the number against the
mask, if 0 then there are no 1's in the left half, so continue by checking
only the right half, otherwise there is a 1 in the left half so continue
by checking only the right half. Continue this process until there are only
two bits being considered. If the result of the mask check is 0 then the right
index + 1 is the most significant set bit, otherwise it is the left index bit. 

### GetMostSignificantBit

Steps:
1. Check that the value is >= 0, if not throw an exception.
2. Handle 0 as a special case as this algorithm does not work for 0.
3. Initialize a size flag to 32, this flag will be used to keep track
of the current # of bits being tested.
4. Initialize left, right, and middle index variables (to size, size/2, and 0)
these will be used to track the bit indexes currently being tested.
3. Call GetMask to get the initial mask.
5. And the current mask with the number being checked, if 0 then there are no 1
bits in the left half of the current bits being checked, so the next loop
will check the right half, otherwise the next loop will check the left half.
6. Check whether size is 2, if so immediately return right + 1 or left depending
on the result of Step 5.
7. Update the left, right, and middle variables to check the appropriate
half of the list as described above. (Size is always divided by 2, right or left
is set to middle depending on the result of step 5, and middle is set to the
midpoint between the new right & left).
8. Construct a new mask based on the updated index variables.
9. Continue until step 6 causes a return.

Time Complexity: O(log n)  
Space Complexity: O(1)  

## Notes
- This method is very efficient but also more complex than other methods.