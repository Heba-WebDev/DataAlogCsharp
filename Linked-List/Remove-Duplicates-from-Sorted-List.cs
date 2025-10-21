/*
83. Remove Duplicates from Sorted List

Given the head of a sorted linked list, delete all duplicates such
that each element appears only once. Return the linked list sorted
as well.
*/

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;

        ListNode current = head;

        while (current.next != null)
        {
            if (current.val == current.next.val)
            {
                // skip the duplicate node
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return head;
    }
}

// Time Complexity: O(n)
// Space Complexity: O(1)
