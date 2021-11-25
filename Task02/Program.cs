// ЗАДАЧА 2. Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение четных элементов
// Мое решение
/*void SetArray2D(int[,] a) 
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

int SumEven(int[,] a) 
{
int result = 0;
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
        if (a[i,j]%2==0) result = result + a[i,j];
   }
}
   return result;
}

double MultiEven(int[,] a) 
{
double result = 1;
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
       if (a[i,j]%2==0) result = result * a[i,j]; 
   }
}
   return result;
}

int[,] a;
a=new int[5,5]; 

SetArray2D(a);
Print(a);
Console.Write("Сумма четных элементов: " + $"{SumEven(a)}");
Console.Write("\nПроизведение четных элементов: " + $"{MultiEven(a)}");*/

//Решение с семинара

void SetArray2D(int[,] a) 
{
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
       a[i,j]=new Random().Next(1,99); 
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

void Task02(int[,] a, out int sum, out int multi) 
{
    sum = 0;
    multi = 1;
   for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
      if (a[i,j]%2==0) {sum = sum+a[i,j]; multi = multi*a[i,j];};
   }
}
}

int[,] a;
a=new int[5,5]; 

SetArray2D(a);
Print(a);
int s,m;
Task02(a,out s,out m);
Console.Write("Сумма четных элементов: " + $"{s}");
Console.Write("\nПроизведение четных элементов: " + $"{m}");