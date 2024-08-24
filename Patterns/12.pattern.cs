for (int i = 1; i <= 4; i++)
{
    // numbers 1 to row number
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }

    // spaces 2 * (n - current row number)
    for (int x = 1; x <= (2 * (4 - i)); x++)
    {
        Console.Write(" ");
    }

    // numbers row number to 1
    for (int j = i; j > 0; j--)
    {
        Console.Write(j);
    }
    Console.WriteLine("");
}

/*
    Ddots are spaces in the orginal pattern but I chose dots for better readability
        1......1
        12....21
        123..321
        12344321
*/
