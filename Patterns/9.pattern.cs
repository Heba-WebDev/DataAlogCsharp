for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5 - i - 1; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < 2 * i + 1; j++)
    {
        Console.Write("*");
    }

    for (int j = 0; j < 5 - i - 1; j++)
    {
        Console.Write(" ");
    }
    Console.WriteLine();
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < 2 * 5 - (2 * i + 1); j++)
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
    Pattern 7 + Pattern 8
        *
       ***
      *****
     *******
    *********
    *********
     *******
      *****
       ***
        *
*/