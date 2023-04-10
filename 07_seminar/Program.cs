// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// int PromptNumber(string prompt)
// {
//     Console.Write(prompt);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// double[,] GenerateRandomArray(int m, int n)
// {
//     double[,] array = new double[m, n];
//     Random random = new Random();

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = Math.Round(random.NextDouble(), 2);
//         }
//     }

//     return array;
// }

// void PrintArray(double[,] array)
// {
//     int m = array.GetLength(0);
//     int n = array.GetLength(1);

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int m = PromptNumber("Введите количество строк: ");
// int n = PromptNumber("Введите количество столбцов: ");

// double[,] array = GenerateRandomArray(m, n);

// Console.WriteLine("Сгенерированный массив:");
// PrintArray(array);


// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет


// int[,] GenerateMatrix(int m, int n) {
//     int[,] matrix = new int[m, n];
//     Random rand = new Random();
//     for (int i = 0; i < m; i++) {
//         for (int j = 0; j < n; j++) {
//             matrix[i, j] = rand.Next(1, 101); // заполняем случайными числами от 1 до 100
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix) {
//     int m = matrix.GetLength(0);
//     int n = matrix.GetLength(1);
//     for (int i = 0; i < m; i++) {
//         for (int j = 0; j < n; j++) {
//             Console.Write("{0, 4}", matrix[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

// bool FindNumber(int[,] matrix, int number, out int row, out int column) {
//     int m = matrix.GetLength(0);
//     int n = matrix.GetLength(1);
//     for (row = 0; row < m; row++) {
//         for (column = 0; column < n; column++) {
//             if (matrix[row, column] == number) {
//                 return true;
//             }
//         }
//     }
//     row = -1;
//     column = -1;
//     return false;
// }

// Console.Write("Введите количество строк матрицы: ");
// int m = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов матрицы: ");
// int n = int.Parse(Console.ReadLine());

// int[,] matrix = GenerateMatrix(m, n);
// Console.WriteLine("Сгенерированная матрица:");
// PrintMatrix(matrix);

// Console.Write("Введите число, которое нужно найти в матрице: ");
// int number = int.Parse(Console.ReadLine());

// int row, column;
// if (FindNumber(matrix, number, out row, out column)) {
//     Console.WriteLine("Число {0} находится в позиции [{1}, {2}]", number, row, column);
// } else {
//     Console.WriteLine("Число {0} не найдено в матрице", number);
// }