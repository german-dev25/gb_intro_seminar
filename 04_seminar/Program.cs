// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

// int Power(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result *= a;
//     }
//     return result;
// }

// Console.WriteLine("Введите число A:");
// int a = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число B:");
// int b = int.Parse(Console.ReadLine());

// int result = Power(a, b);
// Console.WriteLine($"{a} в степени {b} равно {result}");


// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// int NumSum (int numForSum)
// {
//     int sum = 0;
//     while (numForSum > 0) {
//         sum += numForSum % 10;
//         numForSum /= 10;
//     }
//     return sum;
// }

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());


// Console.WriteLine("Сумма цифр: " + NumSum(num));


// // Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// static int[] GenerateRandomArray(int N)
// {
//     Random rnd = new Random();
//     int[] arr = new int[N];

//     for (int i = 0; i < N; i++)
//     {
//         arr[i] = rnd.Next(1, 101);
//     }

//     return arr;
// }

// Console.WriteLine("Введите количество элементов массива:");
// int N = int.Parse(Console.ReadLine());

// int[] arr = GenerateRandomArray(N);

// Console.WriteLine("Сгенерированный массив:");
// foreach (int element in arr)
// {
//     Console.Write(element + " ");
// }