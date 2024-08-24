char[] letters = { 'A', 'B', 'C', 'D', 'E' };
for (int i = 5; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(letters[j]);
    }

    Console.WriteLine("");
}

/*
        ABCDE
        ABCD
        ABC
        AB
        A
*/