

using System.ComponentModel.Design;

class Solution
{
    public static void Main(string[] args)
    {
       var arr = Console.ReadLine().
            Split().
            Select(int.Parse)
            .ToArray();

       BubbleSort(arr);

        Console.WriteLine(string.Join(" ", arr));



    }

    private static void BubbleSort(int[] arr)
    {

        var isSorted = false;

        while (!isSorted)
        {
            isSorted = true;

            for (int i = 1; i < arr.Length; i++)
            {
                var j = i - 1;

                if (arr[j] > arr[i])
                {
                    SwapElements(arr,j,i);
                    isSorted = false;
                }
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
