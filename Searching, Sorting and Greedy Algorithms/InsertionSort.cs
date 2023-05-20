

using System.ComponentModel.Design;

class Solution
{
    public static void Main(string[] args)
    {
       var arr = Console.ReadLine().
            Split().
            Select(int.Parse)
            .ToArray();

       InsertionSort(arr);

        Console.WriteLine(string.Join(" ", arr));



    }

    private static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            var j = i;

            while (j > 0 && arr[j - 1] > arr[j])
            {
                SwapElements(arr,j, j-1);
                j -= 1;
            }
        }
    }


    private static void SwapElements(int[] arr, int first, int second)
    {
        var temp = arr[first];
        arr[first] = arr[second];
        arr[second] = temp;
    }
}
