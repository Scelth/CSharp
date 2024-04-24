public class SinglyLinkedList<T>
{
    public class Node
    {
        public T Data;
        public Node Next;

        public Node(T data)
        {
            Data = data;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    public void Add(T data)
    {
        Node node = new Node(data);

        if (head == null)
        {
            head = node;
        }
        else
        {
            tail.Next = node;
        }

        tail = node;
        count++;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException();
        }

        Node current = head;
        for (int i = 0; i < index; i++)
        {
            current = current.Next;
        }

        return current.Data;
    }

    public int Count { get { return count; } }
}