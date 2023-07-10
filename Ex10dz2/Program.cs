// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

int GetSecondDigit(int number)
{

    int secondDigit = (number / 10) % 10;
    return secondDigit;
}
if (number < 100 || number > 999)
    Console.WriteLine("Число не трехзначное");
else
    Console.WriteLine(GetSecondDigit(number));