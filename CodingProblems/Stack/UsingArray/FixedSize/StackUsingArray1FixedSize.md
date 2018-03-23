# Fixed Size Stack Using Array

## Problem Summary
Implement a fixed size stack using a fixed size array.

## Requirements
- The stack has a maximum size set at construction.

- No need to clear (zero) popped elements in the internal array. These elements will
automatically be overridden with new elements when the array slot is next
used.

- A stack class should be defined that stores items of a specified type and has
the following public operations:
 
### Construction
Description: Construct the object implementing the stack  
Parameters: Per-stack size  
Returns: None  

### Push
Description: Add an item to the stack  
Parameters: Element to push  
Returns: None  

### Pop
Description: Pop an item from the stack  
Parameters: None  
Returns: The item  

### Peek
Description: Peek at the top item in the stack  
Parameters: None  
Returns: The item  

### Count
Description: Get the count of items in the stack  
Parameters: None  
Returns: The count  

## Implementation
To keep track of the current front of the stack an integer stack pointer will
be used this integer will contain the index of the current stack item or -1 if
the stack is empty.

When an item is pushed the element will be added & the stack pointer incremented. 
When an element is popped, the element at the stack pointer will be retrieved and
returned at the same time decrementing the stack pointer.

Note: s = Capacity of the stack

### Constructor

Steps:
1. Construct an array of the appropriate size
2. Initialize the Stack Pointer to -1

Time Complexity: O(1)  
Space Complexity: O(s)   

### Push

Steps:
1. Check whether there is space in the stack for a new element, if not throw
2. Add the new element to the array element one past the stack pointer
3. Increment the stack pointer to point to the new item

Time Complexity: O(1)  
Space Complexity: O(0)  

### Pop

Steps:
1. Check whether there are any elements in the stack, if not throw
2. Return the element pointed to by the stack pointer & decrement the stack pointer

Time Complexity: O(1)  
Space Complexity: O(0)  

### Peek

Steps:
1. Check whether there are any elements in the stack, if not throw.
2. Return the element pointed to by the stack pointer.

Time Complexity: O(1)  
Space Complexity: O(0)  

### Count

Steps:
1. Get the count of the array & return.

Time Complexity: O(1)  
Space Complexity: O(0)  

#### Notes
- If a variable sized data structure is used then the problem is trivial,
just add & take from the data structure as needed.
- Enhancement: We could save space by waiting to construct the stack when an
element is first added, but this would make the code more complex.