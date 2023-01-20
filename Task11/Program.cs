// 11. Напишите программу, 
// 1. которая выводит случайное трёхзначное число 
// 2. и удаляет вторую цифру этого числа.
// 456 -> 46 
// 82 -> 72 
// 918 -> 98

int number =new Random().Next(100,1000);
Console.WriteLine($" Случайное трехзначное число {number}");

int Digit=randomDigit(number);
Console.WriteLine($"первое и конечное число {Digit}");
int randomDigit(int num)
{
    int firstDigit=num/100;
    int lastDigit=num%10;
    int result=firstDigit*10+lastDigit;
    return result;
}

// int randomNumber= new Random().Next(100, 1000);
// Console.WriteLine ($"Трехзначное число=> {randomNumber}");//итнрополяция строки
// int finishNumber=GetNumber(randomNumber);
// Console.WriteLine($"Первое и конечное число=> {finishNumber}");

// int GetNumber(int number)
// {
//     int firstNumber=number/100;
//     int secondNumber=number%10;
//     int result=firstNumber*10+secondNumber;
//     return result;
//} 