// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");

int dayNum = int.Parse(Console.ReadLine());

if (dayNum == 1) Console.WriteLine("Не выходной");
if (dayNum == 2) Console.WriteLine("Не выходной");
if (dayNum == 3) Console.WriteLine("Не выходной");
if (dayNum == 4) Console.WriteLine("Не выходной");
if (dayNum == 5) Console.WriteLine("Не выходной");
if (dayNum == 6) Console.WriteLine("Выходной");
if (dayNum == 7) Console.WriteLine("Выходной");

// if (dayNum == 6 | dayNum == 7) Console.WriteLine("Выходной");
// else Console.WriteLine("Не выходной");