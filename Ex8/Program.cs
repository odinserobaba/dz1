// Задача №8
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа до N
Console.WriteLine("Введите число");
string input = Console.ReadLine();
int N = int.Parse(input);
Console.WriteLine("Введенное число: {0}", N);
for (int i = 1; i < N; i++)
    if(i%2==0)
        Console.WriteLine("Четное число: {0}",i);
