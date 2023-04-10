// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

// Вариант 1
if (num % 2 == 0) {
Console.WriteLine(num + " является чётным числом");
} else {
Console.WriteLine(num + " является нечётным числом");
}

// Вариант 2
string result = num % 2 == 0 ? "чётным" : "нечётным";
Console.WriteLine(num + " является " + result);