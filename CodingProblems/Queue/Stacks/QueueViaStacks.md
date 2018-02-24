# Queue Via Stacks

### Problem
Implement a queue using two stacks.

### Notes
- From Cracking the Coding Interview, Interview Questions 3.4

- The following operations should be defined: Enqueue, Dequeue, Peek, Count
- No need to clear removed elements in queue.

### Solution 1 - Simple

#### Solution Specific Assumptions

##### Overview
In this solution we use a single stack to store items. When an item is requested we simply move items to a temporary stack, get the requested item, & then copy back to the original stack.

#### Alg
Enqueue:
Add item to stack.

Dequeue:
Move items to temporary stack.
Pop the first item in the temporary stack.
Move items back to the main stack.
Return the poped item.

Peek:
Move items to temporary stack.
Peek at the first item in the temporary stack.
Move items back to the main stack.
Return the peeked item.

Count:
Return count of main stack.

#### Big O
n = # of items currently in the queue.
Enqueue:  
Time - O(1)  
Space - O(1)  

Dequeue:  
Time - O(2n)  
Space - O(1)  

Peek:  
Time - O(2n)  
Space - O(1)  

Count:  
Time - O(1)  
Space - O(0)  

#### Notes
- Cracking the Coding Interview does not show this solution but mentions it.
- This is the simplest solution, but is ineffiecient since we need to move stack elements whenever a dequeue or peek operation occurs.

### Solution 2 - Optimized

#### Solution Specific Assumptions

##### Overview
In this solution we use a two stacks to store items. 
The first stack stores the newest items, the second stack stores older items.
When an item is requested we move items from the stack storing the newest items to the stack storing the oldest items, we then get the first item in the oldest items stack.

The key to this algorithm working is that the elements can only be moved to the oldest stack when it is empty as otherwise the moved (newer) elements would take precedence over the existing (older) elements.
Also, elements are always added to the newer elements stack & always taken from the older elements stack.

#### Alg
Enqueue:
Add item to stack storing the newest items.

Dequeue:
If the oldest items stack is empty move all items from the newest items stack to the oldest item stack.
Pop the first item in the oldest items stack.
Return the poped item.

Peek:
If the oldest items stack is empty move all items from the newest items stack to the oldest item stack.
Get the first item in the oldest items stack.
Return the item.

Count:
Return count of both stacks added together.

#### Big O
n = # of items currently in the newest items queue.
Enqueue:  
Time - O(1)  
Space - O(1)  

Dequeue:  
Time - O(n)  
Space - O(1)  

Peek:  
Time - O(n)  
Space - O(1)  

Count:  
Time - O(1)  
Space - O(0)  

#### Notes
- Cracking the Coding Interview shows this solution. The provided solution is updated to match C# coding standards & the C# Stack class.
- This solution could be considerably more efficient for large stacks because the dequeue/peek method don't do as much moving of elements.