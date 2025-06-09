namespace Node;

public class MyList<T>
{
    public T value;
    public MyList<T> next;

    public MyList()
    {
        value = default(T);
        next = null;
    }

    private MyList(T value)
    {
        this.value = value;
        next = null;
    }

    private MyList(T value, MyList<T> next)
    {
        this.value = value;
        this.next = next;
    }

    public int Size()
    {
        int size = 0;
        MyList<T> temp = next;
        if (next == null)
        {
            return 0;
        }

        while (temp != null)
        {
            temp = temp.next;
            size += 1;
        }

        return size;
    }

    public void Print()
    {
        MyList<T> temp = next;
        while (temp != null)
        {
            Console.Write(temp.value);
            Console.Write("->");
            temp = temp.next;
        }

        Console.WriteLine();
    }
    
    public void PushBack(T item)
    {
        MyList<T> newNode = new MyList<T>(item);
        MyList<T> dummy = next;
        if (dummy == null)
        {
            dummy.next = newNode;
            return;
        }
        while (dummy.next != null)
        {
            dummy = dummy.next;
        }
        dummy.next = newNode;
    }

    public void PushFront(T item)
    {
        MyList<T> newNode = new MyList<T>(item);
        newNode.next = next;
        next = newNode;
    }

    public void Insert(T item, int index)
    {
        if (index > Size())
        {
            throw new IndexOutOfRangeException();
        }
        MyList<T> newNode = new MyList<T>(item);
        MyList<T> dummy = this;
        for (int i = 0; i < index; ++i)
        {
            dummy = dummy.next;
        }
        newNode.next = dummy.next;
        dummy.next = newNode;
    }

    public void Erase(int index)
    {
        int length = Size();
        if (index > length || index < 0)
        {
            throw new IndexOutOfRangeException();
        }


        MyList<T> dummy = this;
        for (int i = 0; i < index; ++i)
        {
            dummy = dummy.next;
        }
        
        MyList<T> newNode = dummy.next;
        dummy.next = newNode.next;
        newNode.next = null;
    }
}