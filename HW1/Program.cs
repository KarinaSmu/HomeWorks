// Задача 2 Напишите программу, которая принимает два числа на вход и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Задача 2");
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"первое число " + numberA + " больше второго числа " + numberB);
}
else if (numberA == numberB)
{ Console.WriteLine($"первое число " + numberA + " равно второму числу " + numberB); }

else
    Console.WriteLine($"первое число " + numberA + " меньше второго числа " + numberB);


// Задача 4 Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Задача 4");
Console.WriteLine("Введите три числа: ");

int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());
int[] nums = { numA, numB, numC };

int lenght = nums.Length;
int max = nums[0];
for(int i =0; i <nums.Length;i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    } 
}
Console.WriteLine("max->" + max);

// Задача 6 Напишите программу, которая принимает на вход число и выдает является ли оно чётным.

Console.WriteLine("Задача 6");
Console.WriteLine("Введите число: ");
int numX = Convert.ToInt32(Console.ReadLine());
if (numX % 2 == 0)
{
    Console.WriteLine("Данное число чётное");
}
else { Console.WriteLine("Данное число не чётное"); }

//Задача 8 Напишите программу, которая принимает на вход число (N) а на выходе показывает все чётные числа от одного до N.

Console.WriteLine("Задача 8");
Console.WriteLine("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());
int temp = 1;
while (temp <= numN)
{
    if (temp % 2 == 0)
    {
        Console.Write(temp+"  ");
        temp++;
    }
        temp++; 
}

