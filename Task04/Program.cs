// ЗАДАЧА 4. Дан целочисленный двумерный массив, размерности n х m. Найти количество отрицательных элементов, больше -9.

void SetArray2D(int[,] a) 
{
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
       a[i,j]=new Random().Next(-15,15); 
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

int Quantity9(int[,] a) 
{
int result = 0;
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
        if (a[i,j]<0 && a[i,j]>-9) result = result + 1;
   }
}
   return result;
}


int[,] a;
a=new int[5,5]; 

SetArray2D(a);
Print(a);
Console.Write("Количество отрицательных элементов, больше -9: " + $"{Quantity9(a)}");