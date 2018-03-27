# Compress Simple - Solution 1 - Standard

## Additional Requirements

---

## Implementation

---

### CompressSimple

#### Steps
1. Check whether the list is null, if so throw an exception.

2. Initialize output list.

3. Initialize the current element count to 1 (Since we
start with one instance).

3. Iterate through the list one element at time.

4. Get the current element & the next element (or null if
there is no next element).

5. If the next element is available compare the current
element and the next element. If they match increment the
count.

6. If the next element is not available or they do not
match output the count and the element to the output list.

7. Reset the counter.

8. Continue through all elements in the list.

9. Return the resulting list.

---

## Complexity
Time: O(n) where n is the length of the list.  
Space: O(n) where n is the length of the list.  

---

## Notes
