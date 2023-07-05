// Задача №6
// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на 2 без остатка)
Console.WriteLine("Введите число");
string input = Console.ReadLine();
int number = int.Parse(input);
Console.WriteLine("Введенное число: {0}", number);
if (number % 2 == 0)
    Console.WriteLine("Число {0} четное", number);
else
    Console.WriteLine("Число {0} нечетное", number);
