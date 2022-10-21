/*
int[] CreateRandomArray()
{
    Console.Write("Input a number of elements");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min of elements");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max of elements");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] aray = new int[size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new random().Next(min, max + 1);

    return array;
}

int[] myArray = CreateRandomArray();
ShowArray(myArray);
*/

// Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
void ReveraeArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++) // array.Lenght / 2 - до половины массива, т.к. нам нужно его развернуть
    {
        int temp = array[i];
        array[i] = array[array.Length -1 - i];
        array[array.Length -1 - i] = temp;
    }
}
*/

//Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
/*
 bool ExistanceTriangle(double a, double b, double c)
 {
    if(a < b + c && b < a + c && c < a + b) return true;
    return false;
 }

Console.Write("Введите размер стороны А >: ");
double sideA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите размер стороны B >: ");
double sideB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите размер стороны C >: ");
double sideC = Convert.ToDouble(Console.ReadLine());
bool resTask1 = ExistanceTriangle(sideA, sideB, sideC);
if (resTask1) Console.Write("Треугольник существует");
else Console.Write("Треугольник не существует");
*/


//Напишите программу, 
//которая будет создавать копию заданного массива с помощью поэлементного копирования.

/*
int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
        copy[i] = array[i];
    
    return copy;
}

int[] CreateRandomArray()
{
    Console.Write("Input a number of elements:> ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min of elements:> ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max of elements:> ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
       array[i] = new Random().Next(min, max + 1);
    
    return array;
}

void ShowArray(int[] array)
 {
    Console.Write("Created array: { ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
 }

int[] arrTask2 = CreateRandomArray();
ShowArray(arrTask2);
int[] copeArrTak2 = CopyArray(arrTask2);
ShowArray(arrTask2);
*/

// Фибонначи
/*
void ShowArray(int[] array)
 {
    Console.Write("Created array: { ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
 }

int[] Fibonacci(int n, int a, int b)
{
    int[] fibArray = new int[n];
    fibArray[0] = a;
    fibArray[1] = b;

    for (int i = 2; i < fibArray.Length; i++)
        fibArray[i] = fibArray[i-1] + fibArray[i-2];
    return fibArray;
}
Console.Write("Input a number of elements:> ");
int fibN = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min of elements:> ");
int fibA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max of elements:> ");
int fibB = Convert.ToInt32(Console.ReadLine());

int[] arrTask3 = Fibonacci(fibN, fibA, fibB);
ShowArray(arrTask3);
*/





/*
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
*/
