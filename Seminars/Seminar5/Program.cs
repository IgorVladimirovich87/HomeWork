// Задайте массив из 5 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i=0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }

    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int result = SumOfNegatives(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of a negative elements is " + result);
*/

//Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();
}

int [] ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }

return array;    
}

int[] myArray = CreateRandomArray(5, -100, 100);
ShowArray(myArray);
int[] reversed = ReverseArray(myArray);
ShowArray(reversed);
*/


//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}
bool Find(int num, int[] array)
{
    bool find = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {  find = true;
            break;
        }

    }
    return find;

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();
}
}
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, -10, 10);
bool Find = find(number, newArray);
ShowArray(newArray);
Console.WriteLine("$Число {number} содержится  нашем массиве это {find}");
*/

//Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}
int minValue = 10;
int maxValue =99;
int Count(int[] array, int minValue, int maxValue)
{
    int count = 0;
    for (int i=0; i< array.Length; i++)
    {
        if(array[i] >= minValue && array[i] <= maxValue) count++;
    }
    return count;
}
void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int[] arrayToFind = CreateRandomArray(12, -100, 150);
ShowArray(arrayToFind);
int count = Count(arrayToFind, minValue, maxValue);
Console.WriteLine(count);
*/