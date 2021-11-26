//Задача 7. Дан целочисленный двумерный массив, размерности n х m. Заменить все элементы на их квадраты

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

void Quatro(int[,] a) 
{

   for(int i=0; i<a.GetLength(0); i++)
   {
      for(int j=0; j<a.GetLength(1); j++)
     {
        a[i,j]=a[i,j]*a[i,j];
	    Console.Write($"{a[i,j],5}");
     }
     Console.WriteLine();
   }
}


int[,] a;
a=new int[5,5]; 

SetArray2D(a);
Print(a);
Console.WriteLine("Новый массив: ");
Quatro(a);