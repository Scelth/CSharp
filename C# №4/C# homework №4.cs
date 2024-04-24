#region 1 Задание
Array ar = new();
ICalc calc = ar;
Console.WriteLine($"The number of values less than {ar.array[0]}: {calc.Less(ar.array[0])}");
Console.WriteLine($"The number of values greater than {ar.array[0]}: {calc.Greater(ar.array[0])}");

interface ICalc
{
    public int min { get; set; }
    public int max { get; set; }
    public int Less(int valueToCompare);
    public int Greater(int valueToCompare);
}

class Array : ICalc
{
    public int[] array = new int[5] { 5, 2, 3, 1, 7 };

    public int min { get; set; }
    public int max { get; set; }

    public int Greater(int valueToCompare)
    {
        max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > valueToCompare)
            {
                max++;
            }
        }
        return max;
    }

    public int Less(int valueToCompare)
    {
        min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < valueToCompare)
            {
                min++;
            }
        }
        return min;
    }
}
#endregion



#region 2 Задание
Array ar = new();
IOutput output = ar;
Console.Write("Even array elements: ");
output.ShowEven();
Console.Write("\nOdd array elements: ");
output.ShowOdd();
Console.WriteLine();

interface IOutput
{
    public void ShowEven();
    public void ShowOdd();
}

class Array : IOutput
{
    public int[] array = new int[5] { 5, 2, 3, 1, 7 };
    public void ShowEven()
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                Console.Write(array[i] + " ");
            }
        }
    }

    public void ShowOdd()
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
#endregion



#region 3 Задание
                   // В данном задании реализовать метод int EqualToValue(int valueToCompare) у меня не получилось :(
Array ar = new();
ICalc calc = ar;
Console.WriteLine($"The number of unique elements in the array: {calc.CountDistinct()}");

interface ICalc
{
    public int CountDistinct();
}

class Array : ICalc
{
    public int[] array = new int[5] { 5, 2, 3, 5, 7 };

    public int CountDistinct()
    {
        return array.Distinct().Count();
    }
}
#endregion