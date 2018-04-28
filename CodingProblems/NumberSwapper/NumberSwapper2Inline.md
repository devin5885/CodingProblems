# Number Swapper - Solution 2 Inline

## Additional Requirements

---

## Implementation
Swap the values using three consecutive exclusive OR operations.

### Swap

#### Steps
1. Check whether the values to be swapped are the same, if so skip remaining
operations and return. See below.

2. Exclusive OR the two values together and assign the result to first value.

3. Exclusive OR the resulting value from the previous step and the second value,
this the new value of the second value.

4. Exclusive OR the two resulting values from the previous steps, this the new value
of the first value.

#### Complexity
Time: O(1)
Space: O(0)

---

## Notes
- This method does not require any additional space.

- This method can be implemented for any data type that can be represented as bits
and thus has an exclusive OR operator.

- This method will not work if the values to be swapped point to the same variable
, thus the algorithm will check whether the values match. Note that we could check
whether both values point to the same actual value, but these will be the same
anyway so just check this.

- Note: The XOR operator returns 1 if both values are different, 0 if both values
are the same.
(i.e.)

| X | Y | XOR |
|---|---|---- |
| 0 | 0 |  0  |
| 0 | 1 |  1  |
| 1 | 0 |  1  |
| 0 | 1 |  0  |

- Truth table for this algorithm:

| X | Y | X = X ^ Y | Y = X ^ Y | X = X ^ Y |
|---|---|---------- |-----------|-----------|
| 0 | 0 |  0        |  0        |  0        |
| 0 | 1 |  1        |  0        |  1        |
| 1 | 0 |  1        |  1        |  0        |
| 1 | 1 |  0        |  1        |  1        |

The final result is that X and Y are swapped.