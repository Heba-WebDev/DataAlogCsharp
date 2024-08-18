for (int i = 5; i > 0; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

/*
    The numbers get counted n - current row number (n = 5 in our case)
        12345 n - 0 (5-0 = 5)
        1234  n - 1 (5-1 = 4) and so on
        123
        12
        1
*/