# Array Missing Int - Solution 1 Standard

## Additional Requirements

---

## Implementation
To find the missing integer we will create a byte array, each bit in the array
will correspond to a single integer within the specified allowed range. As
we read the file we will update the corresponding bit in the buffer to 1, once
we have updated the buffer completely. We will find the first bit in the buffer
that is 0 and return the value corresponding to that bit.

### FindMissingInt

#### Steps
1. Determine the count of the range of integer values within the file, this is the
maximum value - minimum value + 1. Note that a long must be used to store this value
because the maximum range is 1 larger than int.MaxValue.

2. Determine whether the number of values is an even multiple of 8, if not then
we will need to consider that the last byte in the array will not be completely
populated.

3. Determine the number of minimum buffer size, this is the value (maximum value - minimum value + 1) / 8 (+ 1 if maximum value - minimum value + 1 %& is non-zero).

4. If the provided buffer size is not large enough throw an argument exception.

5. Allocate the buffer.

6. Read the file one integer at a time, updating the appropriate value in the buffer
to 1 as each integer is read.

7. After updating the buffer find the first bit set to 0 (starting at the beginning
of the buffer) and return the value corresponding to the bit. Note that if the
entire buffer is checked and no missing value is found -1 is returned. Note also
that if the allowed range of values is not evenly divisible by 8, we need to
only consider a subset of the bits in the last byte.

#### Complexity
Time: O(n) where n is the file size.
Space: O(m) where m is the buffer size.

---

## Notes
