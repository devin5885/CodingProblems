# Number Max - Solution 1 - Use Multiplication

## Additional Requirements

---

## Implementation

### Max

#### Steps

#### Complexity
Time: O()
Space: O()

---

## Notes

-- Example w/o overflow

| a | b | a > b | Example        | a - b         | k = Sign(a - b) |
|---|---|-------|--------------  |---------------|-----------------|
| + | + | Yes   | a = 3, b = 2   | (3 - 2) = 1   | 1               |
| + | + | No    | a = 2, b = 3   | (2 - 3) = -1  | 0               |
| - | - | Yes   | a = -2, b = -3 | (-2 + 3) = 1  | 1               |
| - | - | No    | a = -3, b = -2 | (-3 + 2) = -1 | 0               |
| + | - | Yes   | a = 3, b = -2  | (3 + 2) = 5   | 1               |
| - | + | No    | a = -3, b = 2  | (-3 + 2) = -1 | 0               |


-- Example with Overflow

| a | b | a > b | Overflow | Example              | c = a - b          | k = Sign(a - b) | k = Sign(a) |
|---|---|-------|----------|----------------------|--------------------|-----------------|-------------|
| + | + | Yes   | No       | a = 3, b = 2         | (3 - 2) = 1        | 1               |             |
| + | + | No    | No       | a = 2, b = 3         | (2 - 3) = -1       | 0               |             |
| - | - | Yes   | No       | a = -2, b = -3       | (-2 + 3) = 1       | 1               |             |
| - | - | No    | No       | a = -3, b = -2       | (-3 + 2) = -1      | 0               |             |
| + | - | Yes   | No       | a = 3, b = -2        | (3 + 2) = 5        | 1               | + -> 1      |
| - | + | No    | No       | a = -3, b = 2        | (-3 + 2) = -1      | 0               | - -> 0      |
| + | - | Yes   | Yes      | a = INT_MAX, b = -2  | (INT_MAX + 2) = -  | 0 (Wrong)       | + -> 1      |
| - | + | No    | Yes      | a = -3, b = INT_MIN  | (-3 - INT_MIN) = + | 1 (Wrong)       | - -> 0      |

