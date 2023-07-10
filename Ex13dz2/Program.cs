// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int GetThirdDigit(int number)
{

    int secondDigit = number % 10;
    return secondDigit;
}
if (number < 100)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine(GetThirdDigit(number));