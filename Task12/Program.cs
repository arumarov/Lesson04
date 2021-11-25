// ЗАДАЧА 12. Дан целочисленный двумерный массив, размерности n х m. Найти количество элементов кратных 7.

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

int Quantity7(int[,] a) 
{
int result = 0;
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
        if (a[i,j]%7==0) result = result + 1;
   }
}
   return result;
}


int[,] a;
a=new int[5,5]; 

SetArray2D(a);
Print(a);
Console.Write("Количество элементов, кратных 7: " + $"{Quantity7(a)}");