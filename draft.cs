// using System;
// using System.Globalization;

// namespace Algorithms;

// class SolutionClass
// {
//     static void Main()
//     {
//         Solution solution = new Solution();
//         var res = solution.PlusOne(Console.ReadLine().Split().Select(int.Parse).ToArray());
//         foreach (var i in res)
//         {
//             Console.Write($"{i} ");
//         }
//     }
// }

// public class Solution
// {
//     public int[] PlusOne(int[] digits)
//     {
//         if (digits[^1] != 9)
//         {
//             digits[^1] += 1;
//             return digits;
//         }
//         else
//         {
//             int[] mas = new int[digits.Length + 1];
//             for (int i = 0, j = 1; i < digits.Length; i++)
//             {
//                 mas[i] = digits[i];
//                 if (i + 1 == digits.Length)
//                 {
//                     mas[^j++] = 0;
//                     while (mas[^j] == 9)
//                     {
//                         mas[^j++] = 0;
//                     }
//                     mas[^j] += 1;
//                 }
//             }
//             return mas;
//         }
//     }
// }



// LeetCode 94 — Binary Tree Inorder Traversal
// LeetCode 173 — Binary Search Tree Iterator
// LeetCode 98 — Validate Binary Search Tree
// LeetCode 700 — Search in a Binary Search Tree
// LeetCode 783 — Minimum Distance Between BST Nodes