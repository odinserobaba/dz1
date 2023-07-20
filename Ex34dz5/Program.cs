/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] GetArray(int volume)
{
    int[] arr = new int[volume];
    var rand = new Random();
    for (int i = 0; i < volume; i++)
        arr[i] = rand.Next(100, 999);
    return arr;
}
Console.WriteLine("Введите длину массива: ");
int volume = int.Parse(Console.ReadLine());
var arr = GetArray(volume);

Console.WriteLine($"Сгенерированный массив из {volume} элементов: ");
int sum=0;

foreach (var x in arr)
{
    Console.WriteLine(x);
    if(x%2==0)
        sum++;
}
Console.WriteLine($"Количество четных элементов в массиве: {sum} ");




