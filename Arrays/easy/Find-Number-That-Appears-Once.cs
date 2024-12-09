/*
Given a non-empty array of integers arr, every element appears twice
except for one. Find that single one.
*/

public class Array
{
    public static void Main(string[] args)
    {
        int[] arr = { 2, 2, 1, 3, 4, 2, 1 };
        Console.WriteLine(AppearsOne(arr));
    }

    public static int AppearsOne(int[] arr)
    {
        var dictionary = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            // if(!dictionary.ContainsKey(arr[i]))
            // {
            //     dictionary.Add(arr[i], 1);
            // } else {
            //     dictionary[arr[i]]++;
            // }

            if (dictionary.TryGetValue(arr[i], out int value))
            {
                dictionary[arr[i]] = value + 1;
            }
            else
            {
                dictionary[arr[i]] = 1;
            }
        }

        foreach (var pair in dictionary)
        {
            if (pair.Value == 1)
            {
                return pair.Key;
            }
        }
        return -1;
    }
}
