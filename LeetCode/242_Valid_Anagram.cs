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
        return (int)a - 'a';
    }
}