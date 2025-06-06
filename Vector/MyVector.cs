
namespace MyVector
{
    public class MyVector<T>: IEnumerable<T>
    {
        public T[] arr;
        public int size;
        public int cap;

        public MyVector(int size)
        {
            cap = size;
            arr = new T[size];
        }

        public MyVector()
        {
            cap = 0;
            size = 0;
            arr = new T[size];
        }

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        public void PushBack(T item)
        {
            if (size == cap)
            {
                if (cap == 0)
                {
                    cap = 1;
                }
                else
                {
                    cap *= 2;
                }

                T[] newArr = new T[cap];
                for (int i = 0; i < size; i++)
                {
                    newArr[i] = arr[i];
                }
                arr = newArr;
            }

            arr[size++] = item;
        }

        public void PopBack()
        {
            --size;
        }

        public void Insert(T item, int position)
        {
            if (size == cap || position >= size)
            {
                PushBack(item);
                return;
            }
            size++;
            for (int i = size; i >= position; --i)
            {
                arr[i] = arr[i - 1];

            }
            arr[position] = item;
        }

        public void Erase(int position)
        {
            if (position >= size || position < 0)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = position; i < size - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            --size;
        }

        public void ShrinkToFit()
        {
            cap = size;
            T[] temp = new T[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = arr[i];
            }

            arr = temp;
        }

        public void Resize(T val, int count)
        {
            if (count == size)
            {
                return;
            }

            if (count > size)
            {
                if (count > cap)
                {
                    T[] newArr = new T[count];
                    for (int i = 0; i < size; i++)
                    {
                        newArr[i] = arr[i];
                    }
                    arr = newArr;
                    cap = count;
                }
                for (int i = size; i < count; ++i)
                {
                    arr[i] = val;
                }
                size = count;
            }
            else if (count < size)
            {
                size = count;
            }
        }

        public void Clear()
        {
            size = 0;
            cap = 0;
            arr = new T[size];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return arr[i];
            }
        }
        
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }
}