// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Write("Введите пятизначное число: ");
// int number = Math.Abs(int.Parse(Console.ReadLine()));

// if (number < 10000 || number > 99999) {
// Console.WriteLine("Число не является пятизначным");
// } else {
// int a = number / 10000;
// int b = (number / 1000) % 10;
// int c = (number / 10) % 10;
// int d = number % 10;

// if (a == d && b == c) {
//     Console.WriteLine("Число является палиндромом");
// } else {
//     Console.WriteLine("Число не является палиндромом");
// }
// }


// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты первой точки:");

// Console.Write("x1 = ");
// double x1 = double.Parse(Console.ReadLine());
// Console.Write("y1 = ");
// double y1 = double.Parse(Console.ReadLine());
// Console.Write("z1 = ");
// double z1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки:");

// Console.Write("x2 = ");
// double x2 = double.Parse(Console.ReadLine());
// Console.Write("y2 = ");
// double y2 = double.Parse(Console.ReadLine());
// Console.Write("z2 = ");
// double z2 = double.Parse(Console.ReadLine());

// double distance = Math.Sqrt(
//     Math.Pow(x2 - x1, 2)
//     + Math.Pow(y2 - y1, 2) 
//     + Math.Pow(z2 - z1, 2)
//     );
// Console.WriteLine($"Расстояние между точками: {distance:F2}");


// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine("Таблица кубов чисел от 1 до " + n + ":");
// Console.WriteLine("==================");

// for (int i = 1; i <= n; i++) {
//     Console.WriteLine(i + " ^ 3 = " + (i * i * i));
// }