/*
Problem Statement: Given two integers N1 and N2, find their greatest common divisor.
The Greatest Common Divisor of any two integers is the largest number that divides
both integers.
*/

int x = 20;
int y = 40;
int HCF = 1;

for (int i = 1; i * i <= x; i++)
{
    if (x % i == 0)
    {
        if ((y % i) == 0 && i > HCF) HCF = i;
        if ((x / i) != i)
        {
            int z = x / i;
            if ((y % z) == 0 && z > HCF) HCF = z;
        }
    }
}

Console.WriteLine($"HCF is {HCF}");

// Time Complexity: O(sqrt(n1)) or O(sqrt(n2)) (you can always choose the smaller number for less iterations)

/* -------------------- optimal solution ----------------- */

int n1 = 20, n2 = 15;
int findGcd(int a, int b)
{
    while (a > 0 && b > 0)
    {
        if (a > b)
        {
            a = a % b; // greater % smaller until one is zero, the other HCF
        }
        else
        {
            b = b % a;
        }
    }

    if (a == 0) return b;

    return a;
}

int gcd = findGcd(n1, n2);
Console.WriteLine(gcd);

/*
The Euclidean Algorithm is a method for finding the greatest common divisor of two numbers.
It operates on the principle that the GCD (greatest common divisor) of two numbers remains
the same even if the smaller number is subtracted from the larger number.

1. Repeatedly subtract the smaller number from the larger number until one of them becomes 0.
2. Once one of them becomes 0, the other number is the GCD of the original numbers.

Time Complexity: O(min(N1, N2))
Space Complexity: O(1)
*/

