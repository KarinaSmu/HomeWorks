// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Задача 10");
int number = new Random().Next(100, 999);
Console.WriteLine("Ваше случайное число: " + number);
int digit1 = number / 10;
int digit2 = digit1 % 10;
Console.WriteLine("Вторая цифра числа " + digit2);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Задача 13");
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 0)
{
    num1 = num1 * -1;
}
int numTemp = num1;
int numTemp2;
int count = num1.ToString().Length;
int[] nums = new int[count];
int i = 0;
if (count >= 3)
{
    while (i < count)
    {
        numTemp2 = numTemp % 10;
        nums[i] = numTemp2;
        numTemp = numTemp / 10;
        i++;
    }
    Console.WriteLine("Третья цифра числа " + nums[^3]);
}
else
{ Console.WriteLine("Третье число отсутствует"); }

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Задача 15");
Console.WriteLine("Введите число");
int numDay = Convert.ToInt32(Console.ReadLine());
if (numDay > 0 && numDay < 8)
{
    if (numDay > 0 && numDay < 6)
    { Console.WriteLine("Этот день - рабочий"); }
    else { Console.WriteLine("Этот день - выходной"); }
}
else { Console.WriteLine("Число не соответствует дню недели"); }

