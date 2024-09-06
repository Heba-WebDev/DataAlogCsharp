/*
Problem Statement: Given an integer N, return true it is
an Armstrong number otherwise return false.
An Amrstrong number is a number that is equal to the sum
of its own digits each raised to the power of the number of digits.
Example 1:
Input:N = 153
Output:True
Explanation: 13+53+33 = 1 + 125 + 27 = 153
*/

int n = 153;
int copyN = n;
int sum = 0;
int totalDigits = (int)Math.Floor(Math.Log10(n) + 1);
while (copyN > 0)
{
    // get last digit and raise it to the total number of digits (in our case 3)
    sum += (int)Math.Pow((copyN % 10), totalDigits);
    // remove last digit by dividing by 10
    copyN = copyN / 10;
}

Console.WriteLine(n == sum);
