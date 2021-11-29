// ЗАДАЧА 8. Дан целочисленный двумерный массив, размерности n х m. Найти среднее арифметическое всех элементов массива

void SetArray2D (int [,] a)
{
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=new Random().Next(1,99);
        }
    }
}

void PrintArray (int[,] a)
{
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
        {
            Console.Write($"{a[i,j],4}");
        }
        Console.WriteLine();
    }
}

int Average (int[,] a)
{
    int temp=0;
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
        {
            temp=temp+a[i,j];
        }

    }
    return temp/100;
}

int[,] a;
a = new int[10,10];
SetArray2D(a);
PrintArray(a);
Console.WriteLine("Среднее арифметическое всех элементов массива: ");
Console.Write(Average(a));