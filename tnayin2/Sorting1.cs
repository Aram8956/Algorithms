using System.Diagnostics;

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

    public static void MergeSort(int[] arr, int l, int r)
    {
        if (l == r)
        {
            return;
        }

        int mid = (l + r) / 2;
        MergeSort(arr, l, mid);
        MergeSort(arr, mid + 1, r);
        Merge(arr, l, r, mid);
    }

    public static void Merge(int[] arr, int l, int r, int mid)
    {
        int index = l;
        int l1 = l;
        int r1 = mid;
        int l2 = mid + 1;
        int r2 = r;
        int[] tmp = new int[r - l + 1];
        int i = 0;
        while (l1 <= r1 && l2 <= r2)
        {
            if (arr[l1] <= arr[l2])
            {
                tmp[i] = arr[l1++];
            }
            else
            {
                tmp[i] = arr[l2++];
            }

            ++i;
        }
        while (l1 <= r1)
        {
            tmp[i] = arr[l1++];
            ++i;
        }
        while (l2 <= r2)
        {
            tmp[i] = arr[l2++];
            ++i;
        }
        for (int j = 0; j < tmp.Length; j++)
        {
            arr[index++] = tmp[j];
        }

        return;
    }

static void Main(string[] args)
    {
        // int[] arr = new int[] { 210, 11, 25, 14, 58, 66};
        // int[] arr1 = new int[] { 210, 11, 25, 14, 58, 66};
        // //BubbleSort(arr);
        // //SelectionSort(arr);
        // //InsertionSort(arr);
        // MergeSort(arr, 0, arr.Length - 1);
        // foreach (var item in arr)
        // { 
        //     Console.WriteLine(item);
        // }
        
        
        //Stugenq chapery
        Stopwatch stop1 = new Stopwatch();
        Stopwatch stop2 = new Stopwatch();
        
        int[] array1 = new int[432];
        int[] array2 = new int[432];

        Random rand = new Random();

        for (int i = 0; i < 432; i++)
        {
            array1[i] = rand.Next(0, 432); 
            array2[i] = rand.Next(0, 432);
        }
        
        stop1.Start();
        InsertionSort(array1);
        stop1.Stop();
        Console.WriteLine("Insertion sort: " + stop1.Elapsed.TotalMilliseconds + " ms");
        

        stop2.Start();
        MergeSort(array2, 0, array2.Length - 1);
        stop2.Stop();
        Console.WriteLine("Merge sort: " + stop2.Elapsed.TotalMilliseconds + " ms");
        
    }

}
