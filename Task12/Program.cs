﻿// Задача 12. Напишите программу, 
// 1.которая будет принимать на вход два числа 
// 2.и выводить, является ли первое число кратным второму. 
// 3.Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int MultipleNum(int num1, int num2)
{
    return num1%num2;
}
Console.WriteLine($"Введите два числа: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remains=MultipleNum(firstNumber, secondNumber);

if (remains==0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($" Некратно, остаток {remains} ");
}