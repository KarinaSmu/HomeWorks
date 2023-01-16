// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("ВВедите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите число: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for (int i = 1; i < B; i++)
{
    result *= A;
}
Console.WriteLine(result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("ВВедите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int Number(int numb)

{
    int result;
    for (result = 0; numb > 0; numb /= 10)
    {
        result += numb % 10;
    }
    return result;
}
Console.WriteLine(Number(N));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int [8];
Console.Write("Ваш массив: ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
    Console.Write(array[i] + ", ");
}



