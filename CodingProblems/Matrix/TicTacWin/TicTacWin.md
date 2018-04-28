# Tic Tac Win

- From Cracking the Coding Interview, Interview Questions 16.4

## Problem
Design an algorithm to figure out if someone has won a game of tic-tac-toe.

## Requirements
- Since the general algorithm for an n by n matrix will work for the
3x3 matrix, we will implement the general algorithm only.

- A requirement for the n x n board is that the # of rows and columns are
the same. The method should throw an exception if this is not the case.

- The board must have at least 2 rows and 2 columns, the method will
throw an algorithm if this is not the case.

- We will represent the board as a matrix of integers, 0 will indicate
that the space is empty, 1 will indicate an X, -1 will indicate an O.

- We will NOT validate the fact that both players have made the correct #
of moves. (i.e.) there should not be more than 1 X and O or vice-versa.

- The method should work correctly if either player wins by more than
one direction.

- Method to implement:  

|            |                                                               |
|------------|---------------------------------------------------------------|
| Name       | HasWon                                                        |
| Parameters | The board as an n x n array                                   |
| Returns    | Who has won, 1 for X, -1 for O                                |

## Solutions
1. Brute Force - Analyze the matrix.

## Notes
- There are 2n + 2 ways to win. (i.e.) n rows + n columns + 2 diagonal wins.

- CtCI includes a solution in which all possible board combinations are
mapped to integer values and written to a map, however it is very expensive
 to build this data structure especially for a larger matrix, so this would only
be adventurous if we needed to check allot of boards very quickly. 
