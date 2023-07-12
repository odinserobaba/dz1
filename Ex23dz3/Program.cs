/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до N.");
for(int i = 1; i<=n;i++)
    Console.Write(" {0}",Math.Pow(i,3));