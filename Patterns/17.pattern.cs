public static void Main(string[] args)
{
    for (int i = 0; i < 4; i++)
    {
        int characters = 2 * i + 1;
        int space = 4 - i - 1;
        for (int x = 0; x < space; x++)
        {
            Console.Write(" ");
        }
        for (int y = 0; y < characters; y++)
        {
            Console.Write("*");
        }
        for (int x = 0; x < space; x++)
        {
            Console.Write(" ");
        }

        Console.WriteLine("");
    }
}

/*
    // rows are very similar to pattern 7, 2 * current row + 1
    // example first row: 2 * 0 + 1 = 1, second row: 2 * 1 + 1 = 3
        A
       ABA
      ABCBA
     ABCDCBA
*/

/*
    We start with 'A' and add an offset to it.
    The offset is determined by Math.Min(y, characters - y - 1).
    Math.Min is a method that returns the smaller of two specified numbers. 
    This creates a sequence that increases up to the middle and then decreases.
    For example, in the last row (7 characters):

    y = 0: Min(0, 6) = 0, so 'A'
    y = 1: Min(1, 5) = 1, so 'B'
    y = 2: Min(2, 4) = 2, so 'C'
    y = 3: Min(3, 3) = 3, so 'D'
    y = 4: Min(4, 2) = 2, so 'C'
    y = 5: Min(5, 1) = 1, so 'B'
    y = 6: Min(6, 0) = 0, so 'A'

    The purpose of this second number (characters - y - 1) is to create a "mirror point" in the middle of each row. Here's how it works:

    At the start of the row, y is small and characters - y - 1 is large.
    As we move towards the middle of the row, these two values approach each other.
    After the middle, y continues to increase, but characters - y - 1 becomes smaller than y.

*/