class SolutionClass
{
    static void Main()
    {
        Solution solution = new Solution();
        int[] res1 = solution.SortArray([5, 2, 3, 1, 535, 74, 54, 13, 68, 14, 6436, 0]);
        int[] res2 = solution.SortArray([5, 2, 3, 1]);
        foreach (var r in res1)
        {
            Console.Write($"{r} ");
        }
        Console.WriteLine();
        foreach (var r in res2)
        {
            Console.Write($"{r} ");
        }
    }
}

public class Solution
{
    public int[] SortArray(int[] nums)
    {
        int[] buffer = new int[nums.Length];
        MergeSort(nums, buffer, 0, nums.Length - 1);
        return nums;
    }

    public void MergeSort(int[] nums, int[] buffer, int left, int right)
    {
        if (left >= right) return;
        int mid = (left + right) / 2;

        MergeSort(nums, buffer, left, mid);
        MergeSort(nums, buffer, mid + 1, right);

        if (nums[mid] <= nums[mid + 1]) return;

        Merge(nums, buffer, left, mid, right);
    }

    public void Merge(int[] nums, int[] buffer, int left, int mid, int right)
    {
        int i = left, j = mid + 1, ind = 0;
        while (i <= mid && j <= right)
        {
            if (nums[i] <= nums[j]) buffer[ind++] = nums[i++];
            else buffer[ind++] = nums[j++];
        }

        while (i <= mid)
        {
            buffer[ind++] = nums[i++];
        }

        while (j <= right)
        {
            buffer[ind++] = nums[j++];
        }

        for (int l = left, h = 0; l <= right; l++, h++)
        {
            nums[l] = buffer[h];
        }
    }
}