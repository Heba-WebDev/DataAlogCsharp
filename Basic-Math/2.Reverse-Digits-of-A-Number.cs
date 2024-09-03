/*
Problem Statement: Given an integer N return the reverse of the given number.
Note: If a number has trailing zeros, then its reverse will not include them. 
For e.g., reverse of 10400 will be 401 instead of 00401.
Example 1:
Input:N = 12345
Output:54321
Explanation: The reverse of 12345 is 54321.
Example 2:
Input:N = 7789
Output: 9877
Explanation: The reverse of number 7789 is 9877.
*/

int n = 7789;
int reversedNumber = 0;
while (n > 0)
{
    int lastDigit = n % 10;
    reversedNumber = (reversedNumber * 10) + lastDigit;
    n = n / 10;
}

Console.WriteLine($"Number reversed is {reversedNumber}");
/*
Time Complexity: O(log n), Space Complexity: O(1)
*/
