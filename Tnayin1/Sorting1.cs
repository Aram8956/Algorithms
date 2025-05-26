namespace SortignAlgoritms;

class Program
{
    public static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        } 
    }

    public static void SelectionSort(int[] arr)
    {
        int min = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
    }

    public static void InsertionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int key = i;
            for (int j = i - 1; j >= 0; j--)
            {
                if (arr[j] > arr[key])
                {
                    int temp = arr[j];
                    arr[j] = arr[key];
                    arr[key] = temp;
                    key = j;
                }
            }
        }
    }

static void Main(string[] args)
    {
        int[] arr = new int[] { 210, 11, 25, 14, 58, 66};
        //BubbleSort(arr);
        //SelectionSort(arr);
        InsertionSort(arr);
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}