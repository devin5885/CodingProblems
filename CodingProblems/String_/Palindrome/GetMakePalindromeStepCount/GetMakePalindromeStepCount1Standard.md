# Get Make Palindrome Step Count - Solution 1 - Standard

## Additional Requirements

---

## Implementation
Calculate the minimum edit distance between the input string and it's
reverse, then return this distance divided by two.

---

### GetMakePalindromeStepCount

#### Steps
1. Check whether the input string is null, if so throw an exception.

2. Get the reverse of the input string.

3. Call the GetMinimumEditDistance helper method to get the minimum
edit distance between the input string and it's reverse, then return
this distance divided by two.

#### Complexity
Time: O(n^2^) where n is the length of the string.  
Space: O(n^2^) where n is the length of the string.  

---

### GetMinimumEditDistance

#### Steps
1. Check whether the input or output string is null, if so throw an
exception.

2. Initialize a two by two matrix to store the minimum edit distance
between the substrings of the string.

3. Compute the 0 column and row to the row or column index since the
edit distance from an empty string to any string is the character
count of the string.

4. Iterate through the remaining matrix elements calculating the
value from the three elements adjacent to the element (i.e.) the
element to the right, above, and both right and above (which is
already calculated) and adding one if the characters corresponding
to the row and column are different.

5. Return the lower right most elements value.

#### Complexity
Time: O(nm) where n is the length of the start string and m is the length of the end string.  
Space: O(nm) where n is the length of the start string and m is the length of the end string.   

## Notes
