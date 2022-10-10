// Программа, принимает на вход координат точки ( Х и У), причем Х и Y неравно 0 и выдает номер четверти

/*
 int FindQuard(double x, double y)
 {
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
 } 

Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The point A({x}, {y}) is on the {FindQuard(x,y)} quart");
*/

// Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void FindRange (int quart)
{
    if (quart == 1)
    {
        Console.WriteLine("x > 0 && y > 0");
    }
    if (quart == 2)
    {
        Console.WriteLine("x < 0 && y > 0");
    }
    if (quart == 3)
    {
        Console.WriteLine("x < 0 && y < 0");
    }
    if (quart == 4)
    {
        Console.WriteLine("x > 0 && y < 0");
    }
}

Console.Write("Input quard: ");
int quart = Convert.ToInt32(Console.ReadLine());
FindRange(quart);
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Distance(double xa, double ya, double xb, double yb)
{
    return Math.Sqrt(Math.Pow((xb-xa),2) + Math.Pow((yb-ya),2));  
}

Console.Write("Input xa: ");
Double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input ya: ");
Double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xb: ");
Double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yb: ");
Double yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Distance(xa, xb, ya, yb));