# Number Swapper - Solution 1 - Use Temporary Variable

## Additional Requirements
- For this solution we will allow a temporary variable to be used.

---

## Implementation
Simply swap the values using the temporary variable.

### Swap

#### Steps
1. Assign the first value to a temporary variable.

2. Assign the second value to the first value.

3. Assign the temporary value to the second value.

#### Complexity
Time: O(1)
Space: O(1)

---

## Notes
- This method can be implemented for any data type that has an equals operator.

- We could check whether the values are the same before swapping, and skip the
swap but this requires additional steps and thus could end up being slower than
just swapping in any case.