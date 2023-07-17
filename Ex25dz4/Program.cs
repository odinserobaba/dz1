/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
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
int GetPow(int a, int b)
{
    int tmp = 1;
    for (int i = 1; i <= b; i++)
    {
        tmp *= a;
    }
    return tmp;
}

while (true)
{
    Console.WriteLine("Вам нужно ввести два числа pow(A,B)");
    Console.WriteLine("Введите А");
    int a = GetIntegers(Console.ReadLine());
    if (a == 0)
        continue;
    Console.WriteLine("Введите B");
    int b = GetIntegers(Console.ReadLine());
    if (b == 0)
        continue;
    Console.WriteLine($"pow(A,B) {GetPow(a,b)}");
    break;
}

