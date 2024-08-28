int n = 10;
int midpoint = n / 2;
for (int i = 0; i < n; i++)
{
    int space;
    int stars;

    if (i < midpoint)
    {
        // Top half of the hourglass
        space = 2 * i;
        stars = (n - space) / 2;
    }
    else
    {
        // Bottom half of the hourglass
        space = 2 * (n - i - 1);
        stars = (n - space) / 2;
    }
    // stars
    for (int y = 0; y < stars; y++)
    {
        Console.Write("*");
    }
    // space 
    for (int y = 0; y < space; y++)
    {

        Console.Write(" ");
    }
    // stars
    for (int y = 0; y < stars; y++)
    {
        Console.Write("*");
    }

    Console.WriteLine("");
}
/*
        **********
        ****  ****
        ***    ***
        **      **
        *        *
        *        *
        **      **
        ***    ***
        ****  ****
        **********
*/
