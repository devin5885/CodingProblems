# Find Matching Pairs - Solution 1 - Use Char Count Maps

## Additional Requirements
- Additional data structures can be used.

---

## Implementation

---

### FindMatchingPairs

#### Steps
1. Check whether either list is null, if so throw an exception.

2. Call the helper method BuildElementCountDictionary for each passed in list
to build a dictionary of character counts for each list.

3. Initialize the result list.

4. Iterate through the elements in the first dictionary, for each element check
whether it is in the second dictionary.

5. If the element is in both dictionaries, determine which instance count is lower
of the two lists and add that number of instances of that element to the
result list.

6. Return the result list.

---

### BuildElementCountDictionary

|            |                                                                                                         |
|------------|---------------------------------------------------------------------------------------------------------|
| Name       | BuildElementCountDictionary                                                                             |
| Parameters | The list                                                                                                |
| Returns    | A dictionary containing an entry for each element in the list & the count of instances of that element. |


#### Steps
1. Check whether the passed in list is null, if so throw an exception.

2. Create the dictionary.

3. Iterate through each element in the list.

4. If the element is in the dictionary, increment the count, if not add the
element to the dictionary.

5. Return the dictionary.


## Complexity
Time: O(n + m) where n is the count of the first list and m is the count of the second list.  
Space: O(n + m) where n is the count of the first list and m is the count of the second list.  

---

## Notes
- This is simple & efficient but does require two secondary data structures.