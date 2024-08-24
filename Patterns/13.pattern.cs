int number = 1;
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write($"{number} ");
        number++;
    }
    Console.WriteLine("");
}

/*
    The other loop is n, the inner loop run 1 to current row number
    The numbers go from 1 to 15, throughout all rows
        1
        2 3
        4 5 6
        7 8 9 10
        11 12 13 14 15
*/