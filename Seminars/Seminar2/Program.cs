// Написать программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
/*
int FindBiggestDigit(int num)

{
    int max;

    int ed = num % 10;
    int dec = num / 10;

    if(ed > dec)
        max = ed;
    else
        max = dec;

    return max;       
}

int number = new Random().Next(10,100);
int biggestDigit = FindBiggestDigit(number);

Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
*/

// Напишите программу, которая выводит случайное 3-х значное число и удаляет вторую циифру этого числа.

/*
int TwoDigitNumber(int num)
{
    int result;

    int ed = num % 10;
    int dec = num / 100;

    result = dec * 10 + ed;
    return result;
}

int number =new Random().Next(100, 1000);
int TwoDigit = TwoDigitNumber(number);

Console.WriteLine($" чило из первой и последней цифры от {number} это {TwoDigit}");
*/

// Написать программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

bool MultiplenNumber(int number, int a, int b)
{
    bool result;

    if (number % a ==0 && number % b == 0 )
    {
        result = true;   
    }
    else
    {
        result=false;
    }
    return result;
}

Console.Write("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the first divisor ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second divisor ");
int b = Convert.ToInt32(Console.ReadLine());

bool res = MultiplenNumber(number, a, b);
Console.WriteLine(res);

