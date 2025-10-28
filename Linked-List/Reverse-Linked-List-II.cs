/*
Given the head of a singly linked list and two integers left and right where
left <= right, reverse the nodes of the list from position left to position
right, and return the reversed list.
*/

public class Solution
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (head == null || left == right) return head;

        // creating a dummy node to simplify edge cases (ex: reversing from head)
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode prev = dummy;

        // move prev to the node before reversal starts
        for (int i = 1; i < left; i++)
        {
            prev = prev.next;
        }

        // start reversing
        ListNode current = prev.next;
        ListNode nextNode = null;

        // in-place reversal
        for (int i = 0; i < right - left; i++)
        {
            nextNode = current.next;
            current.next = nextNode.next;
            nextNode.next = prev.next;
            prev.next = nextNode;
        }

        return dummy.next;
    }
}

// Time Complexity: O(n) --> one pass through the list
// Space Complexity: O(1) --> in-place reversal