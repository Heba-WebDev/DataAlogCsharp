int n = 4;
for (int i = 0; i < n; i++)
{
    int stars;
    int space;
    if (i == 0 || i == (n - 1))
    {
        stars = n;
    }
    else
    {
        stars = 2;
    }
    space = n - stars;

    // stars
    for (int y = 0; y < stars / 2; y++)
    {
        Console.Write("*");
    }

    // space
    for (int y = 0; y < space; y++)
    {
        Console.Write(" ");
    }

    // stars
    for (int y = 0; y < stars / 2; y++)
    {
        Console.Write("*");
    }

    Console.WriteLine("");
}

/*
    Stars are equal to n if it's first or last row.
    Space is always n - stars.
        ****
        *  *
        *  *
        ****
*/