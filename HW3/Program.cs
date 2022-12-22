// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Задача 19 ");
Console.WriteLine("Введите пятизначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
string number = num1.ToString();

if (num1 < 10000 || num1 > 99999)
{
    Console.WriteLine("Введено недопустимое значение");
}
else if (number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine("Данное число - полиндром");
}
else
{ Console.WriteLine("Данное число - не полиндром"); }



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача 21 ");
Console.WriteLine("Введите координаты первой точки ");
int X1 = Convert.ToInt32(Console.ReadLine());
int Y1 = Convert.ToInt32(Console.ReadLine());
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");
int X2 = Convert.ToInt32(Console.ReadLine());
int Y2 = Convert.ToInt32(Console.ReadLine());
int Z2 = Convert.ToInt32(Console.ReadLine());


double result = Math.Round(Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2)), 2);
Console.WriteLine(result);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Задача 8");
Console.WriteLine("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());

for (int temp = 1; temp <= numN; temp++)
{
    Console.Write(Math.Pow(temp, 3) + "  ");
}


