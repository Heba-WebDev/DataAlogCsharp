int n = 5; // This represents the maximum number of stars in the middle row
int totalRows = 2 * n - 1; // Total number of rows in the pattern

for (int i = 0; i < totalRows; i++)
{
    int stars = i <= n ? i : totalRows - i + 1;

    for (int j = 1; j <= stars; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

/*
    Pattern (1 to n & n-1 to 1)
        *
        **
        ***
        ****
        *****
        ****
        ***
        **
        *
*/