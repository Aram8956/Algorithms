namespace Node;

public class MyList<T>: IEnumerable<T>
{
    private int count;
    public int Count => count;
    private Node<T> head;

    public void PushFront(T value)
    {
        var temp = new Node<T>(value);
        temp.next = head;
        head = temp;
        ++count;
    }

    public void PushBack(T value)
    {
        var temp = new Node<T>(value);
        if (head == null)
        {
            head = temp;
        }
        else
        {
            var dummy = head;
            while (dummy.next != null)
            {
                dummy = dummy.next;
            }
            dummy.next = temp;
        }
        ++count;
    }

    public void Insert(T value, int index)
    {
        if (index > count || index < 0)
        {
            throw new IndexOutOfRangeException();
        }
        if (index == 0)
        {
            PushFront(value);
            return;
        }
        
        var temp = new Node<T>(value);
        var dummy = head;
        for (int i = 0; i < index - 1; i++)
        {
            dummy = dummy.next;
        }

        temp.next = dummy.next;
        dummy.next = temp;
        ++count;
    }

    public void Erase(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException();
        }

        if (index == 0)
        {
            head = head.next;
        }
        else
        {
            var dummy = head;
            for (int i = 0; i < index - 1; i++)
            {
                dummy = dummy.next; 
            }
            var temp = dummy.next;
            dummy.next = dummy.next.next;
            temp.next = null;
        }
        --count;
    }

    public void Print()
    {
        var temp = head;
        foreach (var item in this)
        {
            Console.Write($"{item} -> ");
        }
        Console.Write("null");
        Console.WriteLine();
    }

    public IEnumerator<T> GetEnumerator()
    {
        var dummy = head;
        while (dummy != null)
        {
            yield return dummy.value;
            dummy = dummy.next;
        }
    }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator(); 
}