/*
Problem Statement: Given an integer N, return true if it is a
palindrome else return false.
A palindrome is a number that reads the same backward as forward.
*/

int original = 131;
int n = original;
int reversedNumber = 0;
while (n > 0)
{
    int lastDigit = n % 10;
    reversedNumber = (reversedNumber * 10) + lastDigit;
    n = n / 10;
}

Console.WriteLine(original == reversedNumber);
