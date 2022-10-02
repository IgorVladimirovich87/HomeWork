/*

// Задача 1. текст задачи.

Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if (n1 == quad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/


/*
// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа от -n до n

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/


// Задача 3.

Console.Write("Введите 3-х значное число ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n < 1000)
{
    int lastDigit = n % 10;
    Console.WriteLine($"Последнее число {n} is {n % 10}");
}
else
{
    Console.WriteLine("Неверное число!");
}