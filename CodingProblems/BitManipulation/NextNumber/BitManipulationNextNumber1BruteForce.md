# Solution 1 - Brute Force

## Requirements

## Implementation

### GetNext
Simply get the count of the # of set bits in the passed in value. Keeping
adding 1 to the value & counting the bits until a matching value is found
& returned or return -1 if no value is found.

Steps:
1. Verify that the specified number is positive if not throw an appropriate exception.
2. Get the bit count for the value passed in.
3. Starting with the passed in value + 1 check the bit count of the resulting
value, if it matches the bit count of the passed in value, return it.
4. Continue adding 1 & checking until a matching value is found & returned
or we run out of values to check. Note that for this case if we run out of
values due to overflow the resulting value will be 0.
5. If no value was found return -1.

Time Complexity: O(1)  
Space Complexity: O(1)  

### GetPrev
Simply get the count of the # of set bits in the passed in value. Keeping
subtracting 1 to the value & counting the bits until a matching value is found
& returned or return -1 if no value is found.

Steps:
1. Verify that the specified number is positive if not throw an appropriate exception.
2. Get the bit count for the value passed in.
3. Starting with the passed in value - 1 check the bit count of the resulting
value, if it matches the bit count of the passed in value, return it.
4. Continue subtracting 1 & checking until a matching value is found & returned
or we run out of values to check. Note that for this case if we run out of
values due to overflow the resulting value will be -1.
5. If no value was found return -1.

Time Complexity: O(1)  
Space Complexity: O(1)  

## Notes
- This algorithm is not in CtCI.
