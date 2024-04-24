#region 1 Задание

    #region Создание массива и матрицы
int[] A = new int[5];
Console.WriteLine("Enter the elements of array A:");

for (int i = 0; i < A.Length; i++)
{
    Console.Write($"A[{i}] = ");
    A[i] = Int32.Parse(Console.ReadLine());
}

int[,] B = new int[3, 4];

Random rnd = new();
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        B[i, j] = rnd.Next(2, 6);
    }
}

Console.WriteLine("\nFirst array: ");
for (int i = 0; i < A.Length; i++)
{
    Console.Write(A[i] + "\t");
}
Console.WriteLine();

Console.WriteLine("\nMatrix B: ");
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        Console.Write(B[i, j] + "\t");
    }
    Console.WriteLine();
}
    #endregion

    #region Поиск общего минимального и максимального элементов
int maxA = A[0];
for (int i = 1; i < A.Length; i++)
{
    if (A[i] > maxA)
    {
        maxA = A[i];
    }
}

int maxB = B[0, 0];
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        if (B[i, j] > maxB)
        {
            maxB = B[i, j];
        }
    }
}

int max = Math.Max(maxA, maxB);
Console.WriteLine("\nCommon maximum element: " + max);

int minA = A[0];
for (int i = 1; i < A.Length; i++)
{
    if (A[i] < minA)
    {
        minA = A[i];
    }
}

int minB = B[0, 0];
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        if (B[i, j] < minB)
        {
            minB = B[i, j];
        }
    }
}

int min = Math.Min(minA, minB);
Console.WriteLine("Common minimum element: " + min);
#endregion

    #region Сумма элементов массива и матрицы
int sumA = 0;
for (int i = 0; i < A.Length; i++)
{
    sumA += A[i];
}

int sumB = 0;
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        sumB += B[i, j];
    }
}

int sum = sumA + sumB;
Console.WriteLine("Total sum of elements: " + sum);
    #endregion

    #region Произведение элементов массива и матрицы
int compA = 1;
for (int i = 0; i < A.Length; i++)
{
    compA *= A[i];
}

int compB = 1;
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        compB *= B[i, j];
    }
}

int comp = compA * compB;
Console.WriteLine("Total composition of elements: " + comp);
#endregion

    #region Сумма четных эелементов массива
sumA = 0;
for (int i = 0; i < A.Length; i++)
{
    if (A[i] % 2 == 0)
    {
        sumA += A[i];
    }
}
Console.WriteLine("Sum of the even elements of the array A: " + sumA);
#endregion

    #region Сумма нечетных столбцов матрицы
sumB = 0;
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        if(j % 2 == 0)
        {
            sumB += B[i, j];
        }
    }
}
Console.WriteLine("Sum of the odd columns of the array in: " + sumB);
#endregion

#endregion

#region 2 Задание
//Random rnd = new();

//int[,] array = new int[5, 5];

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[i, j] = rnd.Next(-100, 100);
//        Console.Write(array[i, j]);
//        Console.Write('\t');
//        if (j == 4)
//        {
//            Console.WriteLine();
//        }
//    }
//}
//int sum = 0;

//int min = 0;
//int max = 0;

//for (int i = 0; i < array.GetLength(0); i++)
//{

//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (min > array[i, j])
//        {
//            min = array[i, j];
//        }

//        if (max < array[i, j])
//        {
//            max = array[i, j];
//        }
//    }
//}

//Console.WriteLine("\nMin: " + min);
//Console.WriteLine("Max: " + max);

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] > min && array[i, j] < max)
//        {
//            sum += array[i, j];
//        }
//    }
//}

//Console.WriteLine("\nThe sum of the elements located between the maximum and minimum elements: " + sum);
#endregion

#region 3 Задание
//Console.WriteLine("Enter the message that will be encoded.");
//string text = Console.ReadLine();
//string res = "";

//for (int i = 0; i < text.Length; i++)
//{
//    res += Convert.ToChar(Convert.ToInt16(text[i]) - 3);
//}

//Console.WriteLine(res);
#endregion

#region 4 Задание
//Random rnd = new();
//int[,] array1 = new int[5, 5];
//int[,] array2 = new int[5, 5];

//Console.WriteLine("First matrix.");
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        array1[i, j] = rnd.Next(100);
//        Console.Write(array1[i, j]);
//        Console.Write('\t');
//        if (j == 4)
//        {
//            Console.WriteLine();
//        }
//    }
//}

//Console.WriteLine("\nEnter expression (*, +, /).");
//string exp = Console.ReadLine();

//if (exp == "*")
//{
//    Console.WriteLine("\nSelect the number you want to multiply by.");
//    int num = Int32.Parse(Console.ReadLine());
//    Console.WriteLine();
//    for (int i = 0; i < 5; i++)
//    {
//        for (int j = 0; j < 5; j++)
//        {
//            array2[i, j] = array1[i, j] * num;
//            Console.Write(array2[i, j]);
//            Console.Write('\t');
//            if (j == 4)
//            {
//                Console.WriteLine();
//            }
//        }
//    }
//}

//else if (exp == "+")
//{
//    Console.WriteLine("\nSecond matrix.");
//    for (int i = 0; i < 5; i++)
//    {
//        for (int j = 0; j < 5; j++)
//        {
//            array2[i, j] = rnd.Next(100);
//            Console.Write(array2[i, j]);
//            Console.Write('\t');
//            if (j == 4)
//            {
//                Console.WriteLine();
//            }
//        }
//    }

//    Console.WriteLine("\nSum of two matrices");
//    for (int i = 0; i < 5; i++)
//    {
//        for (int j = 0; j < 5; j++)
//        {
//            array2[i, j] = array1[i, j] + array2[i, j];
//            Console.Write(array2[i, j]);
//            Console.Write('\t');
//            if (j == 4)
//            {
//                Console.WriteLine();
//            }
//        }
//    }
//}

//else if (exp == "/")
//{
//    Console.WriteLine("\nSelect the number you want to divide by.");
//    int num = Int32.Parse(Console.ReadLine());
//    Console.WriteLine();
//    for (int i = 0; i < 5; i++)
//    {
//        for (int j = 0; j < 5; j++)
//        {
//            array2[i, j] = array1[i, j] / num;
//            Console.Write(array2[i, j]);
//            Console.Write('\t');
//            if (j == 4)
//            {
//                Console.WriteLine();
//            }
//        }
//    }
//}
#endregion

#region 5 Задание
//Console.WriteLine("Enter an arithmetic expression.");
//string exp = Console.ReadLine();

//if(exp == "+")
//{
//    Console.WriteLine("Enter the numbers");
//    Console.Write("A = ");
//    int a = Int32.Parse(Console.ReadLine());
//    Console.Write("B = ");
//    int b = Int32.Parse(Console.ReadLine());
//    int res = a + b;

//    Console.WriteLine(a + " + " + b + " = " + res);
//}

//else if (exp == "-")
//{
//    Console.WriteLine("Enter the numbers");
//    Console.Write("A = ");
//    int a = Int32.Parse(Console.ReadLine());
//    Console.Write("B = ");
//    int b = Int32.Parse(Console.ReadLine());
//    int res = a - b;

//    Console.WriteLine(a + " - " + b + " = " + res);
//}
#endregion

#region 6 Задание
//using System.Text;
//string str = Console.ReadLine();
//StringBuilder strB = new();
//strB.Append(str[0].ToString().ToUpper());

//for (int i = 1; i < str.Length; i++)
//{
//    if (char.IsWhiteSpace(str[i - 1]) && ".!?".IndexOf(str[i - 1]) != -1)
//    {
//        strB.Append(str[i].ToString().ToUpper());
//    }

//    else
//    {
//        strB.Append(str[i]);
//    }
//}
//Console.WriteLine(strB.ToString());
#endregion

#region 7 Задание
//string text = "\n\tTo be, or not to be, that is the question," +
//    "\n\tWhether 'tis nobler in the mind to suffer" +
//    "\n\tThe slings and arrows of outrageous fortune," +
//    "\n\tOr to take arms against a sea of troubles," +
//    "\n\tAnd by opposing end them? To die: to sleep;" +
//    "\n\tNo more; and by a sleep to say we end" +
//    "\n\tThe heart-ache and the thousand natural shocks" +
//    "\n\tThat flesh is heir to, 'tis a consummation" +
//    "\n\tDevoutly to be wish'd. To die, to sleep";

//Console.WriteLine("\n\tWithout changes" + text);
//text = text.Replace("die", "***");
//Console.WriteLine("\n\n\tWith changes" + text);
#endregion