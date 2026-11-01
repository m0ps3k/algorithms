using System;
using System.Formats.Asn1;
using System.Globalization;

namespace Algorithms;

class SolutionClass
{
    static void Main()
    {
        Solution solution = new Solution();
        ListNode n0 = new(1);
        ListNode n1 = new(2);
        ListNode n2 = new(3);
        ListNode n3 = new(4);
        ListNode n4 = new(5);
        // Построение ссылок между узлами
        n0.next = n1;
        n1.next = n2;
        n2.next = n3;
        n3.next = n4;

        ListNode see = n0;
        while (see != null)
        {
            Console.Write($"{see.val} ");
            if (see.next != null) Console.Write("=> ");
            see = see.next;
        }

        var newHead = solution.ReverseList(n0);

        Console.WriteLine();

        while (newHead != null)
        {
            Console.Write($"{newHead.val} ");
            if (newHead.next != null) Console.Write("=> ");
            newHead = newHead.next;
        }
    }
}


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}


public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        ListNode nxt = null;

        while (current != null)
        {
            nxt = current.next;
            current.next = prev;
            prev = current;
            current = nxt;
        }

        return prev;
    }
}