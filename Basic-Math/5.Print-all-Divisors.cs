/*
Problem Statement: Given an integer N, return all divisors of N.
A divisor of an integer N is a positive integer that divides N
without leaving a remainder. In other words, if N is divisible
by another integer without any remainder, then that integer is
considered a divisor of N.
Example 1:
Input:N = 36
Output:[1, 2, 3, 4, 6, 9, 12, 18, 36]
*/

int x = 36;
List<int> divisors = new List<int>();
// the optimal solution is to loop until the square root of the number
// that way we loop O(log n) intead of O(n)

for (int i = 1; i*i <= x; i++)
{
    if (x % i == 0)
    {
        divisors.Add(i);
        if ((x / i) != i) divisors.Add(x / i);
    }
}
divisors.Sort();
// without string.Join, System.Genrics.List would be printed
Console.WriteLine(string.Join(", ", divisors));

// Time complexity O(√n log n)