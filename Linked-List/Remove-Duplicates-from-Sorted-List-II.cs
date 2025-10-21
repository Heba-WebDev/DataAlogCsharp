/*
82. Remove Duplicates from Sorted List II

Given the head of a sorted linked list, delete all nodes that
have duplicate numbers, leaving only distinct numbers from the
original list. Return the linked list sorted as well.
*/

using System.Security.Cryptography.X509Certificates;

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        ListNode dummy = new ListNode(0, head); // dummy before head
        ListNode prev = dummy;                 // last non-duplicate node
        ListNode current = head;

        while (current != null)
        {
            if (current.next != null && current.val == current.next.val)
            {
                int duplicateVal = current.val;
                // Skip all nodes with this duplicate value
                while (current != null && current.val == duplicateVal)
                {
                    current = current.next;
                }
                prev.next = current;
            }
            else
            {
                // No duplicates for current node
                prev = current;
                current = current.next;
            }
        }

        return dummy.next;
    }
}

// Time Complexity: O(n)
// Space Complexity: O(1) --> no extra space, just 3 pointers