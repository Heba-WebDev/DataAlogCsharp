/*
Problem Statement: Given an integer N, check whether it is prime or not.
A prime number is a number that is only divisible by 1 and itself and the
total number of divisors is 2.
*/

int x = 7;
int count = 0

for (int i = 1; i * i <= x; i++)
{
    if (x % i == 0)
    {
        count += 1;
        if ((x / i) != i) count += 1;
    }
}

Console.WriteLine(divisors.Count == 2);

// Time Complexity: O(sqrt(N))
// Space Complexity : O(1)