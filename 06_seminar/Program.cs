// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

// {
// int m = PromptNumber("Введите количество чисел: ");
// int[] numbers = new int[m];

// for (int i = 0; i < m; i++)
// {
//     numbers[i] = PromptNumber($"Введите число {i + 1}: ");
// }

// int count = CountPositive(numbers);
// Console.WriteLine($"Количество положительных чисел: {count}");
// }

// int PromptNumber(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine());
// }

// int CountPositive(int[] numbers)
// {
//     int count = 0;
//     foreach (int number in numbers)
//     {
//         if (number > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// // координата точки пересечения X
// double FindX(double k1, double b1, double k2, double b2)
// {
//     return (b2 - b1) / (k1 - k2);
// }

// // координата точки пересечения Y
// double FindY(double k, double b, double x)
// {
//     return k * x + b;
// }

// // ввод данных пользователем и вычисление координат
// double k1, b1, k2, b2;
// Console.WriteLine("Введите значения k1, b1, k2, b2:");
// k1 = PromptNumber("k1");
// b1 = PromptNumber("b1");
// k2 = PromptNumber("k2");
// b2 = PromptNumber("b2");

// double x = FindX(k1, b1, k2, b2);
// double y = FindY(k1, b1, x);

// Console.WriteLine("Точка пересечения прямых: ({0}, {1})", x, y);

// double PromptNumber(string name)
// {
//     double result;
//     while (true)
//     {
//         Console.Write("{0}: ", name);
//         if (double.TryParse(Console.ReadLine(), out result))
//         {
//             return result;
//         }
//         Console.WriteLine("Ошибка: введите число.");
//     }
// }