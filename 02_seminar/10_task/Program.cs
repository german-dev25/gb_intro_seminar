// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Вариант 1
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

int secondDigit = (number / 10) % 10;

Console.WriteLine("Вторая цифра введённого числа: " + secondDigit);

// // Вариант 2
// Console.Write("Введите трёхзначное число: ");
// int number = int.Parse(Console.ReadLine());

// string numberToStr = number.ToString();
// char secondChar = numberToStr[1];

// Console.WriteLine("Вторая цифра введённого числа: " + secondChar);