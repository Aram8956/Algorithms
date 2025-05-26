namespace ConsoleApp1;

class Program
{
    public static int LowerBound(int[] array, int value)
    {
        int start = 0;
        int end = array.Length - 1;
        int mid;
        int index = array.Length - 1;
        while (start <= end)
        {
            mid = (start + end) / 2;
            if (array[mid] >= value)
            {
                index = mid;
                end = mid - 1;
            }

            if (array[mid] < value)
            {
                start = mid + 1;
            }
        }

        return index;
    }

    public static int UpperBound(int[] array, int value)
    {
        int start = 0;
        int end = array.Length - 1;
        int mid;
        int index = array.Length - 1;
        while (start <= end)
        {
            mid = (start + end) / 2;
            if (array[mid] > value)
            {
                index = mid;
                end = mid - 1;
            }

            if (array[mid] <= value)
            {
                start = mid + 1;
            }
        }

        return index;
    }
    
    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 3, 3, 4, 4, 4, 5, 6, 7 };
        Console.WriteLine(LowerBound(arr, 4));
        Console.WriteLine(UpperBound(arr, 4));
    }
}