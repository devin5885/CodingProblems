# StackUsingArray

## Problem
Implement a stack using an array (fixed size).

## Overview
- If a variable sized data structure is used then the problem is trivial,
just add & take from the data structure as needed.

- The following operations should be defined:
  
Construction - Construct the object containing the stacks.  
Push - Add an item to one of the stacks.  
Pop - Pop an item from one of the stacks.  
Peek - Peek at the top item in one of the stacks.  
Count - Get the count of one of the stacks.  

## Assumptions
- No need to clear (zero) popped elements in the array itself. These elements will
automatically be overridden with new elements when the array slot is next
used.

## Solutions
1. Fixed size stack - A stack is implemented that has a maximum size set during construction.
2. Variable size stack - A stack is implemented that can grow as needed.