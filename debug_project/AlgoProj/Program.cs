using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace Algorithms;

class SolutionClass
{
    static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.SearchInsert([1, 3, 5, 6], 5)); //2
        Console.WriteLine(solution.SearchInsert([1, 3, 5, 6], 2)); //1
        Console.WriteLine(solution.SearchInsert([1, 3, 5, 6], 7)); //4
        Console.WriteLine(solution.SearchInsert([1, 3, 5, 6], 0)); //0
    }
}


public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int i = 0;
        int j = nums.Length - 1;
        int med = 0;
        while (i <= j)
        {
            med = (i + j) / 2;
            if (nums[med] > target) j = med - 1;
            else if (nums[med] < target) i = med + 1;
            else return med;
        }
        if (nums[med] > target) return med;
        else return med + 1;
    }
}