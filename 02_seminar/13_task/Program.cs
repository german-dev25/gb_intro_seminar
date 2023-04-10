// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");

int number = Int32.Parse(Console.ReadLine());

int numToWork = Math.Abs(number);

if (numToWork < 100) Console.WriteLine("Третьей цифры нет");
else {
    while (numToWork >= 1000) numToWork /= 10;
    int thirdDigit = (numToWork % 10);
    Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}.");
}