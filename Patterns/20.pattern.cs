int n = 10;
for (int i = 1; i < n; i++)
{
    int stars = i < 6 ? (i * 2) : (n - i) * 2;
    int space = n - stars;
    // stars
    for (int y = 1; y <= stars / 2; y++)
    {
        Console.Write("*");
    }
    // space
    for (int y = 1; y <= space; y++)
    {
        Console.Write(" ");
    }
    // stars
    for (int y = 1; y <= stars / 2; y++)
    {
        Console.Write("*");
    }

    Console.WriteLine("");
}


/*
    Stars in the first 5 rows are (row number * 2)
    then they are (n -row number) * 2 [n in our case is 10].
    And space is always n - stars
        *        *
        **      **
        ***    ***
        ****  ****
        **********
        ****  ****
        ***    ***
        **      **
        *        *
*/