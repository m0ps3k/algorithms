class SolutionClass
{
    static void Main()
    {
        Solution solution = new Solution();
        TreeNodeHelper helper = new TreeNodeHelper();
        TreeNode root = helper.CreateTreeNode([3, 9, 20, null, null, 15, 7]);
        TreeNode root2 = helper.CreateTreeNode([1, null, 2]);
        Console.WriteLine(solution.MaxDepth(root));
        Console.WriteLine(solution.MaxDepth(root2));
    }

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

    public class TreeNodeHelper
    {
        TreeNode CreateNode(int?[] ints, int i = 0)
        {
            if (i >= ints.Length || ints[i] == null)
            {
                return null;
            }
            TreeNode node = new TreeNode(ints[i].Value);
            node.left = CreateNode(ints, 2 * i + 1);
            node.right = CreateNode(ints, 2 * i + 2);
            return node;
        }

        public TreeNode CreateTreeNode(int?[] ints)
        {
            if (ints == null || ints.Length == 0)
            {
                return null;
            }
            var result = CreateNode(ints);
            return result;
        }
    }

    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            int left = root.left != null ? MaxDepth(root.left) + 1 : 1;
            int right = root.right != null ? MaxDepth(root.right) + 1 : 1;
            return Math.Max(left, right);
        }
    }
}