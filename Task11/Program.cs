// ЗАДАЧА 11. Дан целочисленный двумерный массив, размерности n х m. 
// Вывести его элементы, индексы которых являются степенями двойки (1, 2, 4, 8, 16, ...)

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

void PrintArray2 (int[,] a)
{
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
        {
            for (int x=0;x<10;x++)
            {
                if (i==(Math.Pow(2,x-1)) || j==(Math.Pow(2,x-1))) Console.Write($"{a[i,j],4}");
            }

        }
        Console.WriteLine();
    }
}

int[,] a;
a = new int[10,10];
SetArray2D(a);
PrintArray(a);
Console.WriteLine("Элементы, индексы которых являются степенями двойки: ");
PrintArray2(a);