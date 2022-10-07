// Задача 10: Написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
/*
int FindSecondDigit(int num)
{   int result;

    int number = num / 10 % 10;
    
    result = number; 
    return result;
}

Console.Write ("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = FindSecondDigit(number);
Console.WriteLine($"Второе число из {number} это {secondDigit}" );
*/

// Задача 15. Программа, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным.
/*
bool HolidayDays(int day)
{
    bool result;
    if (day == 6 ^ day == 7)
        result = true;
    else
        result = false;
    return result;
}

Console.Write ("Введите число обозночающие день недели ");
int dayNumber = Convert.ToInt32 (Console.ReadLine());
bool isHoliday = HolidayDays(dayNumber);
    if (isHoliday)
        Console.WriteLine($"Да {dayNumber} день выходной ");
    else
        Console.WriteLine($"Нет {dayNumber} день не выходной");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
string ThirdDigit (int num)
{
    string result;
    string numString = Convert.ToString(num);
    if (numString.Length < 3)
        result = "Нет 3 числа.";
    else
    {
        char third = numString[2];
        result = $"Третье число {num} это {third}.";
    }
    
    return result;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string thirdDigit = ThirdDigit(number);
Console.WriteLine(thirdDigit);
*/