# Traverse Binary Tree - Solution 2 -Iterative

## Additional Requirements

---

## Implementation
- Traverse the tree iteratively using a helper function. Helper function is called once
it processes all nodes using a stack (to simulate the recursion call stack), three node states,
and a switch inside a loop. The loop continues while there are nodes in the stack to process.
The root node is pushed when the function begins, then the loop runs until there are no more
nodes in the stack.

Each loop pops and processes the top node in the stack. If the node is in the PreOrderPending state the function
readds the node to the stack with the next state, InOrderPending, writes to the result if appropriate
then adds the left child of the node to the stack. If the node is in the InOrderPending state the function
readds the node to the stack with the next state, PostOrderPending, writes the result if appropriate
and then adds right child of the node to the stack. If the node in the PostOrderPending state the function
simply writes the node value to the result if appropriate.

Note that for languages that have a stack or stack like data type which allows items to be modified
while in the stack, you can use Peek instead at the top of the loop to get the current node, then update
the state of the node at the top of the stack to the next state and Pop the node only after PostOrderPending
processing.

---

### Traverse

#### Steps
1. Create and initialize the return list.

2. If the tree passed in is null, return the empty list.

2. Call TraverseHelper to generate the list.

3. Return the list.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

### TraverseHelper

#### Steps
1. Check whether the passed in node is null, if so return.

2. Initialize a stack and push a record containing the root node and the
state of PreOrder into the stack.

3. While there are nodes in the stack, pop the current node from the stack
and check the traversal state of the node:

  - If the state is PreOrderPending:
    - Push the node back onto the stack with the status of InOrder.
    - If the traversal type is PreOrder add to the node to the result list.
    - If the node has a left child push it onto the stack.

  - If the state is InOrderPending:
    - Push the node back onto the stack with the status of PostOrder.
    - If the traversal type is InOrder add to the node to the result list.
    - If the node has a right child push it onto the stack.

  - If the state is PostOrderPending:
    - If the traversal type is PostOrder add to the node to the result list.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

## Notes