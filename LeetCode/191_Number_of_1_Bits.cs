using System;
using System.Linq;

class SolutionClass
{
    static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.HammingWeight(11)); // 3
        Console.WriteLine(solution.HammingWeight(128)); // 1
        Console.WriteLine(solution.HammingWeight(2147483645)); //30
    }
}


public class Solution
{
    public int HammingWeight(int n)
    {
        string binaryString = Convert.ToString(n, 2);
        UInt16 res = 0;
        foreach (char a in binaryString)
            if (a == '1')
                res++;
        return res;
    }

    public int HammingWeight2(int n)
    {
        return Convert.ToString(n, 2).Count(c => c == '1');
    }

    public int HammingWeight3(uint n)
    => System.Numerics.BitOperations.PopCount(n);
}

