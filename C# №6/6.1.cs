Console.WriteLine("\n\tEnter your value!");
Console.Write("\tA - ");
int a = Int32.Parse(Console.ReadLine());
Console.Write("\tB - ");
int b = Int32.Parse(Console.ReadLine());
MyClass.Swap(a, b);

class MyClass
{
    public static void Swap<T>(T a, T b)
    {
        T temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"\n\tMethod Swap" +
            $"\n\tA - {a}" +
            $"\n\tB - {b}");
    }
}