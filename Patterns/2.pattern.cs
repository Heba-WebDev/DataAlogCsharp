for (int i = 0; i < 5; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

/*
    stars match the number of the current row (from 1 to 5)
        *
        **
        ***
        ****
        *****
*/