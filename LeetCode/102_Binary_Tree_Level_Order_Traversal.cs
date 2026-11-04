class SolutionClass
{
    static void Main()
    {
        Solution solution = new Solution();
        TreeNodeHelper helper = new TreeNodeHelper();
        TreeNode root = helper.CreateTreeNode([3, 9, 20, null, null, 15, 7]);
        TreeNode root2 = helper.CreateTreeNode([1]);
        TreeNode root3 = helper.CreateTreeNode([]);
        TreeNode root4 = helper.CreateTreeNode([1, 2, 3, 4, 5, null, 7]);
        IList<IList<int>> list1 = solution.LevelOrder(root);
        IList<IList<int>> list2 = solution.LevelOrder(root2);
        IList<IList<int>> list3 = solution.LevelOrder(root3);
        IList<IList<int>> list4 = solution.LevelOrder(root4);
        IList<IList<IList<int>>> allList = new List<IList<IList<int>>>();
        allList.Add(list1);
        allList.Add(list2);
        allList.Add(list3);
        allList.Add(list4);
        foreach (List<IList<int>> list in allList)
        {
            Console.Write("[ ");
            foreach (List<int> listInside in list)
            {
                Console.Write("[ ");
                foreach (int numb in listInside)
                {
                    Console.Write($"{numb}  ");
                }
                Console.Write("] ");
            }
            Console.Write("] ");
            Console.WriteLine();
        }
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
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> cur = new List<IList<int>>();
            if (root == null) return cur;
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                IList<int> addToArray = new List<int>();
                int levelSize = queue.Count;
                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode node = queue.Dequeue();
                    addToArray.Add(node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                cur.Add(addToArray);
            }
            return cur;
        }
    }
}