using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Matrix.TicTacWin
{
    /// <summary>
    /// This class tests HasWon
    /// </summary>
    [TestClass]
    public class TicTacWin1BruteForceCompleteTests
    {
        /// <summary>
        /// Tests a case in which there is no winner because the board is empty.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3NoWinnerEmpty()
        {
            var board = new[,]
            {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };
            Assert.AreEqual(0, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which there is no winner.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3NoWinner1()
        {
            var board = new[,]
            {
                { -1, 1, -1 },
                { 1, 1, -1 },
                { 1, -1, 1 }
            };
            Assert.AreEqual(0, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which X wins via filling up row 0.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3XWinsByRow0()
        {
            var board = new[,]
            {
                { 1, 1, 1 },
                { -1, -1, 0 },
                { 0, 0, 0 }
            };
            Assert.AreEqual(1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which X wins via filling up row 1.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3XWinsByRow1()
        {
            var board = new[,]
            {
                { -1, -1, 0 },
                { 1, 1, 1 },
                { 0, 0, 0 }
            };
            Assert.AreEqual(1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which X wins via filling up row 2.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3XWinsByRow2()
        {
            var board = new[,]
            {
                { -1, -1, 0 },
                { 0, 0, 0 },
                { 1, 1, 1 }
            };
            Assert.AreEqual(1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which X wins via filling up column 0.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3XWinsByCol0()
        {
            var board = new[,]
            {
                { 1, -1, -1 },
                { 1, 0, 0 },
                { 1, 0, 0 }
            };
            Assert.AreEqual(1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which X wins via filling up column 1.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3XWinsByCol1()
        {
            var board = new[,]
            {
                { 0, 1, 0 },
                { -1, 1, 0 },
                { -1, 1, 0 }
            };
            Assert.AreEqual(1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which X wins via filling up column 2.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3XWinsByCol2()
        {
            var board = new[,]
            {
                { 0, 0, 1 },
                { -1, 0, 1 },
                { -1, 0, 1 }
            };
            Assert.AreEqual(1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which X wins via filling up the "down" diagonal.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3XWinsByDownDiag()
        {
            var board = new[,]
            {
                { 1, -1, -1 },
                { 0, 1, 0 },
                { 0, 0, 1 }
            };
            Assert.AreEqual(1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which X wins via filling up the "up" diagonal.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3XWinsByUpDiag()
        {
            var board = new[,]
            {
                { -1, -1, 1 },
                { 0, 1, 0 },
                { 1, 0, 0 }
            };
            Assert.AreEqual(1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which 0 wins via filling up row 0.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3OWinsByRow0()
        {
            var board = new[,]
            {
                { -1, -1, -1 },
                { 1, 1, 0 },
                { 0, 0, 0 }
            };
            Assert.AreEqual(-1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which O wins via filling up row 1.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3OWinsByRow1()
        {
            var board = new[,]
            {
                { 1, 1, 0 },
                { -1, -1, -1 },
                { 0, 0, 0 }
            };
            Assert.AreEqual(-1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which O wins via filling up row 2.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3OWinsByRow2()
        {
            var board = new[,]
            {
                { 1, 1, 0 },
                { 0, 0, 0 },
                { -1, -1, -1 }
            };
            Assert.AreEqual(-1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which O wins via filling up column 0.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3OWinsByCol0()
        {
            var board = new[,]
            {
                { -1, 1, 1 },
                { -1, 0, 0 },
                { -1, 0, 0 }
            };
            Assert.AreEqual(-1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which O wins via filling up column 1.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3OWinsByCol1()
        {
            var board = new[,]
            {
                { 0, -1, 0 },
                { 1, -1, 0 },
                { 1, -1, 0 }
            };
            Assert.AreEqual(-1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which O wins via filling up column 2.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3OWinsByCol2()
        {
            var board = new[,]
            {
                { 0, 0, -1 },
                { 1, 0, -1 },
                { 1, 0, -1 }
            };
            Assert.AreEqual(-1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which O wins via filling up the "down" diagonal.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3OWinsByDownDiag()
        {
            var board = new[,]
            {
                { -1, 1, 1 },
                { 0, -1, 0 },
                { 0, 0, -1 }
            };
            Assert.AreEqual(-1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which O wins via filling up the "up" diagonal.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon3by3OWinsByUpDiag()
        {
            var board = new[,]
            {
                { 1, 1, -1 },
                { 0, -1, 0 },
                { -1, 0, 0 }
            };
            Assert.AreEqual(-1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which there is no winner because the board is empty for a 2x2 board.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon2by2NoWinnerEmpty()
        {
            var board = new[,]
            {
                { 0, 0 },
                { 0, 0 }
            };
            Assert.AreEqual(0, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which there is no winner because the board is empty for a 4x4 board.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon4by4NoWinnerEmpty()
        {
            var board = new[,]
            {
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };
            Assert.AreEqual(0, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which X wins for a 2x2 board.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon2by2XWins()
        {
            var board = new[,]
            {
                { 1, 1 },
                { 0, -1 }
            };
            Assert.AreEqual(1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which X wins for a 4x4 board.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon4by4XWins()
        {
            var board = new[,]
            {
                { 1, 1, 1, 1 },
                { -1, -1, -1, 0 },
                { 0, 0, 0, -1 },
                { 0, 0, 0, 0 }
            };
            Assert.AreEqual(1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which O wins for a 2x2 board.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon2by2OWins()
        {
            var board = new[,]
            {
                { -1, -1 },
                { 0, 1 }
            };
            Assert.AreEqual(-1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which O wins for a 4x4 board.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteHasWon4by4OWins()
        {
            var board = new[,]
            {
                { -1, -1, -1, -1 },
                { 1, 1, 1, 0 },
                { 0, 0, 0, 1 },
                { 0, 0, 0, 0 }
            };
            Assert.AreEqual(-1, TicTacWin1BruteForceComplete.HasWon(board));
        }

        /// <summary>
        /// Tests a case in which the board is too small.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteErrorSmallBoard()
        {
            var board = new[,]
            {
                { 0 }
            };

            try
            {
                TicTacWin1BruteForceComplete.HasWon(board);
            }
            catch
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests a case in which the board is too small.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteErrorNonSquareBoard()
        {
            var board = new[,]
            {
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };

            try
            {
                TicTacWin1BruteForceComplete.HasWon(board);
            }
            catch
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests the null board case.
        /// </summary>
        [TestMethod]
        public void TestTicTacWin1BruteForceCompleteErrorNullBoard()
        {
            try
            {
                TicTacWin1BruteForceComplete.HasWon(null);
            }
            catch
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }
    }
}