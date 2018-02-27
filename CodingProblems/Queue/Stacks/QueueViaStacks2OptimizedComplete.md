# Solution 2 - Optimized

## Solution Specific Assumptions

## Overview
In this solution we use a two stacks to store items. 
The first stack stores the newest items, the second stack stores older items.
When an item is requested we move items from the stack storing the newest
items to the stack storing the oldest items, we then get the first item
 in the oldest items stack.

The key to this algorithm working is that the elements can only be moved
 to the oldest stack when it is empty as otherwise the moved (newer) elements
 would take precedence over the existing (older) elements.
Also, elements are always added to the newer elements stack & always taken
 from the older elements stack.

## Algorithms for Operations Overview

### Construction
Parameters: None.
1. Creates the two stacks.
Returns: None.

### Enqueue
Parameters: The item to enqueue.
1. Add item to stack storing the newest items.
Returns: None.

### Dequeue
Parameters: None.
1. If the oldest items stack is empty move all items from the newest items stack to the oldest item stack.
2. Pop the first item in the oldest items stack.
Returns: The dequeued item.

### Peek
Parameters: None.
1. If the oldest items stack is empty move all items from the newest items stack to the oldest item stack.
2. Get the first item in the oldest items stack.
Returns: The peeked item.

### Count
Parameters: None.
1. Get the count of both stacks added together.
Returns: The count.

## Big O
n = # of items currently in the newest items queue.

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

## Notes
- Cracking the Coding Interview shows this solution. The provided solution is updated to match C# coding standards & the C# Stack class.
- This solution could be considerably more efficient for large stacks because the dequeue/peek method don't do as much moving of elements.