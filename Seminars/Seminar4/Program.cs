// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int GetSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current++)
    
        sum += current;
    return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetSum(num);

Console.WriteLine($"Сумма элементов {num} равно {s}");
*/

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
int NumDigitsInNumber(int num)
{
    int div = 10;
    int cur = 1;
    
    for (int n = num; n > 10; cur++)
    {
        n = num/ div;
        div *=10;
    }
    return cur;
}

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = NumDigitsInNumber(num);
Console.WriteLine($"В числе {num} кол-во цифр {res}" );
*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
/*
int Factorial(int n)
{
    int fact = 1;
    for(int current = 1; current <= n; current++)
        fact *= current;
    return fact;
}

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int fact = Factorial(num);
Console.WriteLine($"Произведение чисел от 1 до {num} равно {fact}" );
*/

//Напишите программу, которая выводит массив из M элементов, заполненный нулями и единицами в случайном порядке.

