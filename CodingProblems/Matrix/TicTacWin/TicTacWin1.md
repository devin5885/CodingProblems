# Tic-Tac-Win - Solution 1 Brute Force

## Additional Requirements

---

## Implementation
- We will represent the board as a 3x3 matrix of integers, 0 will indicate
that the space is empty, 1 will indicate an X, -1 will indicate an O.

### HasWon

#### Steps
1. ERROR CHECK - Check whether the board is null, if so throw an exception.

2. ERROR CHECK - Check whether the board's dimensions don't match if so
throw an exception.

3. ERROR CHECK - Check whether the board's dimensions are less than 2
, if so throw an exception.

4. LOOP - For each of the rows call GetRowSum to get the sum of the
row, then call CheckSum to check the sum. If the sum indicates a win
return the appropriate winning result.

5. LOOP - For each of the column call GetColumnSum to get the sum of the
row, then call CheckSum to check the sum. If the sum indicates a win
return the appropriate winning result.

6. Get the sum of the "down" diagonal (L->R) and check whether the sum
indicates a win return the appropriate winning result.

7. Get the sum of the "up" diagonal (L->R) and check whether the sum
indicates a win return the appropriate winning result.

8. Return 0 since there is no winner.

#### Complexity
Time: O(n^2^)
Space: O(1)

---

### GetRowSum

|            |                                                                                                         |
|------------|-------------------------------|
| Name       | GetRowSum                     |
| Parameters | The board as an n x n array   |
|            | The row Index                 |
| Returns    | The sum                       |

---

### GetColumnSum

|            |                                                                                                         |
|------------|-------------------------------|
| Name       | GetColumnSum                  |
| Parameters | The board as an n x n array   |
|            | The column Index              |
| Returns    | The sum                       |

---

### GetDiagonalSum

|            |                                                                                                         |
|------------|----------------------------------------|
| Name       | GetDiagonalSum                         |
| Parameters | The board as an n x n array            |
|            | Whether to get the "down" or "up" sum. |
| Returns    | The sum                       |

---

### CheckSum

|            |                                                                                                         |
|------------|----------------------------------------|
| Name       | CheckSum                               |
| Parameters | The board as an n x n array            |
|            | The sum                                |
| Returns    | 1 if X won, -1 if O won, otherwise -1  |

---

## Notes
- Since there are only 8 ways to win for a 3x3 board, we will test this completely.