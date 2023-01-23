// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// static void FillArray(int[] array, int n)
// {

//     for (int i = 0; i < n; i++)
//     {
//         Console.Write($"A[{i}] = ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// Console.Write("Количество элементов массива = ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int count = 0;

// FillArray(array, n);

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     { count++; }

// }
// Console.WriteLine($"Чисел больше ноля в массиве: {count} ");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (double)(b2 - b1) / (k1 - k2);
double y = (double)k1 * x + b1;
Console.WriteLine();
Console.Write($"A[{x},{y}]");


