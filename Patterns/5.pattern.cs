for (int i = 0; i < 5; i++)
{
    for (int j = 5; j > i; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

/*
    The stars get repeated n - current row number (n = 5 in our case) 
        ***** n - 0 (5-0 = 5)
        ****  n - 1 (5-1 = 4) and so on
        ***
        **
        *
*/