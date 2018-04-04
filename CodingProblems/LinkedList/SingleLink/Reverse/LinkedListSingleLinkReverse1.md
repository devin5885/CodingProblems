# Reverse - Solution 1

## Additional Requirements

---

## Implementation
We will detach the parts of the list that don't need to be reversed, then
reverse the remaining elements and then reattach the unattached parts of
the list.

---

### Reverse

#### Steps
1. If a start node was specified iterate through the list to find this node
and detach the part of the list to reverse from the previous nodes not
being reversed. If the start node was not specified default to the top
node in the list.

2. If the start node was specified but could not be found, throw an exception.

3. If an end node was specified iterate through the list until the end node
is found, otherwise iterate to the last node in the list. Once the end node
is found detach the additional nodes in the list (if any).

4. If the end node was specified but could not be found, throw an exception.

5. Call the ReverseHelper method to reverse the appropriate part of the list.

6. Reattach the reversed part of the list to the nodes above the start node
(If any).

7. Reattach the part of the list after the reversed nodes (if any).

#### Complexity
Time: O(n) where n is the count of elements in the list.  
Space: O(1)

---

### ReverseHelper
Simple helper method that reverses the entire list passed to it.

---

## Notes
