// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.WriteLine("Задача 2");
// Console.Write("Введите первое число ");
// int numA = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число ");
// int numB = int.Parse(Console.ReadLine());

// if (numA > numB) Console.WriteLine(numA); 
// else Console.WriteLine(numB);



// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int c = int.Parse(Console.ReadLine());

// int max = a;
// if (b > max) {
//     max = b;
// }
// if (c > max) {
//     max = c;
// }

// Console.WriteLine("Максимальное число: " + max);



// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// // Вариант 1
// if (num % 2 == 0) {
// Console.WriteLine(num + " является чётным числом");
// } else {
// Console.WriteLine(num + " является нечётным числом");
// }

// // Вариант 2
// string result = num % 2 == 0 ? "чётным" : "нечётным";
// Console.WriteLine(num + " является " + result);

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

// Console.Write("Чётные числа от 1 до " + N + ": ");
// int i = 1;
// while (i <= N) {
//     if (i % 2 == 0) {
//     Console.Write(i + " ");
//     }
//     i++;
// }