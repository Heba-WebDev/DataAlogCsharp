/*
206. Reverse Linked List

Given the head of a singly linked list, reverse the list, and return the reversed list.
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        // current
        ListNode prev = null; // at start null because current head has no previous number
        ListNode current = head;

        while (current != null)
        {
            ListNode nextNode = current.next; // store next
            current.next = prev;              // reverse pointer
            prev = current;                   // move prev forward
            current = nextNode;               // move current forward
        }

        return prev;
    }
}

// Time Complexity: O(n)
// Space Complexity: O(1)
