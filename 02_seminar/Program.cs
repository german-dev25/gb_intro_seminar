// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // Вариант 1
// Console.Write("Введите трёхзначное число: ");
// int number = int.Parse(Console.ReadLine());

// int secondDigit = (number / 10) % 10;

// Console.WriteLine("Вторая цифра введённого числа: " + secondDigit);

// // Вариант 2
// Console.Write("Введите трёхзначное число: ");
// int number = int.Parse(Console.ReadLine());

// string numberToStr = number.ToString();
// char secondChar = numberToStr[1];

// Console.WriteLine("Вторая цифра введённого числа: " + secondChar);


// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Console.Write("Введите число: ");

// int number = Int32.Parse(Console.ReadLine());

// int numToWork = Math.Abs(number);

// if (numToWork < 100) Console.WriteLine("Третьей цифры нет");
// else {
//     while (numToWork >= 1000) numToWork /= 10;
//     int thirdDigit = (numToWork % 10);
//     Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}.");
// }

// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите число от 1 до 7: ");

// int dayNum = int.Parse(Console.ReadLine());

// if (dayNum == 1) Console.WriteLine("Не выходной");
// if (dayNum == 2) Console.WriteLine("Не выходной");
// if (dayNum == 3) Console.WriteLine("Не выходной");
// if (dayNum == 4) Console.WriteLine("Не выходной");
// if (dayNum == 5) Console.WriteLine("Не выходной");
// if (dayNum == 6) Console.WriteLine("Выходной");
// if (dayNum == 7) Console.WriteLine("Выходной");

// // if (dayNum == 6 | dayNum == 7) Console.WriteLine("Выходной");
// // else Console.WriteLine("Не выходной");