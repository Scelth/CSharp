public class PriQueue<T> where T : IComparable<T>
{
    private List<T> data;

    public PriQueue()
    {
        this.data = new List<T>();
    }

    public void Enqueue(T item)
    {
        data.Add(item);
        int a = data.Count - 1;
        while (a > 0)
        {
            int b = (a - 1) / 2;
            if (data[a].CompareTo(data[b]) >= 0)
            {
                break;
            }

            T tmp = data[a];
            data[a] = data[b];
            data[b] = tmp;
            a = b;
        }
    }

    public T Peek()
    {
        T item = data[0];
        return item;
    }

    public int Count()
    {
        return data.Count;
    }
}