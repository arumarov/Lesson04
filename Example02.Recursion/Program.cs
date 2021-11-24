// Вывести на экран числа от 1 до 10, не используя операторы цикла

// void Loop(int i)
// {
//     Console.Write($"{i} ");
//     if (i<10) Loop(i+1);
// }

// Loop(1);


// // Вывод факториала с применением рекурсии

// ulong F(ulong n)
// {
//     if (n==0) return 1;
//     else return F(n-1)*n;
// }

// Console.WriteLine(F(10));

// // Вывод чисел Фибоначчи с применением рекурсии
// Мое решение (вызов последнего числа Фибоначчи)
ulong Fibo(ulong n)
{
    if (n==0) return 1;
    if (n==1) return 1;
    else return Fibo(n-1)+Fibo(n-2);

}

Console.WriteLine(Fibo(5));
