// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int APowB(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
        res *= a;
    return res;
}

Console.WriteLine("Цикл, который возводит первое число в степень второго числа ");
Console.Write("Введите первое число >: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число >: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{numA}^{numB} = {APowB(numA, numB)}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumOfDigits(int num)
{
    int res = 0;
    if (num < 0) num *= -1; // если число отрицательное, то умножаем на -1, чтобы сделать его положительным.

    while (num > 0)
    {
        res += num % 10;
        num /= 10;
    }
    return res;
}
Console.Write("Введите число >: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {number} равна {SumOfDigits(number)}.");
*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] MakeIntArray(int size, int minValue, int maxValue) 
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintIntArray(int[] array)
{
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine(" }");
}

Console.Write("Введите размер массива >: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
    while (arrSize < 0)
    {
        Console.WriteLine("Размер массива не может быть отрицательным, введите неотрицательное число ");
        arrSize = Convert.ToInt32(Console.ReadLine());
    }

Console.Write("Введите нижнюю границу для генерации чисел >: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите верхнюю границу для генерации чисел >: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

PrintIntArray(MakeIntArray(arrSize, minValue, maxValue));
*/