for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}

/*
    numbers match the range 1 to current row number
        1
        12
        123
        1234
        12345
*/