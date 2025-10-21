/*
141. Linked List Cycle

Given head, the head of a linked list, determine if the
linked list has a cycle in it. There is a cycle in a linked
list if there is some node in the list that can be reached
again by continuously following the next pointer. Internally,
pos is used to denote the index of the node that tail's next
pointer is connected to. Note that pos is not passed as a parameter.

Return true if there is a cycle in the linked list. Otherwise, return false.
*/

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        // keeps track of nodes we've seen
        var visited = new HashSet<ListNode>();
        ListNode current = head;

        while (current != null)
        {
            // if I see the same node again, there is a cycle
            // aka, another node's next points to it
            if (visited.Contains(current))
            {
                return true;
            }

            visited.Add(current);
            current = current.next;
        }

        return false;
    }
}

// Time Complexity: O(n)
// Space Complexity: O(n) --> HashSet stores each node