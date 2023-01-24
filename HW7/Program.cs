// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7(ввод индексов) -> такого числа в массиве нет
// 1, 1 -> 9

// void FillArrayWithDouble(double[,] matrix, int m, int n)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().NextDouble();
//             Console.Write(Math.Round(matrix[i, j], 2) + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void CheckElement(double[,] matrix, int m, int n)
// {
//     if (m <= matrix.GetLength(0) && n <= matrix.GetLength(1))
//     {
//         Console.WriteLine(Math.Round(matrix[m, n], 2));
//     }
//     else
//     {
//         Console.WriteLine("Элемент отсутствует");
//     }
// }
// double[,] matrix = new double[3, 4];
// FillArrayWithDouble(matrix, 3, 4);

// Console.WriteLine("Введите число k:");
// int k = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число l:");
// int l = Convert.ToInt32(Console.ReadLine());

// CheckElement(matrix, k, l);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0,10);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void Average(int[,] matrix, int sum)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        double average = (double)sum / matrix.GetLength(0);
        sum = 0;
        Console.Write(Math.Round(average,2) + "\t");
    }
}
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = new int[m, n];
FillArrayWithRandom(matrix, m, n);
Console.WriteLine();
Average(matrix, 0);
