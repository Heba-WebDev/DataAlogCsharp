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

/*
    space in each row is: n (in our case 5) - number of current row - 1
    example first row: 5 - 0 - 1 = 4 (4 whit space on each side)
    stars in each row are: 2 x i + 1
    example first row: 2 x 0 = 0 + 1 = 1, second row: 2 x 1 = 2 + 1 = 3

        *
       ***
      *****
     *******
    *********
*/