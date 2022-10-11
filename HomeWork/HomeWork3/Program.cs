
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance(double ax, double ay, double az, double bx, double by, double bz)
{
    return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
}
Console.Write("Введите коордитану X точки A: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Y точки A: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Z точки A: ");
double az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Точка A будет иметь координаты ({ax}, {ay}, {az}).");
Console.Write("Введите коордитану X точки B: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Y точки B: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Z точки B: ");
double bz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Точка B будет иметь координаты ({bx}, {by}, {bz}).");
Console.WriteLine($"Расстояние между точкой A({ax}, {ay}, {az}) и точкой B({bx}, {by}, {bz}) равно {Math.Round(FindDistance(ax, ay, az, bx, by, bz), 2)}.");
*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void QuartsNumbers(int n)
{
    {
    int count = 1;
    while (count <= n)
    {
        Console.Write($"{Math.Pow(count, 3)}");
        if (count < n) Console.Write(", ");
        count++;
    }
}
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
QuartsNumbers(n);
*/

//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palidorm (int num)
{
    
    {
        int firstDigit = num / 10000;
        int lastDigit = num % 10;
        if (firstDigit == lastDigit)
        {
            int newNum = num % 10000 / 10;
            firstDigit = newNum / 100;
            lastDigit = newNum % 10;
            if (firstDigit == lastDigit)
                Console.WriteLine($"Число {num} палиндорм.");
        }
        else
            Console.WriteLine($"Число {num} не является палиндромом.");

    }
}

Console.Write("Введите 5 знасное число, которое будем проверять на палиндром: ");
int number = Convert.ToInt32(Console.ReadLine());
Palidorm(number);
*/