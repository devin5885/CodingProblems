# Get Permutations Solution 2 - Use Dictionary

## Additional Requirements

---

## Implementation
This method works by generating all possible permutations, but avoids
generating duplicate permutations by building a map of character
counts and iterating through each duplicate character only once. (Note
however that recursive calls for all characters including duplicates
are made in order to generate all permutations).

---

### GetPermutations

#### Steps
1. Check whether the input string is null, if so throw an exception.

2. Call the BuildCharCountDict helper method to build the character
count dictionary.

3. Initialize the result list.

4. Call GetPermutationsHelper to generate the list of permutations.

5. Return the list of permutations.

#### Complexity
Time: O(n!) where n is the number of unique character in the string.  
Space: O(n!)  where n is the number of unique character in the string.  

---

### GetPermutationsHelper
- This is the main worker method.

#### Method information
|            |                                                 |
|------------|-------------------------------------------------|
| Name       | GetPermutationsHelper                           |
| Parameters | The result list                                 |
|            | The current string                              |
|            | The character count dictionary                  |
| Returns    | None                                            |

#### Steps
1. Check whether the result list, current string, or character
count dictionary are null, if so throw an exception.

2. If the passed in character count dictionary is empty
and the current string is not empty add it to the result list
and return. (This the recursive calls end).

3. Iterate through all remaining characters in the character
count dictionary.

4. For each character make a copy of the current dictionary
and call the ConsumeCharFromCharCountDict helper method with
the copy of the dictionary to 'consume' the character.

5. Recursively call the method with the current result list
the current string plus the consumed character and the
updated character count dictionary.

6. Continue with all characters in the dictionary.

6. Return the resulting list.

#### Complexity
Time: O(n!) where n is the number of unique character in the string.  
Space: O(n!)  where n is the number of unique character in the string.  

---

### BuildCharCountHelper
- Helper method that builds a dictionary of characters and their counts in
the string.

- The method throws an exception if a null string is passed in.

#### Method information
|            |                                                 |
|------------|-------------------------------------------------|
| Name       | BuildCharCountDict                              |
| Parameters | The input string                                |
| Returns    | The resulting dictionary.                       |

#### Steps
1. Check whether the input string is null, if so throw an exception.

2. Initialize the result dictionary.

3. Iterate through all characters in the string, for each character
check whether it is in the dictionary, if so increment the count, if
not add it to the dictionary with a count of 1.

4. Return the resulting dictionary.

#### Complexity
Time: O(n) where n is the count of characters in the string.  
Space: O(n) where n is the count of characters in the string.  

--

### ConsumeCharFromCharCountDict
- Helper method that "consumes" a specified characters from a
character count dictionary by reducing the count by one and
deleting the entry if the count reaches 0.

- The method throws an exception if a null dictionary is passed in.

- Note that the method assumes that the character is in the
dictionary and will throw an exception if it is not.

#### Method information
|            |                                                 |
|------------|-------------------------------------------------|
| Name       | ConsumeCharFromCharCountDict                    |
| Parameters | The dictionary                                  |
|            | The character to consume                        |
| Returns    | None                                            |

#### Steps
1. Check whether the input dictionary is null, if so throw an
exception.

2. Get the count of the character from the dictionary, if the
count is greater than one, decrement it, if the count is one
then delete the entry in the dictionary.

#### Complexity
Time: O(1)  
Space: O(1)  

---

## Notes
- This algorithm could be modified to add permutations that don't use all chars
by updating the helper method to add the result even if not out of characters.
