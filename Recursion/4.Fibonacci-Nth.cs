/*
Problem Statement: Given an integer N. Print the Fibonacci series up to the Nth term.
*/

// Iterative
int fibonacci(int x)
{
    if (x <= 1) return x;
    int n1 = 0, n2 = 1, n3 = 0;
    for (int i = 2; i <= x; i++)
    {
        n3 = n2 + n1;
        n1 = n2;
        n2 = n3;
    }
    return n3;
}
Console.WriteLine(fibonacci(6));

// O(n)

// Recursive
int fibonacci(int x)
{
    if (x <= 1)
    {
        return x;
    }
    else
    {
        return fibonacci(x - 1) + fibonacci(x - 2);
    }

}
Console.WriteLine(fibonacci(6));

// O(2^n)