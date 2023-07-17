/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int GetIntegers(string numb)
{
    try
    {
        if (int.Parse(numb) > 0)
            return int.Parse(numb);
        else
        {
            Console.WriteLine($"Число {numb} не натуральное");
            return 0;
        }
    }
    catch
    {
        Console.WriteLine("Ошибка, это не число!");
        return 0;
    }
}

int GetNumbersSum(int number)
{
    var sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

while (true)
{
    Console.WriteLine("Введите число: ");
    int a = GetIntegers(Console.ReadLine());
    if (a <= 0)
        continue;
    Console.WriteLine($"Цифры : {GetNumbersSum(a)}");
    break;
}