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

namespace Algorithms;

class SolutionClass
{
    static void Main()
    {
        // Solution solution = new Solution();
        TreeNodeHelper helper = new TreeNodeHelper();
        TreeNode root = helper.CreateTreeNode([3, 9, 20, null, null, 15, 7]);
        TreeNode root2 = helper.CreateTreeNode([1]);
        TreeNode root3 = helper.CreateTreeNode([]);
        TreeNode root4 = helper.CreateTreeNode([1, 2, 3, 4, 5, null, 7]);

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
}