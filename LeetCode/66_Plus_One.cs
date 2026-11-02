using System;
using System.Formats.Asn1;
using System.Globalization;


class SolutionClass
{
    static void Main()
    {
        Solution solution = new Solution();
        var res = solution.PlusOne(Console.ReadLine().Split().Select(int.Parse).ToArray());
        foreach (var i in res)
        {
            Console.Write($"{i} ");
        }
    }
}

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        if (digits[^1] != 9)
        {
            digits[^1] += 1;
            return digits;
        }
        else
        {
            int[] mas;
            var check = digits.Any(x => x != 9);
            if (check) mas = new int[digits.Length];
            else mas = new int[digits.Length + 1];
            bool flag = true;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9 && flag && i == 0)
                {
                    mas[i] = 1;
                }
                else if (digits[i] == 9 && flag)
                {
                    mas[i] = 0;
                }
                else if (flag)
                {
                    mas[i] = digits[i] + 1;
                    flag = false;
                }
                else
                {
                    mas[i] = digits[i];
                }
            }
            return mas;
        }
    }
}