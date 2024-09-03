/*
 Problem Statement: Given an integer N, return the number of digits in N.
 Example 1:
 Input:N = 12345
 Output:5
 Explanation:  The number 12345 has 5 digits.
 Example 2:
 Input:N = 7789
 Output: 4
 Explanation: The number 7789 has 4 digits.
*/

// Brute force approach
int counter = 0;
int n = 7789;
while (n > 0)
{
    counter += 1;
    n = n / 10;
}
Console.WriteLine($"Number of digits are {counter}");
/* Time complexity is O(log10 n). In Big O notation, we typically drop the base
of the logarithm because logarithms with different bases only differ by a
constant factor. So, we can simplify this to O(log n).*/
/* Space complexity is O(1) */

// Optimal approach 

/*
The logarithmic base 10 of a positive integers gives the number of digits in n. 
We add 1 to the result to ensure that the count is correct even for numbers that
are powers of 10. This compensates for the fact that Log10 gives us the power of 10,
not the digit count directly.
*/

int n = 7789;
int counter = (int)Math.Floor(Math.Log10(n) + 1);
Console.WriteLine($"Number of digits are {counter}");

/*
Time Complexity: O(1), Space Complexity: O(1)
*/
