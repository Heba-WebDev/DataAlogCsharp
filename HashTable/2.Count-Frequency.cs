/*
Problem statement: Given an array, we have found the number of
occurrences of each element in the array.
Example 1:
Input: arr[] = {10,5,10,15,10,5};
Output: 10  3
	    5  2
        15  1
Explanation: 10 occurs 3 times in the array
5 occurs 2 times in the array
15 occurs 1 time in the array
*/

void frequency(int[] arr)
{
    var hash = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (hash.ContainsKey(arr[i]))
        {
            hash[arr[i]]++;
        }
        else
        {
            hash[arr[i]] = 1;
        }
    }
    foreach (var number in hash)
    {
        Console.WriteLine($"{number.Key}: {number.Value}");
    }
}
int[] arr = { 10, 5, 10, 15, 10, 5 };
frequency(arr);