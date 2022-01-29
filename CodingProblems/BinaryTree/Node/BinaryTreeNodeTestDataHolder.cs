using System.Collections.Generic;

#pragma warning disable SA1600
#pragma warning disable 1591
#pragma warning disable SA1516 // Elements must be separated by blank line
namespace CodingProblems.BinaryTree.Node
{
    /// <summary>
    /// Holder for test data.
    /// </summary>
    public static class BinaryTreeNodeTestDataHolder
    {
        static BinaryTreeNodeTestDataHolder()
        {
            Tree1 = new BinaryTreeNodeTestData
            {
                // Tree1 (1 level)
                //   1
                DisplayName = "Tree1",
                Height = 1,
                IsBST = true,
                Balanced = true,
                Complete = true,
                Full = true,
                Perfect = true,
                PreOrder = new List<int> { 1 },
                InOrder = new List<int> { 1 },
                PostOrder = new List<int> { 1 },

                Root = new BinaryTreeNode<int>(1)
            };

            Tree2 = new BinaryTreeNodeTestData
            {
                // Tree2 (2 level - left node only)
                //   2
                // 1 |
                DisplayName = "Tree2",
                Height = 2,
                IsBST = true,
                Balanced = true,
                Complete = true,
                Full = false,
                Perfect = false,
                PreOrder = new List<int> { 2, 1 },
                InOrder = new List<int> { 1, 2 },
                PostOrder = new List<int> { 1, 2 },

                Root = new BinaryTreeNode<int>(2)
                {
                    Left = new BinaryTreeNode<int>(1)
                }
            };

            Tree3 = new BinaryTreeNodeTestData
            {
                // Tree3 (2 level - right node only)
                //   2
                //   | 1
                DisplayName = "Tree3",
                Height = 2,
                IsBST = false,
                Balanced = true,
                Complete = false,
                Full = false,
                Perfect = false,

                PreOrder = new List<int> { 2, 1 },
                InOrder = new List<int> { 2, 1 },
                PostOrder = new List<int> { 1, 2 },

                Root = new BinaryTreeNode<int>(2)
                {
                    Right = new BinaryTreeNode<int>(1)
                }
            };

            Tree4 = new BinaryTreeNodeTestData
            {
                // Tree4 (Simple 2 level)
                //   2
                // 1 | 3
                DisplayName = "Tree4",
                Height = 2,
                IsBST = true,
                Balanced = true,
                Complete = true,
                Full = true,
                Perfect = true,

                PreOrder = new List<int> { 2, 1, 3 },
                InOrder = new List<int> { 1, 2, 3 },
                PostOrder = new List<int> { 1, 3, 2 },

                Root = new BinaryTreeNode<int>(2)
                {
                    Left = new BinaryTreeNode<int>(1),
                    Right = new BinaryTreeNode<int>(3)
                }
            };

            Tree5 = new BinaryTreeNodeTestData
            {
                // tree5 (Simple 3 level, perfect, BST).
                //           10
                //     7     |     15
                //   4 | 8       11 | 18
                DisplayName = "Tree5",
                Height = 3,
                IsBST = true,
                Balanced = true,
                Complete = true,
                Full = true,
                Perfect = true,

                PreOrder = new List<int> { 10, 7, 4, 8, 15, 11, 18 },
                InOrder = new List<int> { 4, 7, 8, 10, 11, 15, 18 },
                PostOrder = new List<int> { 4, 8, 7, 11, 18, 15, 10 },

                Root = new BinaryTreeNode<int>(10)
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
                }
            };

            Tree6 = new BinaryTreeNodeTestData
            {
                // Tree6 (Simple 3 level, perfect, non-BST)
                //           10
                //     7     |     15
                //   8 | 9       11 | 18
                DisplayName = "Tree6",
                Height = 3,
                IsBST = false, // (BST failure on left node)
                Balanced = true,
                Complete = true,
                Full = true,
                Perfect = true,

                PreOrder = new List<int> { 10, 7, 8, 9, 15, 11, 18 },
                InOrder = new List<int> { 8, 7, 9, 10, 11, 15, 18 },
                PostOrder = new List<int> { 8, 9, 7, 11, 18, 15, 10 },

                Root = new BinaryTreeNode<int>(10)
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
                }
            };

            Tree7 = new BinaryTreeNodeTestData
            {
                // Tree7 (Simple 3 level perfect, non-BST)
                //           10
                //     7     |     15
                //   5 | 6       11 | 18
                DisplayName = "Tree7",
                Height = 3,
                IsBST = false, // (BST failure on left node)
                Balanced = true,
                Complete = true,
                Full = true,
                Perfect = true,

                PreOrder = new List<int> { 10, 7, 5, 6, 15, 11, 18 },
                InOrder = new List<int> { 5, 7, 6, 10, 11, 15, 18 },
                PostOrder = new List<int> { 5, 6, 7, 11, 18, 15, 10 },

                Root = new BinaryTreeNode<int>(10)
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
                }
            };

            Tree8 = new BinaryTreeNodeTestData
            {
                // Tree8 (3 level, not full, all leafs on same level)
                //           10
                //     7     |     15
                //   4 | 8       11 |
                DisplayName = "Tree8",
                Height = 3,
                IsBST = true,
                Balanced = true,
                Complete = true, // Last level filled from left to right.
                Full = false, // Node has only one child.
                Perfect = false, // (Not complete or full).

                PreOrder = new List<int> { 10, 7, 4, 8, 15, 11 },
                InOrder = new List<int> { 4, 7, 8, 10, 11, 15 },
                PostOrder = new List<int> { 4, 8, 7, 11, 15, 10 },

                Root = new BinaryTreeNode<int>(10)
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
                }
            };

            Tree9 = new BinaryTreeNodeTestData
            {
                // Tree9 (3 level, not full, not complete, all leafs on same level)
                //           10
                //     7     |     15
                //     | 9          | 18
                DisplayName = "Tree9",
                Height = 3,
                IsBST = true,
                Balanced = true,
                Complete = false, // Last level not filled from left to right.
                Full = false, // Node has only one child.
                Perfect = false, // (Not complete or full).

                PreOrder = new List<int> { 10, 7, 9, 15, 18 },
                InOrder = new List<int> { 7, 9, 10, 15, 18 },
                PostOrder = new List<int> { 9, 7, 18, 15, 10 },

                Root = new BinaryTreeNode<int>(10)
                {
                    Left = new BinaryTreeNode<int>(7)
                    {
                        Right = new BinaryTreeNode<int>(9)
                    },
                    Right = new BinaryTreeNode<int>(15)
                    {
                        Right = new BinaryTreeNode<int>(18)
                    }
                }
            };

            Tree10 = new BinaryTreeNodeTestData
            {
                // Tree10 (3 level, full, and complete but not perfect, all leaves not at same level)
                //           10
                //     7     |     15
                //   5 | 8
                DisplayName = "Tree10",
                Height = 3,
                IsBST = true,
                Balanced = true,
                Complete = true, // All levels completely filled except last which is filled left to right.
                Full = true, // All nodes have 0 or 2 children.
                Perfect = false, // All leafs not at same level.

                PreOrder = new List<int> { 10, 7, 5, 8, 15 },
                InOrder = new List<int> { 5, 7, 8, 10, 15 },
                PostOrder = new List<int> { 5, 8, 7, 15, 10 },

                Root = new BinaryTreeNode<int>(10)
                {
                    Left = new BinaryTreeNode<int>(7)
                    {
                        Left = new BinaryTreeNode<int>(5),
                        Right = new BinaryTreeNode<int>(8)
                    },
                    Right = new BinaryTreeNode<int>(15)
                }
            };

            Tree11 = new BinaryTreeNodeTestData
            {
                // Tree11 (4 level, non-filled node on non-last level)
                //           10
                //     7     |              15
                //     |  8          12     | 18
                //                 11 | 13
                DisplayName = "Tree11",
                Height = 4,
                IsBST = true,
                Balanced = true,
                Complete = false, // All levels are not completely filled.
                Full = false, // 1 node as only one child.
                Perfect = false, // Not complete or full, all leaves not at same level.

                PreOrder = new List<int> { 10, 7, 8, 15, 12, 11, 13, 18 },
                InOrder = new List<int> { 7, 8, 10, 11, 12, 13, 15, 18 },
                PostOrder = new List<int> { 8, 7, 11, 13, 12, 18, 15, 10 },

                Root = new BinaryTreeNode<int>(10)
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
                }
            };

            Tree12 = new BinaryTreeNodeTestData
            {
                // Tree12 (4 level, perfect)
                //                   15
                //        9          |               23
                //  6     |   11           17         |     25
                // 5 | 7    10 | 12      16 | 18         24  |  26
                DisplayName = "Tree12",
                Height = 4,
                IsBST = true,
                Balanced = true,
                Complete = true,
                Full = true,
                Perfect = true,

                PreOrder = new List<int> { 15, 9, 6, 5, 7, 11, 10, 12, 23, 17, 16, 18, 25, 24, 26 },
                InOrder = new List<int> { 5, 6, 7, 9, 10, 11, 12, 15, 16, 17, 18, 23, 24, 25, 26 },
                PostOrder = new List<int> { 5, 7, 6, 10, 12, 11, 9, 16, 18, 17, 24, 26, 25, 23, 15 },

                Root = new BinaryTreeNode<int>(15)
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
                        Left = new BinaryTreeNode<int>(17)
                        {
                            Left = new BinaryTreeNode<int>(16),
                            Right = new BinaryTreeNode<int>(18)
                        },
                        Right = new BinaryTreeNode<int>(25)
                        {
                            Left = new BinaryTreeNode<int>(24),
                            Right = new BinaryTreeNode<int>(26)
                        }
                    }
                }
            };

            Tree13 = new BinaryTreeNodeTestData
            {
                // Tree13 (Non-balanced root)
                //     1
                //   2 |
                // 3 |
                DisplayName = "Tree13",
                Height = 3,
                IsBST = false,
                Balanced = false,
                Complete = false, // (All levels not completely filled).
                Full = false, // (Node with on child).
                Perfect = false,

                PreOrder = new List<int> { 1, 2, 3 },
                InOrder = new List<int> { 3, 2, 1 },
                PostOrder = new List<int> { 3, 2, 1 },

                Root = new BinaryTreeNode<int>(1)
                {
                    Left = new BinaryTreeNode<int>(2)
                    {
                        Left = new BinaryTreeNode<int>(3)
                    }
                }
            };

            Tree14 = new BinaryTreeNodeTestData
            {
                // Tree14 (4 level)
                //          1
                //        2 |  3
                //      4 |  5 |
                //    6 |   7 |
                DisplayName = "Tree14",
                Height = 4,
                IsBST = false,
                Balanced = false, // Sub - trees not balanced.
                Complete = false, // All levels are not completely filled.
                Full = false, // Some nodes have only one child.
                Perfect = false,

                PreOrder = new List<int> { 1, 2, 4, 6, 3, 5, 7 },
                InOrder = new List<int> { 6, 4, 2, 1, 7, 5, 3 },
                PostOrder = new List<int> { 6, 4, 2, 7, 5, 3, 1 },

                Root = new BinaryTreeNode<int>(1)
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
                }
            };

            Tree15 = new BinaryTreeNodeTestData
            {
                // Tree15 (3 level) with missing left on last level.
                //             1
                //        2    |   3
                //        | 4     5 | 6
                DisplayName = "Tree15",
                Height = 3,
                IsBST = false,
                Balanced = true,
                Complete = false, // All levels are not completely filled.
                Full = false, // Some nodes have only one child.
                Perfect = false,

                PreOrder = new List<int> { 1, 2, 4, 3, 5, 6 },
                InOrder = new List<int> { 2, 4, 1, 5, 3, 6 },
                PostOrder = new List<int> { 4, 2, 5, 6, 3, 1 },

                Root = new BinaryTreeNode<int>(1)
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
                }
            };

            Tree16 = new BinaryTreeNodeTestData
            {
                // Tree16 (4 level) Missing right on non-last level.
                //                     1
                //             2       |          3
                //         4   |   5         6    |
                //       7 | 8   9 | 10   11 | 12
                DisplayName = "Tree16",
                Height = 4,
                IsBST = false,
                Balanced = false,
                Complete = false,
                Full = false,
                Perfect = false,

                PreOrder = new List<int> { 1, 2, 4, 7, 8, 5, 9, 10, 3, 6, 11, 12 },
                InOrder = new List<int> { 7, 4, 8, 2, 9, 5, 10, 1, 11, 6, 12, 3 },
                PostOrder = new List<int> { 7, 8, 4, 9, 10, 5, 2, 11, 12, 6, 3, 1 },

                Root = new BinaryTreeNode<int>(1)
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
                }
            };

            FromSampleData1 = new BinaryTreeNodeTestData
            {
                // TreeFromSampleData1
                //                     2
                //             0       |      3
                //             | 1            |     5
                //                               4  |
                DisplayName = "TreeFromSampleData1",
                Height = 4,
                IsBST = true,
                Balanced = false,
                Complete = false,
                Full = false,
                Perfect = false,

                PreOrder = new List<int> { 2, 0, 1, 3, 5, 4 },
                InOrder = new List<int> { 0, 1, 2, 3, 4, 5 },
                PostOrder = new List<int> { 1, 0, 4, 5, 3, 2 },

                Root = new BinaryTreeNode<int>(2)
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
                }
            };

            FromSampleData2 = new BinaryTreeNodeTestData
            {
                // TreeFromSampleData2
                //                     30
                //             20       |      50
                //           10 | 25
                //                 | 40
                DisplayName = "TreeFromSampleData2",
                Height = 4,
                IsBST = false,
                Balanced = false,
                Complete = false,
                Full = false,
                Perfect = false,

                PreOrder = new List<int> { 30, 20, 10, 25, 40, 50 },
                InOrder = new List<int> { 10, 20, 25, 40, 30, 50 },
                PostOrder = new List<int> { 10, 40, 25, 20, 50, 30 },

                Root = new BinaryTreeNode<int>(30)
                {
                    Left = new BinaryTreeNode<int>(20)
                    {
                        Left = new BinaryTreeNode<int>(10),
                        Right = new BinaryTreeNode<int>(25)
                        {
                            Right = new BinaryTreeNode<int>(40)
                        }
                    },
                    Right = new BinaryTreeNode<int>(50)
                }
            };

            NullTree = new BinaryTreeNodeTestData
            {
                DisplayName = "NullTree",
                Height = 0,
                IsBST = true,
                Balanced = true,
                Complete = true,
                Full = true,
                Perfect = true,

                PreOrder = new List<int>(),
                InOrder = new List<int>(),
                PostOrder = new List<int>(),

                Root = null
            };
        }

        public static BinaryTreeNodeTestData Tree1 { get; set; }
        public static BinaryTreeNodeTestData Tree2 { get; set; }
        public static BinaryTreeNodeTestData Tree3 { get; set; }
        public static BinaryTreeNodeTestData Tree4 { get; set; }
        public static BinaryTreeNodeTestData Tree5 { get; set; }
        public static BinaryTreeNodeTestData Tree6 { get; set; }
        public static BinaryTreeNodeTestData Tree7 { get; set; }
        public static BinaryTreeNodeTestData Tree8 { get; set; }
        public static BinaryTreeNodeTestData Tree9 { get; set; }
        public static BinaryTreeNodeTestData Tree10 { get; set; }
        public static BinaryTreeNodeTestData Tree11 { get; set; }
        public static BinaryTreeNodeTestData Tree12 { get; set; }
        public static BinaryTreeNodeTestData Tree13 { get; set; }
        public static BinaryTreeNodeTestData Tree14 { get; set; }
        public static BinaryTreeNodeTestData Tree15 { get; set; }
        public static BinaryTreeNodeTestData Tree16 { get; set; }

        public static BinaryTreeNodeTestData FromSampleData1 { get; set; }
        public static BinaryTreeNodeTestData FromSampleData2 { get; set; }

        public static BinaryTreeNodeTestData NullTree { get; set; }
    }
}
#pragma warning restore 1591
#pragma warning restore SA1600
#pragma warning restore SA1516 // Elements must be separated by blank line

