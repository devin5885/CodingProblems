# Queue Via Stacks

## Problem
Implement a queue using two stacks.

## Notes
- From Cracking the Coding Interview, Interview Questions 3.4

- The following operations should be defined:
  
Construction - Construct the queue.
Enqueue - Add an item to the queue.
Dequeue - Dequeues the top item in the queue.
Peek - Peek at the top item in the queue.
Count - Gets the count of the items in the queue.

## Solutions
1. Simple - In this solution we use a single stack to store items. When an item is requested we simply move items to a temporary stack, get the requested item, & then copy back to the original stack.
2. Optimized - In this solution we use a two stacks to store items. 
