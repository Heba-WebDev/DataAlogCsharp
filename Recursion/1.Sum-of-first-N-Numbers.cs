int sum(int n)
{

    if (n == 0) return 0;
    return n + sum(n - 1);
}

Console.WriteLine(sum(3));
