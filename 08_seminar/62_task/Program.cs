// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int size = 4;
int[,] spiralArray = new int[size, size];
int counter = 1;

int rowStart = 0, rowEnd = size - 1, colStart = 0, colEnd = size - 1;

while (rowStart <= rowEnd && colStart <= colEnd)
{
    // заполнение верхней строки
    for (int i = colStart; i <= colEnd; i++)
    {
        spiralArray[rowStart, i] = counter;
        counter++;
    }
    rowStart++;

    // заполнение правого столбца
    for (int i = rowStart; i <= rowEnd; i++)
    {
        spiralArray[i, colEnd] = counter;
        counter++;
    }
    colEnd--;

    // заполнение нижней строки (в обратном порядке)
    for (int i = colEnd; i >= colStart; i--)
    {
        spiralArray[rowEnd, i] = counter;
        counter++;
    }
    rowEnd--;

    // заполнение левого столбца (в обратном порядке)
    for (int i = rowEnd; i >= rowStart; i--)
    {
        spiralArray[i, colStart] = counter;
        counter++;
    }
    colStart++;
}

// вывод массива на консоль
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write("{0,2} ", spiralArray[i, j]);
    }
    Console.WriteLine();
}
