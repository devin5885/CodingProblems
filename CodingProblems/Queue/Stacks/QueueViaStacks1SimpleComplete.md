# Solution 1 - Simple

## Solution Specific Assumptions

## Overview
In this solution we use a single stack to store items. When an item is
requested we simply move items to a temporary stack, get the requested
 item, & then copy back to the original stack.

## Algorithms for Operations Overview

### Construction
Parameters: None.
1. Create the main stack.
Returns: None.

### Enqueue
Parameters: The item to enqueue.
1. Add item to stack.
Returns: None.

### Dequeue
Parameters: None.
1. Move items to temporary stack.
2. Pop the first item in the temporary stack.
3. Move items back to the main stack.
Returns: The popped item.

### Peek
Parameters: None.
1. Move items to temporary stack.
2. Peek at the first item in the temporary stack.
3. Move items back to the main stack.
Returns: The peeked item.

### Count
Parameters: None.
1. Get the count of the stack.
Returns: The count of the stack.

## Big O
n = # of items currently in the queue.

### Constructor
Time - O(1)
Space - O(1)

### Enqueue
Time - O(1)  
Space - O(1)  

### Dequeue
Time - O(n)  
Space - O(n)  

### Peek
Time - O(n)  
Space - O(n)  

### Count
Time - O(1)  
Space - O(0)  

### Notes
- Cracking the Coding Interview does not show this solution but mentions it.
- This is the simplest solution, but is inefficient since we need to move stack elements whenever a dequeue or peek operation occurs.
