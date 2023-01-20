// задача 14. Напишите программу, 
// 1. которая принимает на вход число и 
// 2. проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Digit(number);

int Digit(int num)
{
    int res1 = num % 7;
    int res2 = num % 23;
    if (res1 == 0 && res2 == 0) return 1;
    else return 0;
}
if (result == 1) Console.WriteLine("Кратно 7 и 23");
else
{
    Console.WriteLine("Не кратно 7 и 23");
}