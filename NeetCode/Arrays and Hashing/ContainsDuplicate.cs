using System.Globalization;
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Metadata.Ecma335;

public class Solution
{
    public static bool ContainsDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j]) return true;
            }
        }
        return false;
    }

    // public static void Main()
    // {
    //     Console.WriteLine(ContainsDuplicate([1, 2, 3, 1])); //true
    //     Console.WriteLine(ContainsDuplicate([1, 2, 3, 4])); //false
    //     Console.WriteLine(ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2])); //true
    //     Console.WriteLine(ContainsDuplicate([3, 8, 1, 2, 8])); // true

    //     Console.WriteLine();

    //     Console.WriteLine(ContainsDuplicate([7])); // false
    //     Console.WriteLine(ContainsDuplicate([5, 5])); // true
    //     Console.WriteLine(ContainsDuplicate([5, 6])); // false

    // }

    public static void Main()
    {

    }
}