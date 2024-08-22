for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        // The pattern alternates between 1 and 0.
        int stars = (i + j) % 2; 
        Console.Write(stars + " ");
    }
    Console.WriteLine();
}

/*
    Pattern (odd row number starts with 1, even row number with 0)
        1
        0 1
        1 0 1
        0 1 0 1
        1 0 1 0 1
*/