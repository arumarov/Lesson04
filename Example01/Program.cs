// // Двумерные массивы (вывод без метода)
// int[,] a;
// a=new int[6,8]; // создание массива 

// for(int i=0; i<a.GetLength(0); i++)
// {
//    for(int j=0; j<a.GetLength(1); j++)
//    {
//        a[i,j]=i*10+j; // заполняем массив
//    }
// }

// for(int i=0; i<a.GetLength(0); i++)
// {
//    for(int j=0; j<a.GetLength(1); j++)
//    {
//        Console.Write($"{a[i,j],4}"); // Печатаем, форматируем - выделяем 4 символа для каждого аргумента
//    }
//    Console.WriteLine();
// }


// Двумерные массивы (вывод с помощью метода)

void SetArray2D(int[,] a) // метод заполнения массива
{
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
       a[i,j]=i*10+j; // заполняем массив
   }
}
}

void Print(int[,] a) // метод печати массива
{
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
       Console.Write($"{a[i,j],4}"); // Печатаем, форматируем - выделяем 4 символа для каждого аргумента
   }
   Console.WriteLine();
}
}

int[,] a;
a=new int[6,8]; // создание массива

SetArray2D(a);
Print(a);