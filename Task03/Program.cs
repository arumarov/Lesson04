// ЗАДАЧА 3. Дан целочисленный двумерный массив, размерности n х m. Найти сумму и произведение элементов, кратных 3 и 5.

// Мое решение
/*void SetArray2D(int[,] a) 
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

int Sum3_5(int[,] a) 
{
int result = 0;
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
        if (a[i,j]%3==0 && a[i,j]%5==0) result = result + a[i,j];
   }
}
   return result;
}

double Multi3_5(int[,] a) 
{
double result = 1;
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
       if (a[i,j]%3==0 && a[i,j]%5==0) result = result * a[i,j]; 
   }
}
   return result;
}

int[,] a;
a=new int[10,10]; 

SetArray2D(a);
Print(a);
Console.Write("Сумма элементов, кратных 3 и 5: " + $"{Sum3_5(a)}");
Console.Write("\nПроизведение элементов, кратных 3 и 5: " + $"{Multi3_5(a)}");*/

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

void Task03(int[,] a, out int sum, out int multi) 
{
    sum = 0;
    multi = 1;
   for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
      if (a[i,j]%3==0 && a[i,j]%5==0) {sum = sum+a[i,j]; multi = multi*a[i,j];};
   }
}
}

int[,] a;
a=new int[5,5]; 

SetArray2D(a);
Print(a);
int s,m;
Task03(a,out s,out m);
Console.Write("Сумма элементов, кратных 3 и 5: " + $"{s}");
Console.Write("\nПроизведение элементов, кратных 3 и 5: " + $"{m}");