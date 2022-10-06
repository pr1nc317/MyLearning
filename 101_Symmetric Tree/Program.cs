namespace _101_Symmetric_Tree
{
    using System;

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
        //public static bool flag = true;
        public static bool IsSymmetric(TreeNode root)
        {
            TreeNode L = root;
            TreeNode R = root;
            if (root.left == null && root.right == null)
            {
                return true;
            }
            bool flag = true;
            var ans = Helper(L, R, ref flag);
            return ans;
        }

        public static bool Helper(TreeNode L, TreeNode R, ref bool flag)
        {
            //if (!flag) return flag;
            if ((L == null && R != null) || (L != null && R == null))
            {
                flag = false;
                return flag;
            }
            if (L == null & R == null)
            {
                return flag;
            }
            if (L.val != R.val)
            {
                flag = false;
                return flag;
            }
            Helper(L.left, R.right, ref flag);
            Helper(L.right, R.left, ref flag);
            return flag;
        }

        static void Main(string[] args)
        {
            #region TC1 - True
            var level2_2 = new TreeNode(5);
            var level2_1 = new TreeNode(3);
            var level2_3 = new TreeNode(5);
            var level2_4 = new TreeNode(3);
            var level1_2 = new TreeNode(2, level2_3, level2_4);
            var level1_1 = new TreeNode(2, level2_1, level2_2);
            var root = new TreeNode(1, level1_1, level1_2);
            #endregion
            #region TC2 - True
            //var level2_1 = new TreeNode(3);
            //var level2_3 = new TreeNode(3);
            //var level1_2 = new TreeNode(2, null, level2_3);
            //var level1_1 = new TreeNode(2, level2_1);
            //var root = new TreeNode(1, level1_1, level1_2);
            #endregion
            #region TC3 - False
            //var level2_1 = new TreeNode(3);
            //var level2_3 = new TreeNode(3);
            //var level1_2 = new TreeNode(2, level2_3);
            //var level1_1 = new TreeNode(2, level2_1);
            //var root = new TreeNode(1, level1_1, level1_2);
            #endregion
            #region TC4 - True
            //var level1_2 = new TreeNode(2);
            //var level1_1 = new TreeNode(2);
            //var root = new TreeNode(1, level1_1, level1_2);
            #endregion

            Console.WriteLine(IsSymmetric(root));
        }
    }
}
