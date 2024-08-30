int n = 7;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        int value;
        if (i <= 3 && j <= 3)
            value = 4 - Math.Min(i, j);
        else if (i <= 3)
            value = 4 - Math.Min(i, 6 - j);
        else if (j <= 3)
            value = 4 - Math.Min(6 - i, j);
        else
            value = 4 - Math.Min(6 - i, 6 - j);

        Console.Write(value);
    }
    Console.WriteLine();
}

/*
    It's a matrix, so both outer and inner loop are equally going
    from 0 to n

    4444444
    4333334
    4322234
    4321234
    4322234
    4333334
    4444444
*/