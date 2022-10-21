//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int NumbersGreaterZero(int totalIterations)
{
    int count = 0;
    
    for (var iterationCounter = 0; iterationCounter < totalIterations; iterationCounter++)
    {
        Console.Write($"({iterationCounter+1}/{totalIterations}) Введите число >: ");
        if (Convert.ToInt32(Console.ReadLine()) > 0) count++;
    }
    return count;
}

Console.Write("Сколько чисел будем вводить? >: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Колличество введенных чисел больше нуля: {NumbersGreaterZero(m1)}.");
*/

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//v.1

/*
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
*/


//v.2
/*
double[] IntersectionLines(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    array[0] = (b2-b1)/(k1-k2);
    array[1] = k1 * array[0] + b1;
    return array;
}
void PrintIntersection(double[] array)
{
    Console.Write($"Точка пересечения = [{array[0]}; {array[1]}].");
}

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
if(k1 == k2) Console.WriteLine("Прямые параллельны, точки пересечения нет.");
else
{
    double[] result = IntersectionLines(b1,k1,b2,k2);
    PrintIntersection(result);
}
Console.ReadLine();
*/
