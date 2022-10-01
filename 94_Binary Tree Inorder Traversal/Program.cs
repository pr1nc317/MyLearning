namespace _94_Binary_Tree_Inorder_Traversal
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    class Program
    {
        static IList<int> InorderTraversal(TreeNode root)
        {
            #region Approach 1 - Recursion - O(n) space and time
            //var ansList = new List<int>();
            //RecursionHelper(root, ansList);
            //return ansList;
            #endregion

            #region Approach 2 - Using Stack - O(n) space and time
            //Stack<TreeNode> st = new Stack<TreeNode>();
            //var ansList = new List<int>();
            //while (st.Count != 0 || root != null)
            //{
            //    while (root != null)
            //    {
            //        st.Push(root);
            //        root = root.left;
            //    }
            //    root = st.Pop();
            //    ansList.Add(root.val);
            //    root = root.right;
            //}
            //return ansList;
            #endregion

            #region Approach 3 - Morris Traversal - O(n) time and O(1) space
            // set current node to root
            // if left child is null, move to right node and set it as current node
            // else, find the rightmost node of the left child subtree and move the current node as its right child
            var ansList = new List<int>();
            while (root != null)
            {
                if (root.left == null)
                {
                    ansList.Add(root.val);
                    root = root.right;
                }
                else
                {
                    TreeNode curr = root.left;
                    while (curr.right != null)
                    {
                        curr = curr.right;
                    }
                    TreeNode temp = root.left;
                    curr.right = root;
                    root.left = null;
                    root = temp;
                }
            }
            return ansList;
            #endregion
        }

        static void RecursionHelper(TreeNode root, List<int> ansList)
        {
            if (root != null)
            {
                RecursionHelper(root.left, ansList);
                ansList.Add(root.val);
                RecursionHelper(root.right, ansList);
            }
            else return;
        }

        static void Main(string[] args)
        {
            #region TC1 -- Ans: 42513
            var level2Right1 = new TreeNode(5);
            var level2Left1 = new TreeNode(4);
            var level1Right = new TreeNode(3);
            var level1Left = new TreeNode(2, level2Left1, level2Right1);
            var root = new TreeNode(1, level1Left, level1Right);
            #endregion
            #region TC2 -- Ans: 2513
            //var level2Right1 = new TreeNode(5);
            //var level1Right = new TreeNode(3);
            //var level1Left = new TreeNode(2, null, level2Right1);
            //var root = new TreeNode(1, level1Left, level1Right);
            #endregion
            #region TC3 -- Ans: 24513
            //var level3Left1 = new TreeNode(4);
            //var level2Right1 = new TreeNode(5, level3Left1);
            //var level1Right = new TreeNode(3);
            //var level1Left = new TreeNode(2, null, level2Right1);
            //var root = new TreeNode(1, level1Left, level1Right);
            #endregion
            #region TC4 -- Ans: 13524
            //var level3Right1 = new TreeNode(5);
            //var level2Right1 = new TreeNode(4);
            //var level2Left1 = new TreeNode(3, null, level3Right1);
            //var level1Right = new TreeNode(2, level2Left1, level2Right1);
            //var root = new TreeNode(1, null, level1Right);
            #endregion
            InorderTraversal(root).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
