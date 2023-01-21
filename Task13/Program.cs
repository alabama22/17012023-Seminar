// Задача 13: Напишите программу, 
// 1. которая выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет 
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = (int)Math.Log10(number) - 2;
Console.WriteLine(result < 0 ? "Третьей цифры нет " : (number % (int)Math.Pow(10, result + 1) / (int)Math.Pow(10, result)));