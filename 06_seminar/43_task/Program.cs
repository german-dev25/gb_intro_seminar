// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// координата точки пересечения X
double FindX(double k1, double b1, double k2, double b2)
{
    return (b2 - b1) / (k1 - k2);
}

// координата точки пересечения Y
double FindY(double k, double b, double x)
{
    return k * x + b;
}

// ввод данных пользователем и вычисление координат
double k1, b1, k2, b2;
Console.WriteLine("Введите значения k1, b1, k2, b2:");
k1 = PromptNumber("k1");
b1 = PromptNumber("b1");
k2 = PromptNumber("k2");
b2 = PromptNumber("b2");

double x = FindX(k1, b1, k2, b2);
double y = FindY(k1, b1, x);

Console.WriteLine("Точка пересечения прямых: ({0}, {1})", x, y);

double PromptNumber(string name)
{
    double result;
    while (true)
    {
        Console.Write("{0}: ", name);
        if (double.TryParse(Console.ReadLine(), out result))
        {
            return result;
        }
        Console.WriteLine("Ошибка: введите число.");
    }
}