// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int sum = SumFromMToN(m, n);
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {sum}");

int SumFromMToN(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else if (m > n)
    {
        return 0;
    }
    else
    {
        return m + SumFromMToN(m + 1, n);
    }
}
