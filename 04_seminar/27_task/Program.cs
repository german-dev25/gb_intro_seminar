// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumSum (int numForSum)
{
    int sum = 0;
    while (numForSum > 0) {
        sum += numForSum % 10;
        numForSum /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());


Console.WriteLine("Сумма цифр: " + NumSum(num));