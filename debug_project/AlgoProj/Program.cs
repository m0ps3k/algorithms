using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Globalization;
using System.Net.Quic;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Xml;

namespace Algorithms;

class SolutionClass
{
    static void Main()
    {
        Solution solution = new Solution();
        TreeNodeHelper helper = new TreeNodeHelper();
        TreeNode root5 = helper.CreateTreeNode([3, 1, 4, null, 2]);
        TreeNode root6 = helper.CreateTreeNode([5, 3, 6, 2, 4, null, null, 1]);
        TreeNode root7 = helper.CreateTreeNode([1]);
        Console.WriteLine(solution.KthSmallest(root5, 1));
        solution.count = 0;
        Console.WriteLine(solution.KthSmallest(root6, 3));
        solution.count = 0;
        Console.WriteLine(solution.KthSmallest(root7, 1));
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
        public int count = 0;

        public int KthSmallest(TreeNode root, int k)
        {
            if (root == null) return 0;
            int smallestLeft = KthSmallest(root.left, k);
            count++;
            if (k == count) return root.val;
            if (smallestLeft != 0) return smallestLeft;
            return KthSmallest(root.right, k);
        }
    }
}
