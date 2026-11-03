class SolutionClass
{
    static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.Search([-1, 0, 3, 5, 9, 12], 9));
        Console.WriteLine(solution.Search([-1, 0, 3, 5, 9, 12], 8));
    }
}


public class Solution
{
    public int Search(int[] nums, int target)
    {
        int i = 0;
        int j = nums.Length - 1;
        int med;
        while (i <= j)
        {
            med = (i + j) / 2;
            if (nums[med] > target) j = med - 1;
            else if (nums[med] < target) i = med + 1;
            else return med;
        }
        return -1;
    }
}