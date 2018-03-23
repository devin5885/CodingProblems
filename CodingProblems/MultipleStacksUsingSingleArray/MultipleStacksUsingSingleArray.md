# Three in One

## Problem
Implement multiple (3) stacks using a single array.

(From Cracking the Coding Interview, Interview Questions 3.1)

## Overview
- The stacks should be identifiable via a 0-based stack index.

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
1. Fixed Size Stacks - The stacks have a maximum size set during construction.
2. Variable size stack - The stacks can grow as needed.