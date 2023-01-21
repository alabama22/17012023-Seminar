// Задача 15: Напишите программу, 
// 1. которая принимает на вход цифру, обозначающую день недели, 
// 2. и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 6)
{
    Console.WriteLine("нет");
}
else if (number == 6)
{
    Console.WriteLine("да");
}
// else if (number == 3)
// {
//     Console.WriteLine("нет");
// }
// else if (number == 4)
// {
//     Console.WriteLine("нет");
// }
// else if (number == 5)
// {
//     Console.WriteLine("нет");
// }
// else if (number == 6)
// {
//     Console.WriteLine("да");
// }
else if (number == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Введите цифру от 1 до 7!");
}