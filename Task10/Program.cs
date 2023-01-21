// Задача 10: Напишите программу, которая 
// 1.принимает на вход трёхзначное число и 
// 2.на выходе показывает вторую цифру этого числа.
// 456 -> 5 
// 782 -> 8 
// 918 -> 1


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = FirstNumber(number);

int FirstNumber(int num)
{
    int firstDigit = num / 10;
    int lastDigit = num % 100;
    int result = lastDigit / 10;
    return result;
}
Console.WriteLine($"{result}");
