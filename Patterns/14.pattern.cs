char[] letters = { 'A', 'B', 'C', 'D', 'E' };
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(letters[j]);
    }

    Console.WriteLine("");
}

/*
        A
        AB
        ABC
        ABCD
        ABCDE
*/