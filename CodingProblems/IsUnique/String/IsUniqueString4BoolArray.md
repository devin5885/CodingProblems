# Solution 4 - Use Bool Array

## Implementation

- This solution is similar to the HashSet solution, but to save space instead it uses a more compact data structure. The data structure is an array of boolean values, the array elements are mapped to the array indexes by thier numeric equivalent, thus the array must have enough space to store any possible numeric character value. So, for Unicode characters the # of possible chars is (sizeof(char) = 2 bytes * 8 bits/byte) = 16. Therefore, the array must be 2 ^ 16 (64K) in size.
Also, in this solution we check whether the string is larger than 64K, in this case we return false immediately.

### IsUnique

Steps:

1. If string is null return true.
2. Check whether the string is >64K, if so return false immediately.
3. Create & initialize all array elements to false. 
4. For each char check whether the corresponding array element is True, if it is return False, if not update the array entry to True.
5. End: Return true.

Time Complexity: O(n)  
Space Complexity: O(1)  

Notes:
- Advantage: Space usage is constant & small.
- Disadvantage: Requires knowing details of the char data type which could change in the future. 
- Disadvantage: Additional test cases are needed due to additional code.
