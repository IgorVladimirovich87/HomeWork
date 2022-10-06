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

