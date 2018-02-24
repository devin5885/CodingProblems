# Multiple Stacks Using Single Array

### Problem
Implement multiple (3) stacks using a single array.

### Notes
- The following operations should be defined: Push, Pop, Peek, Count. The
stack # should be able to be specified in the call.
- No need to clear removed elements in stack.

### Solutions:
1. Fixed size stack - The stacks have a maximum size set during construction.

### Solution 1 - Fixed Size Stacks

#### Solution Specific Assumptions
- The capacity of the stacks in the same for each stack & is fixed (Set at construction).
- Since stack capacity for each stack is fixed a particular stack can run out of space w/o the other stacks being full.

##### Overview
Implement the stacks using an array. Use the same algorithm as a the single
stack approach with the following changes:  
- Update the stack constructor to take the # of stacks as well as the size of
each stack. Take the size of the stacks instead of the overall size to ensure
that the total size is a multiple of the # of stacks.
- Instead of a single Stack Pointer variable extend this to an array of stack
pointer variables, these variables will indicate the current item for the stack.
- In order to make the Stack Pointer variables work consistently, create an
array of Stack Pointer offset values, this value will indicate the starting
offset for that stack. Thus to get the actual index of the current item 
it it will be necessary to add the current Stack Pointer value to the offset.

#### Alg
Constructor:
1. Take the stack size & # of stacks as a parameter.
2. Construct an array of the appropriate size for all the stacks.
3. Create a Stack Pointer array initialize all elements to -1.
4. Create a Stack Pointer array, set elements to the capacity per stack 
* the index # of the stack.

Push:  
1. Take the stack # as a parameter (0 based).
2. Check whether there is space in the specified stack for a new element, if not throw.
3. Add the new element to the array element one past the stack pointer for the stack #.
4. Incrment the stack pointer for the stack # to point to the new item.

Pop:
1. Take the stack # as a parameter (0 based).
2. Check whether there are any elements in the specified stack, if not throw.
3. Return the element pointed to by the stack pointer for the stack # & decrement the stack pointer.

Peek:
1. Take the stack # as a parameter (0 based).
2. Check whether there are any elements in the specified stack, if not throw.
3. Return the element pointed to by the stack pointer for the stack.

#### Big O
Creation:
Time - O(1)  
Space - O(Capacity)  

Push:
Time - O(1)  
Space - O(0)  

Pop:
Time - O(1)  
Space - O(0)  

Peek:
Time - O(1)  
Space - O(0)  

Count:
Time - O(1)  
Space - O(0)  

#### Notes
- This solution requires alot more test cases & does not provide much benifit over the single array per-stack.
- Design Question - What should the parameter order be for Push, Stack # first then value?
- Design Question - Should we allow a default for Stack #?
- The variable stack size is similiar to this problem, but reallocates & copies the array if the stack gets too big.
- The variable stack size, with variable individual stack sizes problem is much more complex.