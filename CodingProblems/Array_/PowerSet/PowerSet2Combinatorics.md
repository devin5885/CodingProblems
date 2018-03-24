# Power Set - Solution 2 - Combinatorics

## Additional Requirements

---

## Implementation

---

### GetPowerSet

#### Steps
1. Initialize the result list of sets.

2. Determine 2 ^ array.Length this is the maximum value.

3. If this value is over int.MaxValue throw an exception.

4. Convert the maximum value to an int.

5. Call the helper method GetPowerSetForValue to create a set for each
value from 0 to the maximum value - 1 & add these sets to the result 
of sets. Note that we do not use the maximum value itself because
 this value does not correspond to a set.

---

### GetPowerSetForValue
- Takes the array and the current value.

#### Steps
1. Creates the empty set.

2. Loops through each bit in the passed in value, by starting at the value
and right shifting until the value is 0. Maintain a corresponding array
index that starts with 0 & is incremented each time through the loop.

3. If the bit is set, add the value from the array corresponding to the
current index.

---

## Complexity
Time: O(2^n^) where n is the size of the array.  
Space: O(2^n^) where n is the size of the array.

---

## Notes
- This solution is from CtCI, but has additional error checking.

- This solution is still O(2^n^) however the number of operations per
iteration is less, so it is a bit more efficient.

- For this solution the array size is limited to int.MaxValue, if the
array size is larger than this the method will throw an overflow
exception. (Note: For now this case will not have a unit test). This
could be avoided by using a larger data type internally but for
now we will use a 32-bit integer.
