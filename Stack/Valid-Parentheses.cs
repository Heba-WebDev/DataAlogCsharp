/*

20. Valid Parentheses (Leetcode Easy - Stack)

Given a string s containing just the characters
'(', ')', '{', '}', '[' and ']', determine if the
input string is valid.

An input string is valid if:

- Open brackets must be closed by the same type of brackets.
- Open brackets must be closed in the correct order.
- Every close bracket has a corresponding open bracket of the same type.

*/

using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> mapping = new Dictionary<char, char> {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                // if opening bracket - push to stack
                stack.Push(c);
            }
            else if (mapping.ContainsKey(c))
            {
                // if closing bracket - check for match
                if (stack.Count == 0 || stack.Pop() != mapping[c])
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
