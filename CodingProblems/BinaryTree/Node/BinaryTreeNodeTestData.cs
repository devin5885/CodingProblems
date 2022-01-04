using System.Collections.Generic;

#pragma warning disable SA1600
#pragma warning disable 1591
namespace CodingProblems.BinaryTree.Node
{
    /// <summary>
    /// Binary tree instances for testing.
    /// </summary>
    public static class BinaryTreeNodeTestData
    {
        /// <summary>
        /// Tree1
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree1;
        public static readonly List<int> Tree1PreOrder;
        public static readonly List<int> Tree1InOrder;
        public static readonly List<int> Tree1PostOrder;

        /// <summary>
        /// Tree2
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree2;
        public static readonly List<int> Tree2PreOrder;
        public static readonly List<int> Tree2InOrder;
        public static readonly List<int> Tree2PostOrder;

        /// <summary>
        /// Tree3
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree3;
        public static readonly List<int> Tree3PreOrder;
        public static readonly List<int> Tree3InOrder;
        public static readonly List<int> Tree3PostOrder;

        /// <summary>
        /// Tree4
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree4;
        public static readonly List<int> Tree4PreOrder;
        public static readonly List<int> Tree4InOrder;
        public static readonly List<int> Tree4PostOrder;

        /// <summary>
        /// Tree5
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree5;
        public static readonly List<int> Tree5PreOrder;
        public static readonly List<int> Tree5InOrder;
        public static readonly List<int> Tree5PostOrder;

        /// <summary>
        /// Tree6
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree6;
        public static readonly List<int> Tree6PreOrder;
        public static readonly List<int> Tree6InOrder;
        public static readonly List<int> Tree6PostOrder;

        /// <summary>
        /// Tree7
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree7;
        public static readonly List<int> Tree7PreOrder;
        public static readonly List<int> Tree7InOrder;
        public static readonly List<int> Tree7PostOrder;

        /// <summary>
        /// Tree8
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree8;
        public static readonly List<int> Tree8PreOrder;
        public static readonly List<int> Tree8InOrder;
        public static readonly List<int> Tree8PostOrder;

        /// <summary>
        /// Tree9
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree9;
        public static readonly List<int> Tree9PreOrder;
        public static readonly List<int> Tree9InOrder;
        public static readonly List<int> Tree9PostOrder;

        /// <summary>
        /// Tree10
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree10;
        public static readonly List<int> Tree10PreOrder;
        public static readonly List<int> Tree10InOrder;
        public static readonly List<int> Tree10PostOrder;

        /// <summary>
        /// Tree11
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree11;
        public static readonly List<int> Tree11PreOrder;
        public static readonly List<int> Tree11InOrder;
        public static readonly List<int> Tree11PostOrder;

        /// <summary>
        /// Tree12
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree12;
        public static readonly List<int> Tree12PreOrder;
        public static readonly List<int> Tree12InOrder;
        public static readonly List<int> Tree12PostOrder;

        /// <summary>
        /// Tree13
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree13;
        public static readonly List<int> Tree13PreOrder;
        public static readonly List<int> Tree13InOrder;
        public static readonly List<int> Tree13PostOrder;

        /// <summary>
        /// Tree14
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree14;
        public static readonly List<int> Tree14PreOrder;
        public static readonly List<int> Tree14InOrder;
        public static readonly List<int> Tree14PostOrder;

        /// <summary>
        /// Tree15
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree15;

        /// <summary>
        /// Tree16
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree16;

        /// <summary>
        /// TreeSubTree41
        /// </summary>
        public static readonly BinaryTreeNode<int> TreeSubTree41;

        /// <summary>
        /// TreeSubTree51
        /// </summary>
        public static readonly BinaryTreeNode<int> TreeSubTree51;

        /// <summary>
        /// TreeSubTree111
        /// </summary>
        public static readonly BinaryTreeNode<int> TreeSubTree111;

        /// <summary>
        /// TreeSubTree121
        /// </summary>
        public static readonly BinaryTreeNode<int> TreeSubTree121;

        /// <summary>
        /// Sample Data Tree 1
        /// </summary>
        public static readonly BinaryTreeNode<int> TreeFromSampleData1;
        public static readonly List<int> TreeFromSampleData1PreOrder;
        public static readonly List<int> TreeFromSampleData1InOrder;
        public static readonly List<int> TreeFromSampleData1PostOrder;

        static BinaryTreeNodeTestData()
        {
            // tree1 (1 level)
            //   1
            // Height = 1
            // IsBST = True
            // Balanced = True
            // Complete = True
            // Full = True
            // Perfect = True
            Tree1 = new BinaryTreeNode<int>(1);

            Tree1PreOrder = new List<int> { 1 };
            Tree1InOrder = new List<int> { 1 };
            Tree1PostOrder = new List<int> { 1 };

            // Tree2 (2 level - left node only)
            //   2
            // 1 |
            // Height = 2
            // IsBST = True
            // Balanced = True
            // Complete = True
            // Full = False
            // Perfect = False
            Tree2 = new BinaryTreeNode<int>(2)
            {
                Left = new BinaryTreeNode<int>(1)
            };

            Tree2PreOrder = new List<int> { 2, 1 };
            Tree2InOrder = new List<int> { 1, 2 };
            Tree2PostOrder = new List<int> { 1, 2 };

            // tree3 (2 level - right node only)
            //   2
            //   | 1
            // Height = 2
            // IsBST = False
            // Balanced = True
            // Complete = False
            // Full = False
            // Perfect = False
            Tree3 = new BinaryTreeNode<int>(2)
            {
                Right = new BinaryTreeNode<int>(1)
            };

            Tree3PreOrder = new List<int> { 2, 1 };
            Tree3InOrder = new List<int> { 2, 1 };
            Tree3PostOrder = new List<int> { 1, 2 };

            // Tree4 (Simple 2 level)
            //   2
            // 1 | 3
            // Height = 2
            // IsBST = True
            // Balanced = True
            // Complete = True
            // Full = True
            // Perfect = True
            Tree4 = new BinaryTreeNode<int>(2)
            {
                Left = new BinaryTreeNode<int>(1),
                Right = new BinaryTreeNode<int>(3)
            };
            TreeSubTree41 = Tree4.Right;

            Tree4PreOrder = new List<int> { 2, 1, 3 };
            Tree4InOrder = new List<int> { 1, 2, 3 };
            Tree4PostOrder = new List<int> { 1, 3, 2 };

            // tree5 (Simple 3 level, perfect, BST).
            //           10
            //     7     |     15
            //   4 | 8       11 | 18
            // Height = 3
            // IsBST = True
            // Balanced = True
            // Complete = True
            // Full = True
            // Perfect = True
            Tree5 = new BinaryTreeNode<int>(10)
            {
                Left = new BinaryTreeNode<int>(7)
                {
                    Left = new BinaryTreeNode<int>(4),
                    Right = new BinaryTreeNode<int>(8)
                },
                Right = new BinaryTreeNode<int>(15)
                {
                    Left = new BinaryTreeNode<int>(11),
                    Right = new BinaryTreeNode<int>(18)
                }
            };
            TreeSubTree51 = Tree5.Right;

            Tree5PreOrder = new List<int> { 10, 7, 4, 8, 15, 11, 18 };
            Tree5InOrder = new List<int> { 4, 7, 8, 10, 11, 15, 18 };
            Tree5PostOrder = new List<int> { 4, 8, 7, 11, 18, 15, 10 };

            // tree6 (Simple 3 level, perfect, non-BST)
            //           10
            //     7     |     15
            //   8 | 9       11 | 18
            // Height = 3
            // IsBST = False (BST failure on left node)
            // Balanced = True
            // Complete = True
            // Full = True
            // Perfect = True
            Tree6 = new BinaryTreeNode<int>(10)
            {
                Left = new BinaryTreeNode<int>(7)
                {
                    Left = new BinaryTreeNode<int>(8),
                    Right = new BinaryTreeNode<int>(9)
                },
                Right = new BinaryTreeNode<int>(15)
                {
                    Left = new BinaryTreeNode<int>(11),
                    Right = new BinaryTreeNode<int>(18)
                }
            };

            Tree6PreOrder = new List<int> { 10, 7, 8, 9, 15, 11, 18 };
            Tree6InOrder = new List<int> { 8, 7, 9, 10, 11, 15, 18 };
            Tree6PostOrder = new List<int> { 8, 9, 7, 11, 18, 15, 10 };

            // Tree7 (Simple 3 level perfect, non-BST)
            //           10
            //     7     |     15
            //   5 | 6       11 | 18
            // Height = 3
            // IsBST = False (BST failure on right node)
            // Balanced = True
            // Complete = True
            // Full = True
            // Perfect = True
            Tree7 = new BinaryTreeNode<int>(10)
            {
                Left = new BinaryTreeNode<int>(7)
                {
                    Left = new BinaryTreeNode<int>(5),
                    Right = new BinaryTreeNode<int>(6)
                },
                Right = new BinaryTreeNode<int>(15)
                {
                    Left = new BinaryTreeNode<int>(11),
                    Right = new BinaryTreeNode<int>(18)
                }
            };

            Tree7PreOrder = new List<int> { 10, 7, 5, 6, 15, 11, 18 };
            Tree7InOrder = new List<int> { 5, 7, 6, 10, 11, 15, 18 };
            Tree7PostOrder = new List<int> { 5, 6, 7, 11, 18, 15, 10 };

            // tree8 (3 level, not full, all leafs on same level)
            //           10
            //     7     |     15
            //   4 | 8       11 |
            // Height = 3
            // IsBST = True
            // Balanced = True
            // Complete = True - Last level filled from left to right.
            // Full = False - Node has only one child.
            // Perfect = False (Not complete or full).
            Tree8 = new BinaryTreeNode<int>(10)
            {
                Left = new BinaryTreeNode<int>(7)
                {
                    Left = new BinaryTreeNode<int>(4),
                    Right = new BinaryTreeNode<int>(8)
                },
                Right = new BinaryTreeNode<int>(15)
                {
                    Left = new BinaryTreeNode<int>(11)
                }
            };

            Tree8PreOrder = new List<int> { 10, 7, 4, 8, 15, 11 };
            Tree8InOrder = new List<int> { 4, 7, 8, 10, 11, 15 };
            Tree8PostOrder = new List<int> { 4, 8, 7, 11, 15, 10 };

            // Tree9 (3 level, not full, not complete, all leafs on same level)
            //           10
            //     7     |     15
            //     | 9          | 18
            // Height = 3
            // IsBST = True
            // Balanced = True
            // Complete = False - Last level not filled from left to right.
            // Full = False - Node has 1 child.
            // Perfect = False (Not complete or full)
            Tree9 = new BinaryTreeNode<int>(10)
            {
                Left = new BinaryTreeNode<int>(7)
                {
                    Right = new BinaryTreeNode<int>(9)
                },
                Right = new BinaryTreeNode<int>(15)
                {
                    Right = new BinaryTreeNode<int>(18)
                }
            };

            Tree9PreOrder = new List<int> { 10, 7, 9, 15, 18 };
            Tree9InOrder = new List<int> { 7, 9, 10, 15, 18 };
            Tree9PostOrder = new List<int> { 9, 7, 18, 15, 10 };

            // tree10 (3 level, full, and complete but not perfect, all leaves not at same level)
            //           10
            //     7     |     15
            //   5 | 8
            // Height = 3
            // IsBST = True
            // Balanced = True
            // Complete = True - All levels completely filled except last which is filled left to right.
            // Full = True - All nodes have 0 or 2 children.
            // Perfect = False - All leafs not at same level.
            Tree10 = new BinaryTreeNode<int>(10)
            {
                Left = new BinaryTreeNode<int>(7)
                {
                    Left = new BinaryTreeNode<int>(5),
                    Right = new BinaryTreeNode<int>(8)
                },
                Right = new BinaryTreeNode<int>(15)
            };

            Tree10PreOrder = new List<int> { 10, 7, 5, 8, 15 };
            Tree10InOrder = new List<int> { 5, 7, 8, 10, 15 };
            Tree10PostOrder = new List<int> { 5, 8, 7, 15, 10 };

            // Tree11 (4 level, non-filled node on non-last level)
            //           10
            //     7     |              15
            //     |  8          12     | 18
            //                 11 | 13
            // Height = 4
            // IsBST = True
            // Balanced = True
            // Complete = False - All levels are not completely filled.
            // Full = No - 1 node as only one child.
            // Perfect = False - Not complete or full, all leaves not at same level.
            Tree11 = new BinaryTreeNode<int>(10)
            {
                Left = new BinaryTreeNode<int>(7)
                {
                    Right = new BinaryTreeNode<int>(8)
                },
                Right = new BinaryTreeNode<int>(15)
                {
                    Left = new BinaryTreeNode<int>(12)
                    {
                        Left = new BinaryTreeNode<int>(11),
                        Right = new BinaryTreeNode<int>(13)
                    },
                    Right = new BinaryTreeNode<int>(18)
                }
            };
            TreeSubTree111 = Tree11.Right.Left;

            Tree11PreOrder = new List<int> { 10, 7, 8, 15, 12, 11, 13, 18 };
            Tree11InOrder = new List<int> { 7, 8, 10, 11, 12, 13, 15, 18 };
            Tree11PostOrder = new List<int> { 8, 7, 11, 13, 12, 18, 15, 10 };

            // tree12 (4 level, perfect)
            //                   15
            //        9          |               23
            //  6     |   11           17         |     25
            // 5 | 7    10 | 12      16 | 18         24  |  26
            // Height = 4
            // IsBST = True
            // Balanced = True
            // Complete = True
            // Full = True
            // Perfect = True
            Tree12 = new BinaryTreeNode<int>(15)
            {
                Left = new BinaryTreeNode<int>(9)
                {
                    Left = new BinaryTreeNode<int>(6)
                    {
                        Left = new BinaryTreeNode<int>(5),
                        Right = new BinaryTreeNode<int>(7)
                    },
                    Right = new BinaryTreeNode<int>(11)
                    {
                        Left = new BinaryTreeNode<int>(10),
                        Right = new BinaryTreeNode<int>(12)
                    }
                },
                Right = new BinaryTreeNode<int>(23)
                {
                    Left = new BinaryTreeNode<int>(17),
                    Right = new BinaryTreeNode<int>(25)
                }
            };
            Tree12.Right.Left.Left = new BinaryTreeNode<int>(16);
            Tree12.Right.Left.Right = new BinaryTreeNode<int>(18);
            Tree12.Right.Right.Left = new BinaryTreeNode<int>(24);
            Tree12.Right.Right.Right = new BinaryTreeNode<int>(26);
            TreeSubTree121 = Tree12.Right;

            Tree12PreOrder = new List<int> { 15, 9, 6, 5, 7, 11, 10, 12, 23, 17, 16, 18, 25, 24, 26 };
            Tree12InOrder = new List<int> { 5, 6, 7, 9, 10, 11, 12, 15, 16, 17, 18, 23, 24, 25, 26 };
            Tree12PostOrder = new List<int> { 5, 7, 6, 10, 12, 11, 9, 16, 18, 17, 24, 26, 25, 23, 15 };

            // Tree13 (Non-balanced root)
            //     1
            //   2 |
            // 3 |
            // Height = 3
            // IsBST = False
            // Balanced = False
            // Complete = False (All levels not completely filled).
            // Full = False (Node with on child).
            // Perfect = False
            Tree13 = new BinaryTreeNode<int>(1)
            {
                Left = new BinaryTreeNode<int>(2)
                {
                    Left = new BinaryTreeNode<int>(3)
                }
            };

            Tree13PreOrder = new List<int> { 1, 2, 3 };
            Tree13InOrder = new List<int> { 3, 2, 1 };
            Tree13PostOrder = new List<int> { 3, 2, 1 };

            // Tree14 (4 level)
            //          1
            //        2 |  3
            //      4 |  5 |
            //    6 |   7 |
            // Height = 4
            // IsBST = No
            // Balanced = False - Sub-trees not balanced.
            // Complete = False - All levels are not completely filled.
            // Full =  No - Some nodes have only one child.
            // Perfect = False
            Tree14 = new BinaryTreeNode<int>(1)
            {
                Left = new BinaryTreeNode<int>(2)
                {
                    Left = new BinaryTreeNode<int>(4)
                    {
                        Left = new BinaryTreeNode<int>(6)
                    }
                },
                Right = new BinaryTreeNode<int>(3)
                {
                    Left = new BinaryTreeNode<int>(5)
                    {
                        Left = new BinaryTreeNode<int>(7)
                    }
                }
            };

            Tree14PreOrder = new List<int> { 1, 2, 4, 6, 3, 5, 7 };
            Tree14InOrder = new List<int> { 6, 4, 2, 1, 7, 5, 3 };
            Tree14PostOrder = new List<int> { 6, 4, 2, 7, 5, 3, 1 };

            // Tree15 (3 level) with missing left on last level.
            //             1
            //        2    |   3
            //        | 4     5 | 6
            // Height = 3
            // IsBST = No
            // Balanced = True
            // Complete = False
            // Full = False
            // Perfect = False
            Tree15 = new BinaryTreeNode<int>(1)
            {
                Left = new BinaryTreeNode<int>(2)
                {
                    Right = new BinaryTreeNode<int>(4)
                },
                Right = new BinaryTreeNode<int>(3)
                {
                    Left = new BinaryTreeNode<int>(5),
                    Right = new BinaryTreeNode<int>(6)
                }
            };

            // Tree16 (4 level) Missing right on non-last level.
            //                     1
            //             2       |          3
            //         4   |   5         6    |
            //       7 | 8   9 | 10   11 | 12
            // Height = 4
            // IsBST = No
            // Balanced = False
            // Complete = False
            // Full = False
            // Perfect = False
            Tree16 = new BinaryTreeNode<int>(1)
            {
                Left = new BinaryTreeNode<int>(2)
                {
                    Left = new BinaryTreeNode<int>(4)
                    {
                        Left = new BinaryTreeNode<int>(7),
                        Right = new BinaryTreeNode<int>(8)
                    },
                    Right = new BinaryTreeNode<int>(5)
                    {
                        Left = new BinaryTreeNode<int>(9),
                        Right = new BinaryTreeNode<int>(10)
                    }
                },
                Right = new BinaryTreeNode<int>(3)
                {
                    Left = new BinaryTreeNode<int>(6)
                    {
                        Left = new BinaryTreeNode<int>(11),
                        Right = new BinaryTreeNode<int>(12)
                    }
                }
            };

            // TreeFromSampleData1
            //                     2
            //             0       |      3
            //             | 1            |     5
            //                               4  |
            // Height = 4
            // IsBST = Yes
            TreeFromSampleData1 = new BinaryTreeNode<int>(2)
            {
                Left = new BinaryTreeNode<int>(0)
                {
                    Right = new BinaryTreeNode<int>(1)
                },
                Right = new BinaryTreeNode<int>(3)
                {
                    Right = new BinaryTreeNode<int>(5)
                    {
                        Left = new BinaryTreeNode<int>(4)
                    }
                }
            };

            TreeFromSampleData1PreOrder = new List<int> { 2, 0, 1, 3, 5, 4 };
            TreeFromSampleData1InOrder = new List<int> { 0, 1, 2, 3, 4, 5 };
            TreeFromSampleData1PostOrder = new List<int> { 1, 0, 4, 5, 3, 2 };
        }
    }
}
#pragma warning restore 1591
#pragma warning restore SA1600

