# Find Longest Palindrome - Solution 1 - Brute Force

## Additional Requirements

---

## Implementation

---

### FindLongestPalindrome

#### Steps
1. Check whether the input string is null, if so throw an exception.

2. Iterate through string lengths starting with the length of the input string
to strings of length one.

3. For each string length, generate all the possible sub-strings from the
input string for that length from lowest start index to highest start index.

4. Check each string, if the string is a palindrome return it.

5. Continue with all strings & string lengths. (Eventually the first single
character in the input string should be returned).

6. Return string.empty since no palindrome was found. (Should only occur
for empty string).

---

### IsPalindrome
Helper function to check whether an input string is a palindrome.

|            |                                                               |
|------------|---------------------------------------------------------------|
| Name       | IsPalidrome                                                   |
| Parameters | The input string.                                             |
| Returns    | True if the input string is a palindrome, false otherwise.    |

#### Steps
1. Check whether the input string is null, if so throw an exception.

2. Initialize a left string index reference to 0.

3. Initialize a right string index reference to the length of the input
string - 1.

4. Continue while the left string index is less than or equal to the right
string index.

5. If the element at the two indexes does not match return false.

6. Once the references cross (as described above) end & return true since
the strings match.
 
---


## Complexity
Time: O(n^3^) - n^2^ for main routine * n for helper method.  
Space: O(1)

---

## Notes
- This algorithm is simple, but inefficient since we need to check
every single generated string to see if it is a palindrome.