public class Solution
{
    public int MinMoves(int[] nums)
    {
        int count = 0, max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                count += (nums[i] - max) * i;
                max = nums[i];
            }
            else
            {
                count += max - nums[i];
            }
        }
        return count;
    }
}