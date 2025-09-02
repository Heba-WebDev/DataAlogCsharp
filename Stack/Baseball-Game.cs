/*

682. Baseball Game (Leetcode Easy - Stack)

You are keeping the scores for a baseball game with strange rules.
At the beginning of the game, you start with an empty record.

You are given a list of strings operations, where operations[i] is
the ith operation you must apply to the record and is one of the following:

An integer x.
Record a new score of x.

'+'.
Record a new score that is the sum of the previous two scores.

'D'.
Record a new score that is the double of the previous score.

'C'.
Invalidate the previous score, removing it from the record.

Return the sum of all the scores on the record after applying
all the operations.

The test cases are generated such that the answer and all intermediate
calculations fit in a 32-bit integer and that all operations are valid.

*/

// With a stack

public class Solution
{
    public int CalPoints(string[] operations)
    {
        int sum = 0;
        Stack<int> nums = new Stack<int>();

        foreach (var x in operations)
        {
            if (int.TryParse(x, out int val))
            {
                sum += val;
                nums.Push(val);
            }
            else if (x == "D")
            {
                if (nums.Count > 0)
                {
                    int num = nums.Peek();
                    sum += (2 * num);
                    nums.Push(2 * num);
                }
            }
            else if (x == "+")
            {
                if (nums.Count >= 2)
                {
                    // pop top to get second-last
                    int top = nums.Pop();
                    int second = nums.Peek();

                    int newScore = top + second;
                    sum += newScore;

                    // push back both
                    nums.Push(top);
                    nums.Push(newScore);
                }
            }
            else if (x == "C")
            {
                if (nums.Count > 0)
                {
                    int num = nums.Pop();
                    sum -= num;
                }
            }
        }
        return sum;
    }
}

// With a list (clearner)

public class Solution
{
    public int CalPoints(string[] operations)
    {
        int sum = 0;
        List<int> scores = new List<int>();

        foreach (var x in operations)
        {
            if (int.TryParse(x, out int val))
            {
                scores.Add(val);
                sum += val;
            }
            else if (x == "D")
            {
                int doubled = scores[^1] * 2;
                scores.Add(doubled);
                sum += doubled;
            }
            else if (x == "+")
            {
                int newScore = scores[^1] + scores[^2];
                scores.Add(newScore);
                sum += newScore;
            }
            else if (x == "C")
            {
                int removed = scores[^1];
                scores.RemoveAt(scores.Count - 1);
                sum -= removed;
            }
        }

        return sum;
    }
}
