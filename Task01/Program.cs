// ЗАДАЧА 1. Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение всех элементов массива.
// Мое решение
// void SetArray2D(int[,] a) 
// {
// for(int i=0; i<a.GetLength(0); i++)
// {
//    for(int j=0; j<a.GetLength(1); j++)
//    {
//        a[i,j]=new Random().Next(1,15); 
//    }
// }
// }

// void Print(int[,] a) 
// {
// for(int i=0; i<a.GetLength(0); i++)
// {
//    for(int j=0; j<a.GetLength(1); j++)
//    {
//        Console.Write($"{a[i,j],4}"); 
//    }
//    Console.WriteLine();
// }
// }

// int Sum(int[,] a) 
// {
// int result = 0;
// for(int i=0; i<a.GetLength(0); i++)
// {
//    for(int j=0; j<a.GetLength(1); j++)
//    {
//        result = result + a[i,j]; 
//    }
// }
//    return result;
// }

// double Multi(int[,] a) 
// {
// double result = 1;
// for(int i=0; i<a.GetLength(0); i++)
// {
//    for(int j=0; j<a.GetLength(1); j++)
//    {
//        result = result * a[i,j]; 
//    }
// }
//    return result;
// }

// int[,] a;
// a=new int[5,5]; 

// SetArray2D(a);
// Print(a);
// Console.Write("Сумма всех элементов: " + $"{Sum(a)}");
// Console.Write("\nПроизведение всех элементов: " + $"{Multi(a)}");

//Решение от преподавателя
void SetArray2D(int[,] a) 
{
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
       a[i,j]=new Random().Next(1,15); 
   }
}
}

void Print(int[,] a) 
{
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
       Console.Write($"{a[i,j],4}"); 
   }
   Console.WriteLine();
}
}

void Task01(int[,] a, out int sum, out int multi) // возвращаем несколько результатов, поэтому возвращаем через out
{
    sum = 0;
    multi = 0;
}

int[,] a;
a=new int[5,5]; 

SetArray2D(a);
Print(a);
int s,m;
Task01(a,out s,out m);