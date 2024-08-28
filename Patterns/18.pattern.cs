char[] letters = { 'E', 'D', 'C', 'B', 'A' };
for (int i = 0; i < 5; i++)
{
    for (int y = i; y >= 0; y--)
    {
        Console.Write($"{letters[y]} ");
    }

    Console.WriteLine("");
}

/*
    // Outter loop is straightforward, i to n
    // inner loop, goes from i to 0
    // flipped the letters for easier access
        E
        DE
        C D E
        B C D E
        A B C D E
*/
