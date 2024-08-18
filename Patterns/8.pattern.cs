for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < 2*5-(2*i+1); j++)
    {
        Console.Write("*");
    }

    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    Console.WriteLine();
}

/*
    spaces matches the current row number, so at row 0, space = 0 and so on
    stars: 2 * n - (2 * i + 1) so for first row:
    2 * 5 = 10
    2 * 0 = 0 + 1 = 1
    10 - 1 = 9
    *********
     *******
      *****
       ***
        *
*/