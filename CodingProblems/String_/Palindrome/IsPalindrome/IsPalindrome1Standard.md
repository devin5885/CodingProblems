# Is Palindrome - Solution 1 - Standard

## Additional Requirements

---

## Implementation
Simply initialize a reference to the first and last character of the
string, then compare the characters at the current index. If the character
match decrement the indexes and check the next characters. If the
characters don't match immediately return false. If the references cross
return true as all characters match.

---

### IsPalindrome

#### Steps
1. Check whether the input string is null, if so throw an exception.

2. Initialize a left string index reference to 0.

3. Initialize a right string index reference to the length of the input
string - 1.

4. Continue while the left string index is less than the right string index.

5. If the element at the two indexes does not match return false.

6. Once the references cross (as described above) end & return true since
the strings match.
 
---

## Complexity
Time: O(n) where n in the length of the string.
Space: O(1)  

---

## Notes
