namespace Node;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> list = new MyList<int>();

        Console.WriteLine("== PushFront ==");
        list.PushFront(20);
        list.PushFront(10);
        list.Print();  // 10 -> 20

        Console.WriteLine("== PushBack ==");
        list.PushBack(30);
        list.PushBack(40);
        list.Print();  // 10 -> 20 -> 30 -> 40

        Console.WriteLine("== Insert at index 2 ==");
        list.Insert(25, 2);
        list.Print();  // 10 -> 20 -> 25 -> 30 -> 40

        Console.WriteLine("== Erase at index 3 ==");
        list.Erase(3);
        list.Print();  // 10 -> 20 -> 25 -> 40

        Console.WriteLine("== Size ==");
        Console.WriteLine(list.Size()); // 4
    }
}