/*

225. Implement Stack using Queues (Leetcode Easy - Queue)

Implement a last-in-first-out (LIFO) stack using only two queues.
The implemented stack should support all the functions of a normal
stack (push, top, pop, and empty).

Implement the MyStack class:

- void push(int x) Pushes element x to the top of the stack.
- int pop() Removes the element on the top of the stack and returns it.
- int top() Returns the element on the top of the stack.
- boolean empty() Returns true if the stack is empty, false otherwise.

Notes:

You must use only standard operations of a queue, which means that
only push to back, peek/pop from front, size and is empty operations
are valid.

Depending on your language, the queue may not be supported natively.
You may simulate a queue using a list or deque (double-ended queue)
as long as you use only a queue's standard operations.

*/

public class MyStack
{
    private Queue<int> queue;

    public MyStack()
    {
        queue = new Queue<int>();
    }

    public void Push(int x)
    {
        queue.Enqueue(x); // add the new element to the back
        // rotate all existing elements
        for (int i = 0; i < queue.Count - 1; i++)
        {
            queue.Enqueue(queue.Dequeue());
        }
    }

    partial void Pop()
    {
        return queue.Dequeue();
    }

    public int Top()
    {
        return queue.Peek();
    }

    public bool Empty()
    {
        return queue.Count == 0;
    }
}
/*
Push: O(n) - Need to rotate all existing elements
Pop: O(1) - Simple dequeue operation
Top: O(1) - Simple peek operation
Empty: O(1) - Simple count check
*/