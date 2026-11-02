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
        Console.WriteLine(solution.IsAnagram("anagram", "nagaram")); //true
        Console.WriteLine(solution.IsAnagram("rat", "car")); //false
    }
}


public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        HashTable hashTable = new HashTable();
        foreach (char i in s)
        {
            hashTable.Add(i);
        }
        foreach (char i in t)
        {
            hashTable.Minus(i);
        }
        return hashTable.IsHashEmpty();
    }
}

public class HashTable
{
    int[] ints;

    public HashTable()
    {
        ints = new int[26];
        for (int i = 0; i < 26; i++)
        {
            ints[i] = 0;
        }
    }

    public void Add(char a)
    {
        int index = HashFunc(a);
        ints[index]++;
    }

    public void Minus(char a)
    {
        int index = HashFunc(a);
        ints[index]--;
    }

    public bool IsHashEmpty()
    {
        foreach (var i in ints)
        {
            if (i != 0) return false;
        }
        return true;
    }

    public int HashFunc(char a)
    {
        // if (Char.IsUpper(a)) return (int)a - 65;
        // else return (int)a - 71;
        return (int)a - 'a';
    }
}


// Dictionary<char, int> pairs = new Dictionary<char, int>();