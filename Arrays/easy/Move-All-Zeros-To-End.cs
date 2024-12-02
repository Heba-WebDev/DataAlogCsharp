/*
 You are given an array of integers, your task is to move
 all the zeros in the array to the end of the array and move
 non-negative integers to the front by maintaining their order.
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 0, 2, 3, 0, 4, 0, 1 };
        ZerosToEnd(arr);
        Console.WriteLine(string.Join(", ", arr));
    }


    public static void ZerosToEnd(int[] arr)
    {
        int pointer1 = 0;
        int pointer2 = 1;
        while (pointer2 < arr.Length)
        {
            if (arr[pointer2] == 0 && arr[pointer1] != 0)
            {
                pointer1++;
                pointer2++;
            }
            else if (arr[pointer1] == 0 && arr[pointer2] != 0)
            {
                int temp = arr[pointer1];
                arr[pointer1] = arr[pointer2];
                arr[pointer2] = temp;
                pointer1++;
                pointer2++;
            }
            else if (arr[pointer1] == 0 && arr[pointer2] == 0)
            {
                pointer2++;
            }
            else if (arr[pointer1] != 0 && arr[pointer2] != 0)
            {
                pointer1++;
                pointer2++;
            }
        }
    }

}
