//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
        for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}
 void PrintArray(int[] array)
 {
    Console.Write("Created array: { ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
 }
int AmountEvenNumbers(int[] array)
{
    int amount = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) 
            amount++;
    }
    return amount;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное 3-х значное число: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное 3-х значное число: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] yourArray = CreateArray(size, minValue,maxValue);
PrintArray(yourArray);
int result = AmountEvenNumbers(yourArray);
Console.WriteLine($"количество чётных чисел в массиве = {result}.");
*/


//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
        for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}
 void PrintArray(int[] array)
 {
    Console.Write("Created array: { ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
 }
int SumUnevenIndexNums(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum = sum + array[i];
    return sum;
}
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнюю границу для генерации чисел >: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнюю границу для генерации чисел >: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] yourArray = CreateArray(size, minValue,maxValue);
PrintArray(yourArray);
int result = SumUnevenIndexNums(yourArray);
Console.WriteLine($"Сумма элементов массива с нечетными индексами равна = {result}.");
*/


// Задача №3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] CreateArray(int size)
{
    double[] array = new double[size];
        for(int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}
 void PrintArray(double[] array)
 {
    Console.Write("Created array: { ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
 }
double DifMaxMin(double[] array)
{
    double dif = 0;
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        else if(array[i] < min)
            min = array[i];
        dif = max - min;
    }
    Console.WriteLine($"Максимальный элемент в вашем массиве = {max}.");
    Console.WriteLine($"Минимальный элемент в вашем массиве = {min}.");
    return dif;
}
Console.Write("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());
double[] yourArray = CreateArray(size);
PrintArray(yourArray);
double result = DifMaxMin(yourArray);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Разница между максимальными и минимальными элементами массива = {result}.");
*/