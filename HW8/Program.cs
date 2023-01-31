// Пространство Методов!
void FillArrayWithRandom(int[,] matrix)   //Общий
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }

    }
}

void PrintMatrix(int[,] matrix)   //Общий
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] ArrayFill(int[] array)   //Общий Сделала рандомное заполнение и проверку чисел на повторяемость
{
    bool check = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10, 18);
        for (int j = i - 1; j >= 0; j--)
        {
            if (array[i] == array[j])
            { check = true; }
            if (check)
            { i = i - 1; }
        }
        check = false;
    }
    return array;
}

void RowsOrder(int[,] matrix)    //Для задачи 54
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int count = 0; count < matrix.GetLength(1); count++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)

            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j + 1];
                    matrix[i, j + 1] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }

    }

}

void RowsSumCompaire(int[,] matrix, int[] summary, int sum) //Для задачи 56
{
    int k = 0;
    int lenght = matrix.GetLength(0);
    summary = new int[lenght];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        summary[k] = sum;
        k++;
    }
    for (k = 0; k < lenght; k++)
    {
        Console.Write(summary[k] + "\t");
    }
    Console.WriteLine();
    {
        k = 0;
        int min = summary[k];
        string minimum = $"{k}";
        int count = 0;
        for (k = 1; k < lenght; k++)
        {
            if (summary[k] < min)
            {
                minimum = new string($"{k}");
                min = summary[k];
                count = k;
            }
        }
        for (k = 1; k < lenght; k++)
        {
            if (summary[k] == min && k != count)
            {
                minimum = new string($"{minimum}, {k}");
            }
        }
        Console.WriteLine("Минимальная сумма: " + min);
        Console.WriteLine();
        Console.WriteLine("Минимальная сумма в строке под индексом: " + minimum);
    }
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] matrixResult)  //Для задачи 58
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrixResult[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    int[,] result = matrixResult;
    return result;
}

void CubeMatrix(int[,,] matrix, int[] array, int m)   //Для задачи 60
{
    if (m < array.GetLength(0))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i, j, k] = array[m];
                    Console.Write(matrix[i, j, k] + $"{(i, j, k)}  ");
                    m++;
                }
                Console.WriteLine();
            }
        }
    }

}

int[,] SpiralMatrix(int[,] matrix)   //Для задачи 62 Сделала для матрицы любого размера
{
    int i = 0;
    int j = 0;
    matrix[i, j] = 10;

    for (int count = 0; count < matrix.Length; count++)
    {
        while (j < matrix.GetLength(1) - 1)
        {
            if (matrix[i, j + 1] == 0)   //right
            {
                matrix[i, j + 1] = matrix[i, j] + 1;
                j++;
            }
            else break;
        }
        while (i < matrix.GetLength(0) - 1)
        {
            if (matrix[i + 1, j] == 0)
            {
                matrix[i + 1, j] = matrix[i, j] + 1;    //down
                i++;
            }
            else break;
        }
        while (j > 0)
        {
            if (matrix[i, j - 1] == 0)   //left
            {
                matrix[i, j - 1] = matrix[i, j] + 1;
                j--;
            }
            else break;
        }
        while (i > 0)
        {
            if (matrix[i - 1, j] == 0)    //up
            {
                matrix[i - 1, j] = matrix[i, j] + 1;
                i--;
            }
            else break;
        }
    }
    return matrix;
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("Задача 54");
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = new int[m, n];
FillArrayWithRandom(matrix);
PrintMatrix(matrix);
RowsOrder(matrix);
PrintMatrix(matrix);
Console.WriteLine();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Задача 56 (Решила с учётом нескольких минимумов (Использую матрицу из Задачи 54))");
int[] summary = new int[matrix.GetLength(1)];
RowsSumCompaire(matrix, summary, 0);
Console.WriteLine();

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Задача 60");
int[] arrayParent = new int[8];
ArrayFill(arrayParent);
int[,,] matrixCube = new int[2, 2, 2];
CubeMatrix(matrixCube, arrayParent, 0);
Console.WriteLine();

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Задача 58");
int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] matrixResult = new int[2, 2];
FillArrayWithRandom(matrix1);
PrintMatrix(matrix1);
FillArrayWithRandom(matrix2);
PrintMatrix(matrix2);
MultiplyMatrix(matrix1, matrix2, matrixResult);
PrintMatrix(matrixResult);
Console.WriteLine();

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.WriteLine("Задача 62");
int[,] spiralMatrix = new int[9, 8];
SpiralMatrix(spiralMatrix);
PrintMatrix(spiralMatrix);
