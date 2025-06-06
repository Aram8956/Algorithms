namespace MyVector;

class Program
{
    static void Main(string[] args)
    {
        var vec = new MyVector<int>();

        Console.WriteLine("PushBack 5 elements:");
        for (int i = 1; i <= 5; i++)
        {
            vec.PushBack(i * 10);
            Console.WriteLine($"Added: {vec[i - 1]}");
        }

        Console.WriteLine("\nAccess elements with indexer:");
        for (int i = 0; i < vec.size; i++)
        {
            Console.WriteLine($"vec[{i}] = {vec[i]}");
        }

        Console.WriteLine($"\nSize: {vec.size}, Capacity: {vec.cap}");

        Console.WriteLine("\nInserting 99 at position 2:");
        vec.Insert(99, 2);
        for (int i = 0; i < vec.size; i++)
        {
            Console.WriteLine($"vec[{i}] = {vec[i]}");
        }

        Console.WriteLine("\nErasing element at position 3:");
        vec.Erase(3);
        for (int i = 0; i < vec.size; i++)
        {
            Console.WriteLine($"vec[{i}] = {vec[i]}");
        }

        Console.WriteLine("\nPopBack:");
        vec.PopBack();
        for (int i = 0; i < vec.size; i++)
        {
            Console.WriteLine($"vec[{i}] = {vec[i]}");
        }

        Console.WriteLine($"\nBefore Resize: size = {vec.size}, capacity = {vec.cap}");

        Console.WriteLine("\nResizing to 10 elements with default value 777:");
        vec.Resize(777, 10);
        for (int i = 0; i < vec.size; i++)
        {
            Console.WriteLine($"vec[{i}] = {vec[i]}");
        }
        
        vec.PushBack(123);
        
        Console.WriteLine($"\nBefore ShrinkToFit: capacity = {vec.cap}");
        int index = 0;
        foreach (var i in vec)
        {
            Console.WriteLine($"vec[{index++}] = {i}");
        }
        vec.ShrinkToFit();
        Console.WriteLine($"After ShrinkToFit: capacity = {vec.cap}");
        index = 0;
        foreach (var i in vec)
        {
            Console.WriteLine($"vec[{index++}] = {i}");
        }

        Console.WriteLine("\nClearing vector...");
        vec.Clear();
        Console.WriteLine($"After clear: size = {vec.size}, capacity = {vec.cap}");
    }
}
