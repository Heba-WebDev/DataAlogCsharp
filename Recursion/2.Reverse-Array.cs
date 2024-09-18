/*
Problem Statement: You are given an array.
The task is to reverse the array and print it.
*/

void reverseArray(int[] n)
{
    int p1 = 0;
    int p2 = n.Length - 1;

    while (p1 < p2)
    {
        int temp = n[p1];
        n[p1] = n[p2];
        n[p2] = temp;
        p1++;
        p2--;
    }
    Console.WriteLine(string.Join(", ", n));
}

reverseArray(new int[] { 1, 2, 3, 4, 5 });