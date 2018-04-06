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

        /// <summary>
        /// Tree2
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree2;

        /// <summary>
        /// Tree3
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree3;

        /// <summary>
        /// Tree4
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree4;

        /// <summary>
        /// Tree5
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree5;

        /// <summary>
        /// Tree6
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree6;

        /// <summary>
        /// Tree7
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree7;

        /// <summary>
        /// Tree8
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree8;

        /// <summary>
        /// Tree9
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree9;

        /// <summary>
        /// Tree10
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree10;

        /// <summary>
        /// Tree11
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree11;

        /// <summary>
        /// Tree12
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree12;

        /// <summary>
        /// Tree13
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree13;

        /// <summary>
        /// Tree14
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree14;

        /// <summary>
        /// Tree15
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree15;

        /// <summary>
        /// Tree16
        /// </summary>
        public static readonly BinaryTreeNode<int> Tree16;

        /// <summary>
        /// SubTree41
        /// </summary>
        public static readonly BinaryTreeNode<int> SubTree41;

        /// <summary>
        /// SubTree51
        /// </summary>
        public static readonly BinaryTreeNode<int> SubTree51;

        /// <summary>
        /// SubTree111
        /// </summary>
        public static readonly BinaryTreeNode<int> SubTree111;

        /// <summary>
        /// SubTree121
        /// </summary>
        public static readonly BinaryTreeNode<int> SubTree121;

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

            // tree3 (2 level - right node only)
            //   2
            //   | 1
            // Height = 2
            // IsBST = True
            // Balanced = True
            // Complete = False
            // Full = False
            // Perfect = False
            Tree3 = new BinaryTreeNode<int>(2)
            {
                Right = new BinaryTreeNode<int>(1)
            };

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
            SubTree41 = Tree4.Right;

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
            SubTree51 = Tree5.Right;

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
            };
            Tree10.Left.Left = new BinaryTreeNode<int>(5);
            Tree10.Left.Right = new BinaryTreeNode<int>(8);
            Tree10.Right = new BinaryTreeNode<int>(15);

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
            SubTree111 = Tree11.Right.Left;

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
                    }
                }
            };
            Tree12.Left.Right = new BinaryTreeNode<int>(11)
            {
                Left = new BinaryTreeNode<int>(10),
                Right = new BinaryTreeNode<int>(12)
            };
            Tree12.Right = new BinaryTreeNode<int>(23)
            {
                Left = new BinaryTreeNode<int>(17),
                Right = new BinaryTreeNode<int>(25)
            };
            Tree12.Right.Left.Left = new BinaryTreeNode<int>(16);
            Tree12.Right.Left.Right = new BinaryTreeNode<int>(18);
            Tree12.Right.Right.Left = new BinaryTreeNode<int>(24);
            Tree12.Right.Right.Right = new BinaryTreeNode<int>(26);
            SubTree121 = Tree12.Right;

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
                    },
                },
                Right = new BinaryTreeNode<int>(3)
                {
                    Left = new BinaryTreeNode<int>(6)
                    {
                        Left = new BinaryTreeNode<int>(11),
                        Right = new BinaryTreeNode<int>(12)
                    },
                }
            };
        }
    }
}
