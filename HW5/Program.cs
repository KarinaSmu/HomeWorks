// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] FillArrayWithTripple(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);

//     }
//     return array;
// }

// int[] array = new int[4];
// FillArrayWithTripple(array);
// Console.Write("Ваш случайный массив: ");
// Console.Write(string.Join(", ", array));
// Console.WriteLine();
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//         if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }
//  Console.Write(count);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] FillArrayWithRandom(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-99, 100);

//     }
//     return array;
// }

// int[] array = new int[4];
// FillArrayWithRandom(array);
// Console.Write("Ваш случайный массив: ");
// Console.Write(string.Join(", ", array));
// Console.WriteLine();
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (i % 2 > 0)
//     {
//         sum += array[i];
//     }
// }
// Console.Write(sum);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArrayWithDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);

    }
    return array;
}

double[] array = new double[4];
FillArrayWithDouble(array);
Console.Write("Ваш случайный массив: ");

double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else
      if (array[i] < min)
    {
        min = array[i];
    }

}
double result = max - min;

Console.Write(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine(max);
Console.WriteLine(min);
Console.Write("Разница: " + result);