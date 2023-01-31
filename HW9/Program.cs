// Все задачи решаются с помощью рекурсии
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbers(int number)
{
    Console.Write(number + " ");
    if (number == 1)
    {
        return;
    }
    PrintNumbers(number - 1);
}
Console.WriteLine("Задача 64");
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
PrintNumbers(num);
Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void NumbersSumSection(int M, int N, int Sum)
{
    if (M == N)
    {
        Console.Write(Sum);
        return;
    }
    NumbersSumSection(M + 1, N, Sum + M + 1);
}

Console.WriteLine("Задача 66");
Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
NumbersSumSection(M, N, M);
Console.WriteLine();

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Задача 68");
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Akkerman(m, n);
Console.WriteLine(Akkerman(m, n));


